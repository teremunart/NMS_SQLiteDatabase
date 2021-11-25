using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace No_Mans_Sky_Planetbase {

    public partial class AddPlanetForm : Form {
        public int?[] SystemId;
        public int IndexItem;

        static string relative_filename = @"..\..\database\database.db";
        readonly string _dbPath = Path.GetFullPath(relative_filename);
        
        public string Url = "about:blank";

        
        /*
         * AddPlanetForm Constructor
         */ 
        public AddPlanetForm() {
            InitializeComponent();

            IndexItem = 0;
            using (SQLiteConnection connection = new SQLiteConnection(new Utils().GetConnectionString())) {
                connection.Open();
                string sql = @"SELECT SystemID, SystemName, NMS_System.GalaxyID, Galaxy.GalaxyName FROM NMS_System, Galaxy WHERE Galaxy.GalaxyID = NMS_System.GalaxyID;";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection)) {
                    SQLiteDataReader rdr = command.ExecuteReader();
                    if (rdr.HasRows) {
                        while (rdr.Read()) {
                            LB_SystemList.Items.Add("[" + rdr.GetInt32(0) + "] " + rdr.GetString(1) + " --> " + rdr.GetString(3));
                        }
                    } else {
                        LB_SystemList.Items.Add("No systems found.");
                    }
                    rdr.Close();
                }
            }
        }
        
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
            /*_description = DescriptionBox.Text;
            _galaxy = GalaxyList.Text;
            _planettype = PlanetTypeList.Text;
            if (CheckBoxGek.Checked) _species = "Gek";
            if (CheckBoxKorvax.Checked) _species = "Korvax";
            if (CheckBoxVykeen.Checked) _species = "Vykeen";
            //_url = textBox3.Text;
            */SaveInDatabase();
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
        }

        private void LB_SystemName_SelectedIndexChanged(object sender, EventArgs e) {
            throw new System.NotImplementedException();
        }
    }
}