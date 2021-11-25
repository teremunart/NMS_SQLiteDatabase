using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace No_Mans_Sky_Planetbase {
    public partial class RemovePlanetForm : Form {
        public RemovePlanetForm() {
            Fill();
            InitializeComponent();
        }

        
        public void Fill() {

            List<string> systemnames = new List<string>();

            int listIndex = 0;
            
            using (SQLiteConnection connection = new SQLiteConnection(new Utils().GetConnectionString())) {
                connection.Open();
                
                string sql = @"select Planetname from Planet";
                
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection)) {
                    SQLiteDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows) {
                        while (rdr.Read()) {
                            systemnames.Add(listIndex + ". " + rdr.GetString(0) + " [" + rdr.GetString(1) + "]");
                            listIndex++;
                        }
                    } else {
                        PlanetList.Items.Add("No planets found...");
                    }
                    rdr.Close();
                }
            }
        }

        private void SearchByName_TextChanged(object sender, EventArgs e) {
            throw new System.NotImplementedException();
        }

        private void SearchBySpecies_SelectedIndexChanged(object sender, EventArgs e) {
            throw new System.NotImplementedException();
        }

        private void PlanetList_SelectedIndexChanged(object sender, EventArgs e) {
            throw new System.NotImplementedException();
        }
    }
}