using System.ComponentModel;

namespace No_Mans_Sky_Planetbase {
    partial class RemovePlanetForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.PlanetList = new System.Windows.Forms.ListBox();
            this.SearchByName = new System.Windows.Forms.TextBox();
            this.SearchBySpecies = new System.Windows.Forms.ListBox();
            this.PreviewImage = new System.Windows.Forms.WebBrowser();
            this.SearchByTitle = new System.Windows.Forms.Label();
            this.RemoveTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlanetList
            // 
            this.PlanetList.FormattingEnabled = true;
            this.PlanetList.Location = new System.Drawing.Point(21, 54);
            this.PlanetList.Name = "PlanetList";
            this.PlanetList.Size = new System.Drawing.Size(231, 355);
            this.PlanetList.TabIndex = 0;
            this.PlanetList.SelectedIndexChanged += new System.EventHandler(this.PlanetList_SelectedIndexChanged);
            // 
            // SearchByName
            // 
            this.SearchByName.Font = new System.Drawing.Font("NMS Futura Pro Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByName.Location = new System.Drawing.Point(286, 243);
            this.SearchByName.Name = "SearchByName";
            this.SearchByName.Size = new System.Drawing.Size(145, 28);
            this.SearchByName.TabIndex = 4;
            this.SearchByName.TextChanged += new System.EventHandler(this.SearchByName_TextChanged);
            // 
            // SearchBySpecies
            // 
            this.SearchBySpecies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchBySpecies.Font = new System.Drawing.Font("NMS GeoSans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBySpecies.ForeColor = System.Drawing.Color.White;
            this.SearchBySpecies.FormattingEnabled = true;
            this.SearchBySpecies.ItemHeight = 18;
            this.SearchBySpecies.Items.AddRange(new object[] { "Korvax", "Gek", "Vykeen" });
            this.SearchBySpecies.Location = new System.Drawing.Point(286, 277);
            this.SearchBySpecies.Name = "SearchBySpecies";
            this.SearchBySpecies.Size = new System.Drawing.Size(144, 58);
            this.SearchBySpecies.TabIndex = 5;
            this.SearchBySpecies.SelectedIndexChanged += new System.EventHandler(this.SearchBySpecies_SelectedIndexChanged);
            // 
            // PreviewImage
            // 
            this.PreviewImage.Location = new System.Drawing.Point(286, 54);
            this.PreviewImage.MinimumSize = new System.Drawing.Size(20, 20);
            this.PreviewImage.Name = "PreviewImage";
            this.PreviewImage.ScrollBarsEnabled = false;
            this.PreviewImage.Size = new System.Drawing.Size(150, 150);
            this.PreviewImage.TabIndex = 6;
            // 
            // SearchByTitle
            // 
            this.SearchByTitle.Font = new System.Drawing.Font("NMS GeoSans", 16F);
            this.SearchByTitle.ForeColor = System.Drawing.Color.White;
            this.SearchByTitle.Location = new System.Drawing.Point(285, 213);
            this.SearchByTitle.Name = "SearchByTitle";
            this.SearchByTitle.Size = new System.Drawing.Size(150, 30);
            this.SearchByTitle.TabIndex = 7;
            this.SearchByTitle.Text = "Search by:";
            // 
            // RemoveTitle
            // 
            this.RemoveTitle.Font = new System.Drawing.Font("NMS GeoSans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveTitle.ForeColor = System.Drawing.Color.White;
            this.RemoveTitle.Location = new System.Drawing.Point(21, 24);
            this.RemoveTitle.Name = "RemoveTitle";
            this.RemoveTitle.Size = new System.Drawing.Size(171, 27);
            this.RemoveTitle.TabIndex = 8;
            this.RemoveTitle.Text = "Remove Planet";
            // 
            // RemovePlanetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.RemoveTitle);
            this.Controls.Add(this.SearchByTitle);
            this.Controls.Add(this.PreviewImage);
            this.Controls.Add(this.SearchBySpecies);
            this.Controls.Add(this.SearchByName);
            this.Controls.Add(this.PlanetList);
            this.Name = "RemovePlanetForm";
            this.Text = "RemovePlanetForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label SearchByTitle;
        private System.Windows.Forms.Label RemoveTitle;

        private System.Windows.Forms.WebBrowser PreviewImage;

        private System.Windows.Forms.TextBox SearchByName;

        private System.Windows.Forms.ListBox SearchBySpecies;

        private System.Windows.Forms.Label SearchTitle;
        private System.Windows.Forms.WebBrowser webBrowser1;

        private System.Windows.Forms.ListBox PlanetList;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}