using System;
using System.Data.SQLite;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;

// TODO: Add Moon & Planet count
// TODO: Add Color Translator for Galaxy (might be useful for design)
// TODO: Add all the other tabs
// TODO: Handle NullException for not visible elements in lists

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

            reader?.Close();
        }
        
        private SQLiteDataReader GetDatabase(string sql) {
            SQLiteDataReader reader = null;
            
            SQLiteConnection connection = new SQLiteConnection(new Utils().CONNECTIONSTRING); 
            connection.Open();
            
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader rdr = command.ExecuteReader();
            
            if (rdr.HasRows) reader = rdr;

            return reader;
        }

        // EVENTS TAB1
        private void Tab1GalaxyList_SelectedIndexChanged(object sender, EventArgs e) {
            ListFiller("t1_system", $"SELECT DISTINCT SystemName FROM NMS_System, Galaxy WHERE NMS_System.GalaxyID=\"{Tab1GalaxyList.SelectedIndex}\";");        
        }

        private void Tab1SystemList_SelectedIndexChanged(object sender, EventArgs e) {
            Tab1SelectedSystemLabel.Text = Tab1SystemList.SelectedItem.ToString().ToUpper();
            Tab1PlanetList.Items.Clear();

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
                while (reader.Read()) {
                    // Save Data in object
                    PlanetaryData sP = new PlanetaryData {
                        PlanetID = reader.GetInt32(0),
                        PlanetName = reader.GetString(1),
                        PlanetType = reader.GetString(2),
                        PlanetDescription = reader.GetString(3),
                        SystemID = reader.GetInt32(4),
                        OreTypes = reader.GetString(5),
                        PlanetImage = reader.GetString(6)
                    };

                    if (sP.PlanetImage != "about:blank") {
                        Tab1ImageOfPlanet.Visible = true;
                        try {
                            Tab1ImageOfPlanet.DocumentText =
                                "<html style=\"border:none\">" +
                                "<body scroll=\"no\" style=\"padding:0px;margin:0px;\">" +
                                "<img src=\"" + sP.PlanetImage + "\" alt=\"\" width=\"100%\" heights=\"100%\">" +
                                "</body>" +
                                "</html>";
                        }
                        catch (UriFormatException) {
                        }
                    } else {
                        Tab1ImageOfPlanet.Visible = false;
                    }

                    Tab1PlanetNameLabel.Text = sP.PlanetName;
                    Tab1DescriptionLabel.Text = sP.PlanetDescription;
                }
            reader?.Close();
        }
    }
}

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")] // Not used message annoyed me...
public class PlanetaryData {
    public    int PlanetID          { get; set; }
    public string PlanetImage       { get; set; }
    public string PlanetName        { get; set; }
    public string PlanetDescription { get; set; }
    public string PlanetType        { get; set; }         
    public    int SystemID          { get; set; }           
    public string OreTypes          { get; set; }
}

public class SystemData {
    public    int SystemID          { get; set; }
    public string SystemName        { get; set; }
    public    int GalaxyID          { get; set; }
    public    int PlanetCount       { get; set; }
    public    int MoonCount         { get; set; }
    public string Species           { get; set; }         
    public string Economy           { get; set; }           
    public string Conflict          { get; set; }
}

public class GalaxyData {
    public    int GalaxyID          { get; set; }
    public string GalaxyName        { get; set; }
    public string GalaxyType        { get; set; }         
    public string GalaxyColor       { get; set; }
}