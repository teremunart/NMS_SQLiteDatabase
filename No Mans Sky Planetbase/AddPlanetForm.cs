using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace No_Mans_Sky_Planetbase {
    public partial class AddPlanetForm : Form {
        
        static string relative_filename = @"..\..\database\database.db";
        string db_path = Path.GetFullPath(relative_filename);
        
        private string _planetname;
        private string _description;
        private string _planettype;
        private string _species;
        private string _galaxy;
        private string _url;

        public AddPlanetForm() {
            InitializeComponent();
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e) {
            string url = textBox3.Text;
            
            if(String.IsNullOrEmpty(url)) return;
            if(url.Equals("about:blank")) return;
            try {
                PreviewImage.Navigate(new Uri(url));
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
            _url = textBox3.Text;
            SaveInDatabase();
        }

        private void SaveInDatabase() {
            if (!File.Exists(db_path)) {
                return;
            }

            string connectionstring = @"Data Source=" + db_path + "; Version = 3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionstring)) {
                connection.Open();

                string sql = @"INSERT INTO Planets";
            }
        }
    }
}