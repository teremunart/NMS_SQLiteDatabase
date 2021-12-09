#pragma warning disable 649

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace No_Mans_Sky_Planetbase {

    //TODO: If this class works, I should move it to an own class, to keep stuff tidy.
    public class PlanetDataEntry { 
        public string   KPlanetName     { get; set; }
        public string   KPlanetDesc     { get; set; }
        public string   KPlanetType     { get; set; }
        public int      KSystemId       { get; set; }
        public string   KOresType       { get; set; }
        public int      KIsMoon         { get; set; }
        public string   KPlanetImageUrl { get; set; }
    }
    
    public partial class AddPlanetForm : Form {
        private static PlanetDataEntry[] Entries;                                                                                
        private int Queue = 0;
        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        string _dbPath = Path.GetFullPath(@"..\..\database\database.db");
        private string Url = "about:blank";
        
        
        
        
        
        
        
        
        
        
        
        //AddPlanetForm Constructor
        public AddPlanetForm() {
            InitializeComponent();
            FillSystemList(); //Fills the list with Items
        }
        
        //  F U N C T I O N S
        private void FillSystemList() {
            SQLiteDataReader reader = GetDatabase(
                @"SELECT SystemID, SystemName, NMS_System.GalaxyID, Galaxy.GalaxyName FROM NMS_System, Galaxy WHERE Galaxy.GalaxyID = NMS_System.GalaxyID;"
                    );

            if(reader != null)
                while (reader.Read()) 
                    SystemList.Items.Add(reader.GetString(1));

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
        
        private void SaveInDatabase() { 
            if (!File.Exists(_dbPath)) {
                return;
            }

            string connectionstring = @"Data Source="+_dbPath+"; Version = 3;";

            using (SQLiteConnection connection = new SQLiteConnection(new Utils().GetConnectionString())) {
                connection.Open();
                string sql = @"INSERT INTO Planet (PlanetName, PlanetType, PlanetDesc, SystemID, OresType, PlanetImageurl) VALUES (@PlanetName, @PlanetType, @PlanetDesc, @SystemID, @OresType, @PlanetImageurl)";
                
                using (SQLiteCommand command = new SQLiteCommand(sql, connection)) {
                    /*command.Parameters.AddWithValue("Planetname", _planetname);
                    command.Parameters.AddWithValue("Description", _description);
                    command.Parameters.AddWithValue("Galaxy", _galaxy);
                    command.Parameters.AddWithValue("Planettype", _planettype);
                    command.Parameters.AddWithValue("Species", _species);
                    //command.Parameters.AddWithValue("ImgUrl", _url);*/
                    command.ExecuteNonQuery();
                } 
            }
        } //TODO: Adapt to new Database

        private bool IsFieldMissing() {
            return PlanetNameBox.Text == "" && DescriptionBox.Text == "";
        }
        
        //
        //  E V E N T S
        //
        private void UrlBox_TextChanged(object sender, EventArgs e) {
            Url = UrlBox.Text;
            
            if(String.IsNullOrEmpty(Url)) return;
            if(Url.Equals("about:blank")) return;
            try {
                PreviewImage.DocumentText =
                    "<html style=\"border:none\">" +
                        "<body scroll=\"no\" style=\"padding:0px;margin:0px;\">" +
                            "<img src=\"" + Url + "\" alt=\"\" width=\"145\" heights=\"145\">" +
                        "</body>" +
                    "</html>";
            } catch (UriFormatException) {
            }
        }

        private void PushToDatabase_Click(object sender, EventArgs e) {
            SaveInDatabase();
        }

        private void SystemList_SelectedIndexChanged(object sender, EventArgs e) {
            SQLiteDataReader reader = GetDatabase(
                @"SELECT SystemName,Galaxy.GalaxyName FROM NMS_System, Galaxy WHERE NMS_System.GalaxyID=Galaxy.GalaxyID;"
            );
            
            if (reader != null) {
                while (reader.Read()) {
                    if(SystemList.SelectedItem.ToString() == reader.GetString(0))
                        GNOS.Text = @"Galaxy: " + reader.GetString(1);
                }
            } else {
                GNOS.Text = @"Galaxy: Empty";
            }
        }

        private void QueuePlanet_Click(object sender, EventArgs e) {
            
            if (IsFieldMissing()) return;

            Entries[Queue] = new PlanetDataEntry {
                KPlanetName = PlanetNameBox.Text,
                KPlanetDesc = DescriptionBox.Text,
                KPlanetType = PlanetTypeList.SelectedItem.ToString(),
                KSystemId = SystemList.SelectedIndex,
                KPlanetImageUrl = UrlBox.Text
                //Entries[Queue].IsMoon;    = //TODO: Add CheckBox in form and add it to the database.
                //Entries[Queue].KOresType; = //TODO: Add field in form.
            };

            Queue++;
        }
    }
}