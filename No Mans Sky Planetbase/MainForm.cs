using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace No_Mans_Sky_Planetbase {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void CmdBox_TextChanged(object sender, EventArgs e) {
            Form form;
            switch (CmdBox.Text) {
                case "/addplanet":
                    form = new AddPlanetForm();
                    form.Show(this);
                    break;
                case "/delplanet":
                case "/remplanet":
                    form = new RemovePlanetForm();
                    form.Show(this);
                    break;
                case "/help":
                case "/h":
                    break;
            }
        }
    }
}