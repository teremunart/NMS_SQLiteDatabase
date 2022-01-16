using System;
using System.Data.SQLite;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;

// TODO: Add Color Translator for Galaxy (might be useful for design)
// TODO: Add all the other tabs

namespace NMS_Database {
    public partial class MainForm : Form {
        private readonly PictureBox[] _portalBar = new PictureBox[12];
        
        public MainForm() {
            InitializeComponent();
            
            SystemInspector.BackColor = ColorTranslator.FromHtml("#AA101010");
            
            //FILL LISTSBOX
            ListFiller("t1_galaxy", @"SELECT GalaxyName FROM Galaxy");
            Tab1GalaxyList.SelectedIndex = 1;
            int euclidTemp = Tab1GalaxyList.SelectedIndex;
            ListFiller("t1_system", $"SELECT DISTINCT SystemName FROM NMS_System, Galaxy WHERE NMS_System.GalaxyID={euclidTemp};");
            //Fill PictureBox Array
            _portalBar[0] = portal_1;
            _portalBar[1] = portal_2;
            _portalBar[2] = portal_3;
            _portalBar[3] = portal_4;
            _portalBar[4] = portal_5;
            _portalBar[5] = portal_6;
            _portalBar[6] = portal_7;
            _portalBar[7] = portal_8;
            _portalBar[8] = portal_9;
            _portalBar[9] = portal_10;
            _portalBar[10] = portal_11;
            _portalBar[11] = portal_12;
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
            
            SQLiteConnection connection = new SQLiteConnection(new Utils().Connectionstring); 
            connection.Open();
            
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader rdr = command.ExecuteReader();
            
            if (rdr.HasRows) reader = rdr;

            return reader;
        }

        // EVENTS TAB1
        private void Tab1GalaxyList_SelectedIndexChanged(object sender, EventArgs e) {
            //Add Function to update Systems because with the search tool it does not work anymore.
            //Added function to support the searchbar

            string test = Tab1GalaxyList.SelectedItem.ToString();
            
            try {
                string sql = $"SELECT GalaxyID, GalaxyName FROM Galaxy WHERE GalaxyName='{test}'";
                SQLiteDataReader reader = GetDatabase(sql);
            
                int selectedGalaxyId = reader.GetInt32(0);
                ListFiller("t1_system", $"SELECT DISTINCT SystemName FROM NMS_System, Galaxy WHERE NMS_System.GalaxyName=\"{selectedGalaxyId}\";");
            }
            catch (Exception exception) {
                //ignore
            }
        }

        private void Tab1SystemList_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                Tab1SelectedSystemLabel.Text = Tab1SystemList.SelectedItem.ToString().ToUpper();
                Tab1PlanetList.Items.Clear();
                
                SQLiteDataReader reader = GetDatabase($"SELECT * FROM NMS_System WHERE SystemName=\"{Tab1SystemList.SelectedItem}\";");
                SystemData data = new SystemData();
            
                if(reader != null)
                    while (reader.Read()) {
                        data.SystemId    = reader.GetInt32(0);
                        data.SystemName  = reader.GetString(1);
                        data.GalaxyId    = reader.GetInt32(2);
                        data.PlanetCount = reader.GetInt32(3);
                        data.Species     = reader.GetString(4);
                        data.Economy     = reader.GetString(5);
                        data.Conflict    = reader.GetString(6);
                        data.MoonCount   = reader.GetInt32(7);
                        data.Coords      = reader.GetString(8);
                    }
                reader?.Close();

                // Set Species
                Tab1ShowSpecies.BackgroundImage = data.Species.ToLower() switch {
                    "gek"    => Properties.Resources.sys_gek,
                    "vykeen" => Properties.Resources.sys_vykeen,
                    "korvax" => Properties.Resources.sys_korvax,
                    _        => Properties.Resources.sys_empty
                };

                // Set System Info (Moon Count etc.)
                string text = $"Planets: {data.PlanetCount}\n" +
                           $"Moons: {data.MoonCount}\n" +
                           $"Conflict: {data.Conflict}\n" +
                           $"Econmy: {data.Economy}\n";
                Tab1SystemInfoLabel.Text = text;
                
                // Set Glyps
                Utils u = new Utils();
                int counter = 0;
                char[] glyps = new char[12];
                string portalAddress = u.GalacticToPortal(data.Coords);
                foreach (char g in portalAddress) {
                    glyps[counter] = g;
                    counter++;
                }
                u.ChangeGlyphs(_portalBar, glyps);
            
                // Update Infos
                ListFiller("t1_planet", $"SELECT DISTINCT PlanetName FROM Planet, NMS_System WHERE Planet.SystemID=NMS_System.SystemID AND SystemName=\"{Tab1SystemList.SelectedItem}\";");
            } catch (Exception ex) {
                // ignored
            }
        }
        
        private void Tab1PlanetList_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                SQLiteDataReader reader = GetDatabase($"SELECT * FROM Planet WHERE PlanetName=\"{Tab1PlanetList.SelectedItem}\";");
            
                if(reader != null)
                    while (reader.Read()) {
                        // Save Data in object
                        PlanetaryData sP = new PlanetaryData {
                            PlanetId = reader.GetInt32(0),
                            PlanetName = reader.GetString(1),
                            PlanetType = reader.GetString(2),
                            PlanetDescription = reader.GetString(3),
                            SystemId = reader.GetInt32(4),
                            OreTypes = reader.GetString(5),
                            PlanetImage = reader.GetString(6)
                        };

                        if (sP.PlanetImage != "about:blank") {
                            Tab1ImageOfPlanet.Visible = true;
                            try {
                                Tab1ImageOfPlanet.ImageLocation = sP.PlanetImage;
                            } catch (Exception exception) {
                                // ignored
                            }
                        } else {
                            Tab1ImageOfPlanet.Visible = false;
                        }

                        Tab1PlanetNameLabel.Text = sP.PlanetName;
                        Tab1DescriptionLabel.Text = sP.PlanetDescription;
                    }
                reader?.Close();
            } catch (Exception ex) {
              //nothing  
            }
        }

        // This is the SearchGalaxyBox
        private void richTextBox1_TextChanged(object sender, EventArgs e) {
            try {
                string search = SearchGalaxyBox.Text;
                if(search != "")
                    ListFiller("t1_galaxy", $"SELECT GalaxyName FROM Galaxy WHERE GalaxyName LIKE '%{SearchGalaxyBox.Text}%'");
                else
                    ListFiller("t1_galaxy", $"SELECT GalaxyName FROM Galaxy");
            }
            catch (Exception exception) {
                // ignored
            }
        }
    }
}

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")] // Not used message annoyed me...
public class PlanetaryData {
    public    int PlanetId          { get; set; }
    public string PlanetImage       { get; set; }
    public string PlanetName        { get; set; }
    public string PlanetDescription { get; set; }
    public string PlanetType        { get; set; }         
    public    int SystemId          { get; set; }           
    public string OreTypes          { get; set; }
}

public class SystemData {
    public    int SystemId          { get; set; }
    public string SystemName        { get; set; }
    public string Coords            { get; set; }
    public    int GalaxyId          { get; set; }
    public    int PlanetCount       { get; set; }
    public    int MoonCount         { get; set; }
    public string Species           { get; set; }         
    public string Economy           { get; set; }           
    public string Conflict          { get; set; }
}

public class GalaxyData {
    public    int GalaxyId          { get; set; }
    public string GalaxyName        { get; set; }
    public string GalaxyType        { get; set; }         
    public string GalaxyColor       { get; set; }
}