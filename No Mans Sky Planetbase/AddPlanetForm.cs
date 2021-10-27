using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace No_Mans_Sky_Planetbase {
    
    //Database Format: Planetname VARCHAR, Description VARCHAR, Galaxy VARCHAR, Planetype VARCHAR, Species VARCHAR
    
    public partial class AddPlanetForm : Form {
        static string relative_filename = @"..\..\database\database.db";
        string db_path = Path.GetFullPath(relative_filename);
        
        private string _planetname;
        private string _description;
        private string _planettype;
        private string _species;
        private string _galaxy;
        public string Url = "about:blank";

        public AddPlanetForm() {
            InitializeComponent();
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
            _planetname = PlanetNameBox.Text;
            _description = DescriptionBox.Text;
            _galaxy = GalaxyList.Text;
            _planettype = PlanetTypeList.Text;
            if (CheckBoxGek.Checked) _species = "Gek";
            if (CheckBoxKorvax.Checked) _species = "Korvax";
            if (CheckBoxVykeen.Checked) _species = "Vykeen";
            //_url = textBox3.Text;
            SaveInDatabase();
        }

        private void SaveInDatabase() {
            if (!File.Exists(db_path)) {
                return;
            }

            string connectionstring = @"Data Source="+db_path+"; Version = 3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionstring)) {
                connection.Open();

                string sql = @"INSERT INTO Planets (Planetname, Description, Galaxy, Planetype , Species) VALUES (@Planetname, @Description, @Galaxy, @Planettype, @Species)";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection)) {
                    command.Parameters.AddWithValue("Planetname", _planetname);
                    command.Parameters.AddWithValue("Description", _description);
                    command.Parameters.AddWithValue("Galaxy", _galaxy);
                    command.Parameters.AddWithValue("Planettype", _planettype);
                    command.Parameters.AddWithValue("Species", _species);
                    //command.Parameters.AddWithValue("ImgUrl", _url);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}