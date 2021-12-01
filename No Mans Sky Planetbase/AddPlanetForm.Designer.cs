using System.ComponentModel;

namespace No_Mans_Sky_Planetbase {
    partial class AddPlanetForm {
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
            this.PlanetTypeList = new System.Windows.Forms.ListBox();
            this.CheckBoxKorvax = new System.Windows.Forms.CheckBox();
            this.PushToDatabase = new System.Windows.Forms.Button();
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.PreviewImage = new System.Windows.Forms.WebBrowser();
            this.MainFormTitle = new System.Windows.Forms.Label();
            this.PlanetNameTitle = new System.Windows.Forms.Label();
            this.DescriptionTitle = new System.Windows.Forms.Label();
            this.PlanetTypeTitle = new System.Windows.Forms.Label();
            this.CheckBoxGek = new System.Windows.Forms.CheckBox();
            this.PlanetNameBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.CheckBoxVykeen = new System.Windows.Forms.CheckBox();
            this.SystemNameTitle = new System.Windows.Forms.Label();
            this.SystemList = new System.Windows.Forms.ListBox();
            this.GNOS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlanetTypeList
            // 
            this.PlanetTypeList.Font = new System.Drawing.Font("NMS Futura Pro Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanetTypeList.FormattingEnabled = true;
            this.PlanetTypeList.ItemHeight = 20;
            this.PlanetTypeList.Items.AddRange(new object[] { "Lush", "Barren", "Dead", "Exotic", "Mega Exotic", "Scorched", "Frozen", "Toxic", "Irradiated", "Marsh", "Volcanic" });
            this.PlanetTypeList.Location = new System.Drawing.Point(12, 230);
            this.PlanetTypeList.Name = "PlanetTypeList";
            this.PlanetTypeList.Size = new System.Drawing.Size(244, 144);
            this.PlanetTypeList.TabIndex = 0;
            // 
            // CheckBoxKorvax
            // 
            this.CheckBoxKorvax.Font = new System.Drawing.Font("NMS Futura Pro Book", 12F);
            this.CheckBoxKorvax.Location = new System.Drawing.Point(662, 100);
            this.CheckBoxKorvax.Name = "CheckBoxKorvax";
            this.CheckBoxKorvax.Size = new System.Drawing.Size(92, 24);
            this.CheckBoxKorvax.TabIndex = 3;
            this.CheckBoxKorvax.Text = "Korvax";
            this.CheckBoxKorvax.UseVisualStyleBackColor = true;
            // 
            // PushToDatabase
            // 
            this.PushToDatabase.Font = new System.Drawing.Font("NMS Futura Pro Book", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PushToDatabase.ForeColor = System.Drawing.Color.Crimson;
            this.PushToDatabase.Location = new System.Drawing.Point(12, 589);
            this.PushToDatabase.Name = "PushToDatabase";
            this.PushToDatabase.Size = new System.Drawing.Size(244, 45);
            this.PushToDatabase.TabIndex = 6;
            this.PushToDatabase.Text = "Push";
            this.PushToDatabase.UseVisualStyleBackColor = true;
            this.PushToDatabase.Click += new System.EventHandler(this.PushToDatabase_Click);
            // 
            // UrlBox
            // 
            this.UrlBox.Location = new System.Drawing.Point(500, 158);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(145, 22);
            this.UrlBox.TabIndex = 7;
            this.UrlBox.TextChanged += new System.EventHandler(this.UrlBox_TextChanged);
            // 
            // PreviewImage
            // 
            this.PreviewImage.AllowNavigation = false;
            this.PreviewImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewImage.Location = new System.Drawing.Point(500, 10);
            this.PreviewImage.Margin = new System.Windows.Forms.Padding(0);
            this.PreviewImage.MaximumSize = new System.Drawing.Size(145, 145);
            this.PreviewImage.MinimumSize = new System.Drawing.Size(20, 22);
            this.PreviewImage.Name = "PreviewImage";
            this.PreviewImage.ScrollBarsEnabled = false;
            this.PreviewImage.Size = new System.Drawing.Size(145, 145);
            this.PreviewImage.TabIndex = 8;
            // 
            // MainFormTitle
            // 
            this.MainFormTitle.Font = new System.Drawing.Font("NMS Futura Pro Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormTitle.Location = new System.Drawing.Point(12, 13);
            this.MainFormTitle.Name = "MainFormTitle";
            this.MainFormTitle.Size = new System.Drawing.Size(187, 36);
            this.MainFormTitle.TabIndex = 9;
            this.MainFormTitle.Text = "Adding a planet";
            // 
            // PlanetNameTitle
            // 
            this.PlanetNameTitle.Font = new System.Drawing.Font("NMS Futura Pro Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanetNameTitle.Location = new System.Drawing.Point(12, 48);
            this.PlanetNameTitle.Name = "PlanetNameTitle";
            this.PlanetNameTitle.Size = new System.Drawing.Size(87, 23);
            this.PlanetNameTitle.TabIndex = 10;
            this.PlanetNameTitle.Text = "Planet name:";
            // 
            // DescriptionTitle
            // 
            this.DescriptionTitle.Font = new System.Drawing.Font("NMS Futura Pro Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTitle.Location = new System.Drawing.Point(12, 71);
            this.DescriptionTitle.Name = "DescriptionTitle";
            this.DescriptionTitle.Size = new System.Drawing.Size(87, 23);
            this.DescriptionTitle.TabIndex = 11;
            this.DescriptionTitle.Text = "Description:";
            // 
            // PlanetTypeTitle
            // 
            this.PlanetTypeTitle.Font = new System.Drawing.Font("NMS Futura Pro Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanetTypeTitle.Location = new System.Drawing.Point(12, 205);
            this.PlanetTypeTitle.Name = "PlanetTypeTitle";
            this.PlanetTypeTitle.Size = new System.Drawing.Size(87, 23);
            this.PlanetTypeTitle.TabIndex = 12;
            this.PlanetTypeTitle.Text = "Planettype:";
            // 
            // CheckBoxGek
            // 
            this.CheckBoxGek.Font = new System.Drawing.Font("NMS Futura Pro Book", 12F);
            this.CheckBoxGek.Location = new System.Drawing.Point(662, 131);
            this.CheckBoxGek.Name = "CheckBoxGek";
            this.CheckBoxGek.Size = new System.Drawing.Size(92, 24);
            this.CheckBoxGek.TabIndex = 14;
            this.CheckBoxGek.Text = "Gek";
            this.CheckBoxGek.UseVisualStyleBackColor = true;
            // 
            // PlanetNameBox
            // 
            this.PlanetNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.PlanetNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlanetNameBox.Font = new System.Drawing.Font("NMS Futura Pro Book", 12F);
            this.PlanetNameBox.ForeColor = System.Drawing.Color.White;
            this.PlanetNameBox.Location = new System.Drawing.Point(105, 48);
            this.PlanetNameBox.Name = "PlanetNameBox";
            this.PlanetNameBox.Size = new System.Drawing.Size(151, 21);
            this.PlanetNameBox.TabIndex = 15;
            this.PlanetNameBox.Text = "Earth";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionBox.Font = new System.Drawing.Font("NMS Futura Pro Book", 10F);
            this.DescriptionBox.ForeColor = System.Drawing.Color.White;
            this.DescriptionBox.Location = new System.Drawing.Point(105, 71);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(389, 127);
            this.DescriptionBox.TabIndex = 16;
            this.DescriptionBox.Text = "Earth is the third planet from the Sun and the only astronomical object known to " + "harbour and support life. About 29.2% of Earth\'s surface is land consisting of c" + "ontinents and islands.";
            // 
            // CheckBoxVykeen
            // 
            this.CheckBoxVykeen.Font = new System.Drawing.Font("NMS Futura Pro Book", 12F);
            this.CheckBoxVykeen.Location = new System.Drawing.Point(662, 161);
            this.CheckBoxVykeen.Name = "CheckBoxVykeen";
            this.CheckBoxVykeen.Size = new System.Drawing.Size(92, 24);
            this.CheckBoxVykeen.TabIndex = 17;
            this.CheckBoxVykeen.Text = "Vykeen";
            this.CheckBoxVykeen.UseVisualStyleBackColor = true;
            // 
            // SystemNameTitle
            // 
            this.SystemNameTitle.Font = new System.Drawing.Font("NMS Futura Pro Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemNameTitle.Location = new System.Drawing.Point(12, 386);
            this.SystemNameTitle.Name = "SystemNameTitle";
            this.SystemNameTitle.Size = new System.Drawing.Size(112, 23);
            this.SystemNameTitle.TabIndex = 19;
            this.SystemNameTitle.Text = "SystemName:";
            // 
            // SystemList
            // 
            this.SystemList.Font = new System.Drawing.Font("NMS Futura Pro Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemList.FormattingEnabled = true;
            this.SystemList.ItemHeight = 20;
            this.SystemList.Location = new System.Drawing.Point(12, 412);
            this.SystemList.Name = "SystemList";
            this.SystemList.Size = new System.Drawing.Size(244, 164);
            this.SystemList.TabIndex = 18;
            this.SystemList.SelectedIndexChanged += new System.EventHandler(this.SystemList_SelectedIndexChanged);
            // 
            // GNOS
            // 
            this.GNOS.Font = new System.Drawing.Font("NMS Futura Pro Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GNOS.Location = new System.Drawing.Point(265, 205);
            this.GNOS.Name = "GNOS";
            this.GNOS.Size = new System.Drawing.Size(229, 23);
            this.GNOS.TabIndex = 21;
            this.GNOS.Text = "Galaxy: None system selected";
            // 
            // AddPlanetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(982, 646);
            this.Controls.Add(this.GNOS);
            this.Controls.Add(this.SystemNameTitle);
            this.Controls.Add(this.SystemList);
            this.Controls.Add(this.CheckBoxVykeen);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.PlanetNameBox);
            this.Controls.Add(this.CheckBoxGek);
            this.Controls.Add(this.PlanetTypeTitle);
            this.Controls.Add(this.DescriptionTitle);
            this.Controls.Add(this.PlanetNameTitle);
            this.Controls.Add(this.MainFormTitle);
            this.Controls.Add(this.PreviewImage);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.PushToDatabase);
            this.Controls.Add(this.CheckBoxKorvax);
            this.Controls.Add(this.PlanetTypeList);
            this.Font = new System.Drawing.Font("NMS Futura Pro Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddPlanetForm";
            this.Text = "Add Planet to Database";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label GNOS;

        private System.Windows.Forms.TextBox UrlBox;

        private System.Windows.Forms.ListBox SystemList;

        private System.Windows.Forms.Label SystemNameTitle;

        private System.Windows.Forms.CheckBox CheckBoxVykeen;

        private System.Windows.Forms.RichTextBox DescriptionBox;
        
        private System.Windows.Forms.TextBox PlanetNameBox;

        private System.Windows.Forms.CheckBox CheckBoxKorvax;
        private System.Windows.Forms.CheckBox CheckBoxGek;

        private System.Windows.Forms.Button PushToDatabase;

        private System.Windows.Forms.Label PlanetNameTitle;
        private System.Windows.Forms.Label DescriptionTitle;
        private System.Windows.Forms.ListBox PlanetTypeList;
        private System.Windows.Forms.Label PlanetTypeTitle;
        
        private System.Windows.Forms.WebBrowser PreviewImage;
        private System.Windows.Forms.Label MainFormTitle;
        #endregion
    }
}