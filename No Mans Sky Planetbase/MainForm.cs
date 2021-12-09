using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

/*@"SELECT SystemID, SystemName, NMS_System.GalaxyID, Galaxy.GalaxyName FROM NMS_System, Galaxy WHERE Galaxy.GalaxyID = NMS_System.GalaxyID;"*/

namespace No_Mans_Sky_Planetbase {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            
            SystemInspector.BackColor = ColorTranslator.FromHtml("#AA101010");
            
            //FILL LISTSBOX
            ListFiller("t1_galaxy", @"SELECT GalaxyName FROM Galaxy");
            Tab1GalaxyList.SelectedIndex = 0;
            int euclid_temp = Tab1GalaxyList.SelectedIndex;
            ListFiller("t1_system", $"SELECT DISTINCT SystemName FROM NMS_System, Galaxy WHERE NMS_System.GalaxyID={euclid_temp};");
        }
        
        //FUNCTIONS
        private void ListFiller(string listname, string sql) {
            switch (listname) {
                case "t1_galaxy": Tab1GalaxyList.Items.Clear(); break;
                case "t1_system": Tab1SystemList.Items.Clear(); break;
                case "t1_planet": Tab1PlanetList.Items.Clear(); break;
            }
            
            SQLiteDataReader reader = GetDatabase(sql);

            if(reader != null)
                while (reader.Read())
                    switch (listname) {
                        case "t1_galaxy": Tab1GalaxyList.Items.Add(reader.GetString(0)); break;
                        case "t1_system": Tab1SystemList.Items.Add(reader.GetString(0)); break;
                        case "t1_planet": Tab1PlanetList.Items.Add(reader.GetString(0)); break;
                    }

            if (reader != null) reader.Close(); 
        }
        
        private SQLiteDataReader GetDatabase(string sql) {
            SQLiteDataReader reader = null;
            
            SQLiteConnection connection = new SQLiteConnection(new Utils().GetConnectionString()); 
            connection.Open();
            
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader rdr = command.ExecuteReader();
            
            if (rdr.HasRows) reader = rdr;

            return reader;
        }

        // EVENTS
        private void Tab1GalaxyList_SelectedIndexChanged(object sender, EventArgs e) {
            ListFiller("t1_system", $"SELECT DISTINCT SystemName FROM NMS_System, Galaxy WHERE NMS_System.GalaxyID=\"{Tab1GalaxyList.SelectedIndex}\";");        }

        private void Tab1SystemList_SelectedIndexChanged(object sender, EventArgs e) {
            Tab1SelectedSystemLabel.Text = Tab1SystemList.SelectedItem.ToString().ToUpper();

            SQLiteDataReader reader = GetDatabase($"SELECT SpeciesType FROM NMS_System WHERE SystemName=\"{Tab1SystemList.SelectedItem}\";");
            string species = null;

            if(reader != null)
                while (reader.Read())
                    species = reader.GetString(0).ToLower();
            if (reader != null) reader.Close(); 

            switch(species) {
                case "gek":    Tab1ShowSpecies.BackgroundImage = Properties.Resources.STANDING;  break;
                case "vykeen": Tab1ShowSpecies.BackgroundImage = Properties.Resources.STANDING1; break;
                case "korvax": Tab1ShowSpecies.BackgroundImage = Properties.Resources.STANDING2; break;
                default: Tab1ShowSpecies.BackgroundImage = Properties.Resources.Icon_Atlas_Interface; break;
            }
            
            ListFiller("t1_planet", $"SELECT DISTINCT PlanetName FROM Planet, NMS_System WHERE Planet.SystemID=NMS_System.SystemID AND SystemName=\"{Tab1SystemList.SelectedItem}\";");
        }

        private void Tab1PlanetList_SelectedIndexChanged(object sender, EventArgs e) {
            SQLiteDataReader reader = GetDatabase($"SELECT * FROM Planet WHERE PlanetName=\"{Tab1PlanetList.SelectedItem}\";");
            
            if(reader != null)
                while (reader.Read());
                    //TODO: Add Code here
            if (reader != null) reader.Close(); 
        }
    }
}