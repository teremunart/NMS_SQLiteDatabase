using System.ComponentModel;

namespace NMS_Database {
    partial class MainForm {
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
            this.tabpanel = new System.Windows.Forms.TabControl();
            this.inspectsystem = new System.Windows.Forms.TabPage();
            this.SearchGalaxyBox = new System.Windows.Forms.RichTextBox();
            this.Tab1LabelSystem = new System.Windows.Forms.Label();
            this.Tab1SystemList = new System.Windows.Forms.ListBox();
            this.Tab1LabelGalaxy = new System.Windows.Forms.Label();
            this.Tab1GalaxyList = new System.Windows.Forms.ListBox();
            this.SystemInspector = new System.Windows.Forms.Panel();
            this.portal_1 = new System.Windows.Forms.PictureBox();
            this.portal_2 = new System.Windows.Forms.PictureBox();
            this.portal_3 = new System.Windows.Forms.PictureBox();
            this.portal_4 = new System.Windows.Forms.PictureBox();
            this.portal_5 = new System.Windows.Forms.PictureBox();
            this.portal_6 = new System.Windows.Forms.PictureBox();
            this.portal_7 = new System.Windows.Forms.PictureBox();
            this.portal_8 = new System.Windows.Forms.PictureBox();
            this.portal_9 = new System.Windows.Forms.PictureBox();
            this.portal_10 = new System.Windows.Forms.PictureBox();
            this.portal_11 = new System.Windows.Forms.PictureBox();
            this.portal_12 = new System.Windows.Forms.PictureBox();
            this.Tab1ImageOfPlanet = new System.Windows.Forms.PictureBox();
            this.Tab1DescriptionLabel = new System.Windows.Forms.Label();
            this.Tab1PlanetNameLabel = new System.Windows.Forms.Label();
            this.Tab1SystemInfoLabel = new System.Windows.Forms.Label();
            this.Tab1ShowSpecies = new System.Windows.Forms.PictureBox();
            this.Tab1PlanetList = new System.Windows.Forms.ListBox();
            this.Tab1SelectedSystemLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabpanel.SuspendLayout();
            this.inspectsystem.SuspendLayout();
            this.SystemInspector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portal_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab1ImageOfPlanet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab1ShowSpecies)).BeginInit();
            this.SuspendLayout();
            // 
            // tabpanel
            // 
            this.tabpanel.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabpanel.Controls.Add(this.inspectsystem);
            this.tabpanel.Controls.Add(this.tabPage2);
            this.tabpanel.Controls.Add(this.tabPage1);
            this.tabpanel.Controls.Add(this.tabPage3);
            this.tabpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpanel.HotTrack = true;
            this.tabpanel.Location = new System.Drawing.Point(0, 0);
            this.tabpanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabpanel.Name = "tabpanel";
            this.tabpanel.Padding = new System.Drawing.Point(0, 0);
            this.tabpanel.SelectedIndex = 0;
            this.tabpanel.Size = new System.Drawing.Size(835, 505);
            this.tabpanel.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabpanel.TabIndex = 0;
            // 
            // inspectsystem
            // 
            this.inspectsystem.BackColor = System.Drawing.Color.Black;
            this.inspectsystem.BackgroundImage = global::NMS_Database.Properties.Resources.nms_bg_1;
            this.inspectsystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inspectsystem.Controls.Add(this.SearchGalaxyBox);
            this.inspectsystem.Controls.Add(this.Tab1LabelSystem);
            this.inspectsystem.Controls.Add(this.Tab1SystemList);
            this.inspectsystem.Controls.Add(this.Tab1LabelGalaxy);
            this.inspectsystem.Controls.Add(this.Tab1GalaxyList);
            this.inspectsystem.Controls.Add(this.SystemInspector);
            this.inspectsystem.Location = new System.Drawing.Point(4, 29);
            this.inspectsystem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inspectsystem.Name = "inspectsystem";
            this.inspectsystem.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inspectsystem.Size = new System.Drawing.Size(827, 472);
            this.inspectsystem.TabIndex = 0;
            this.inspectsystem.Text = "Inspect System";
            // 
            // SearchGalaxyBox
            // 
            this.SearchGalaxyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchGalaxyBox.Location = new System.Drawing.Point(6, 45);
            this.SearchGalaxyBox.MaxLength = 256;
            this.SearchGalaxyBox.Multiline = false;
            this.SearchGalaxyBox.Name = "SearchGalaxyBox";
            this.SearchGalaxyBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.SearchGalaxyBox.Size = new System.Drawing.Size(142, 22);
            this.SearchGalaxyBox.TabIndex = 6;
            this.SearchGalaxyBox.Text = "";
            this.SearchGalaxyBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Tab1LabelSystem
            // 
            this.Tab1LabelSystem.BackColor = System.Drawing.Color.Transparent;
            this.Tab1LabelSystem.Font = new System.Drawing.Font("NMS Futura Pro Book", 16F);
            this.Tab1LabelSystem.Location = new System.Drawing.Point(6, 223);
            this.Tab1LabelSystem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tab1LabelSystem.Name = "Tab1LabelSystem";
            this.Tab1LabelSystem.Size = new System.Drawing.Size(145, 30);
            this.Tab1LabelSystem.TabIndex = 5;
            this.Tab1LabelSystem.Text = "SYSTEM:";
            // 
            // Tab1SystemList
            // 
            this.Tab1SystemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tab1SystemList.Font = new System.Drawing.Font("NMS Futura Pro Book", 10F);
            this.Tab1SystemList.FormattingEnabled = true;
            this.Tab1SystemList.ItemHeight = 17;
            this.Tab1SystemList.Location = new System.Drawing.Point(6, 256);
            this.Tab1SystemList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Tab1SystemList.Name = "Tab1SystemList";
            this.Tab1SystemList.Size = new System.Drawing.Size(142, 136);
            this.Tab1SystemList.TabIndex = 0;
            this.Tab1SystemList.SelectedIndexChanged += new System.EventHandler(this.Tab1SystemList_SelectedIndexChanged);
            // 
            // Tab1LabelGalaxy
            // 
            this.Tab1LabelGalaxy.BackColor = System.Drawing.Color.Transparent;
            this.Tab1LabelGalaxy.Font = new System.Drawing.Font("NMS Futura Pro Book", 16F);
            this.Tab1LabelGalaxy.Location = new System.Drawing.Point(6, 17);
            this.Tab1LabelGalaxy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tab1LabelGalaxy.Name = "Tab1LabelGalaxy";
            this.Tab1LabelGalaxy.Size = new System.Drawing.Size(145, 30);
            this.Tab1LabelGalaxy.TabIndex = 2;
            this.Tab1LabelGalaxy.Text = "GALAXY:";
            // 
            // Tab1GalaxyList
            // 
            this.Tab1GalaxyList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tab1GalaxyList.Font = new System.Drawing.Font("NMS Futura Pro Book", 10F);
            this.Tab1GalaxyList.FormattingEnabled = true;
            this.Tab1GalaxyList.ItemHeight = 17;
            this.Tab1GalaxyList.Location = new System.Drawing.Point(6, 67);
            this.Tab1GalaxyList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Tab1GalaxyList.Name = "Tab1GalaxyList";
            this.Tab1GalaxyList.Size = new System.Drawing.Size(142, 136);
            this.Tab1GalaxyList.TabIndex = 1;
            this.Tab1GalaxyList.SelectedIndexChanged += new System.EventHandler(this.Tab1GalaxyList_SelectedIndexChanged);
            // 
            // SystemInspector
            // 
            this.SystemInspector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SystemInspector.Controls.Add(this.portal_1);
            this.SystemInspector.Controls.Add(this.portal_2);
            this.SystemInspector.Controls.Add(this.portal_3);
            this.SystemInspector.Controls.Add(this.portal_4);
            this.SystemInspector.Controls.Add(this.portal_5);
            this.SystemInspector.Controls.Add(this.portal_6);
            this.SystemInspector.Controls.Add(this.portal_7);
            this.SystemInspector.Controls.Add(this.portal_8);
            this.SystemInspector.Controls.Add(this.portal_9);
            this.SystemInspector.Controls.Add(this.portal_10);
            this.SystemInspector.Controls.Add(this.portal_11);
            this.SystemInspector.Controls.Add(this.portal_12);
            this.SystemInspector.Controls.Add(this.Tab1ImageOfPlanet);
            this.SystemInspector.Controls.Add(this.Tab1DescriptionLabel);
            this.SystemInspector.Controls.Add(this.Tab1PlanetNameLabel);
            this.SystemInspector.Controls.Add(this.Tab1SystemInfoLabel);
            this.SystemInspector.Controls.Add(this.Tab1ShowSpecies);
            this.SystemInspector.Controls.Add(this.Tab1PlanetList);
            this.SystemInspector.Controls.Add(this.Tab1SelectedSystemLabel);
            this.SystemInspector.Location = new System.Drawing.Point(174, 6);
            this.SystemInspector.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SystemInspector.Name = "SystemInspector";
            this.SystemInspector.Size = new System.Drawing.Size(646, 460);
            this.SystemInspector.TabIndex = 0;
            // 
            // portal_1
            // 
            this.portal_1.Location = new System.Drawing.Point(5, 432);
            this.portal_1.Name = "portal_1";
            this.portal_1.Size = new System.Drawing.Size(25, 25);
            this.portal_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portal_1.TabIndex = 19;
            this.portal_1.TabStop = false;
            // 
            // portal_2
            // 
            this.portal_2.Location = new System.Drawing.Point(30, 432);
            this.portal_2.Name = "portal_2";
            this.portal_2.Size = new System.Drawing.Size(25, 25);
            this.portal_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portal_2.TabIndex = 18;
            this.portal_2.TabStop = false;
            // 
            // portal_3
            // 
            this.portal_3.Location = new System.Drawing.Point(55, 432);
            this.portal_3.Name = "portal_3";
            this.portal_3.Size = new System.Drawing.Size(25, 25);
            this.portal_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portal_3.TabIndex = 17;
            this.portal_3.TabStop = false;
            // 
            // portal_4
            // 
            this.portal_4.Location = new System.Drawing.Point(80, 432);
            this.portal_4.Name = "portal_4";
            this.portal_4.Size = new System.Drawing.Size(25, 25);
            this.portal_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portal_4.TabIndex = 16;
            this.portal_4.TabStop = false;
            // 
            // portal_5
            // 
            this.portal_5.Location = new System.Drawing.Point(105, 432);
            this.portal_5.Name = "portal_5";
            this.portal_5.Size = new System.Drawing.Size(25, 25);
            this.portal_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portal_5.TabIndex = 15;
            this.portal_5.TabStop = false;
            // 
            // portal_6
            // 
            this.portal_6.Location = new System.Drawing.Point(130, 432);
            this.portal_6.Name = "portal_6";
            this.portal_6.Size = new System.Drawing.Size(25, 25);
            this.portal_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portal_6.TabIndex = 14;
            this.portal_6.TabStop = false;
            // 
            // portal_7
            // 
            this.portal_7.Location = new System.Drawing.Point(155, 432);
            this.portal_7.Name = "portal_7";
            this.portal_7.Size = new System.Drawing.Size(25, 25);
            this.portal_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portal_7.TabIndex = 13;
            this.portal_7.TabStop = false;
            // 
            // portal_8
            // 
            this.portal_8.Location = new System.Drawing.Point(180, 432);
            this.portal_8.Name = "portal_8";
            this.portal_8.Size = new System.Drawing.Size(25, 25);
            this.portal_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portal_8.TabIndex = 12;
            this.portal_8.TabStop = false;
            // 
            // portal_9
            // 
            this.portal_9.Location = new System.Drawing.Point(205, 432);
            this.portal_9.Name = "portal_9";
            this.portal_9.Size = new System.Drawing.Size(25, 25);
            this.portal_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portal_9.TabIndex = 11;
            this.portal_9.TabStop = false;
            // 
            // portal_10
            // 
            this.portal_10.Location = new System.Drawing.Point(230, 432);
            this.portal_10.Name = "portal_10";
            this.portal_10.Size = new System.Drawing.Size(25, 25);
            this.portal_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portal_10.TabIndex = 10;
            this.portal_10.TabStop = false;
            // 
            // portal_11
            // 
            this.portal_11.Location = new System.Drawing.Point(255, 432);
            this.portal_11.Name = "portal_11";
            this.portal_11.Size = new System.Drawing.Size(25, 25);
            this.portal_11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portal_11.TabIndex = 9;
            this.portal_11.TabStop = false;
            // 
            // portal_12
            // 
            this.portal_12.Location = new System.Drawing.Point(280, 432);
            this.portal_12.Name = "portal_12";
            this.portal_12.Size = new System.Drawing.Size(25, 25);
            this.portal_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portal_12.TabIndex = 8;
            this.portal_12.TabStop = false;
            // 
            // Tab1ImageOfPlanet
            // 
            this.Tab1ImageOfPlanet.BackColor = System.Drawing.Color.Transparent;
            this.Tab1ImageOfPlanet.Location = new System.Drawing.Point(199, 44);
            this.Tab1ImageOfPlanet.Name = "Tab1ImageOfPlanet";
            this.Tab1ImageOfPlanet.Size = new System.Drawing.Size(198, 114);
            this.Tab1ImageOfPlanet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tab1ImageOfPlanet.TabIndex = 7;
            this.Tab1ImageOfPlanet.TabStop = false;
            // 
            // Tab1DescriptionLabel
            // 
            this.Tab1DescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.Tab1DescriptionLabel.Location = new System.Drawing.Point(199, 217);
            this.Tab1DescriptionLabel.Name = "Tab1DescriptionLabel";
            this.Tab1DescriptionLabel.Size = new System.Drawing.Size(227, 112);
            this.Tab1DescriptionLabel.TabIndex = 6;
            // 
            // Tab1PlanetNameLabel
            // 
            this.Tab1PlanetNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.Tab1PlanetNameLabel.Font = new System.Drawing.Font("NMS Futura Pro Book", 16F);
            this.Tab1PlanetNameLabel.Location = new System.Drawing.Point(199, 179);
            this.Tab1PlanetNameLabel.Name = "Tab1PlanetNameLabel";
            this.Tab1PlanetNameLabel.Size = new System.Drawing.Size(227, 32);
            this.Tab1PlanetNameLabel.TabIndex = 5;
            // 
            // Tab1SystemInfoLabel
            // 
            this.Tab1SystemInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.Tab1SystemInfoLabel.Location = new System.Drawing.Point(12, 234);
            this.Tab1SystemInfoLabel.Name = "Tab1SystemInfoLabel";
            this.Tab1SystemInfoLabel.Size = new System.Drawing.Size(163, 118);
            this.Tab1SystemInfoLabel.TabIndex = 4;
            this.Tab1SystemInfoLabel.Text = "Planets: 0\r\nMoons: 0\r\nConflict: None\r\nEconmy: None";
            // 
            // Tab1ShowSpecies
            // 
            this.Tab1ShowSpecies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab1ShowSpecies.BackColor = System.Drawing.Color.Transparent;
            this.Tab1ShowSpecies.BackgroundImage = global::NMS_Database.Properties.Resources.sys_empty;
            this.Tab1ShowSpecies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab1ShowSpecies.Location = new System.Drawing.Point(12, 156);
            this.Tab1ShowSpecies.Name = "Tab1ShowSpecies";
            this.Tab1ShowSpecies.Size = new System.Drawing.Size(75, 75);
            this.Tab1ShowSpecies.TabIndex = 2;
            this.Tab1ShowSpecies.TabStop = false;
            // 
            // Tab1PlanetList
            // 
            this.Tab1PlanetList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tab1PlanetList.FormattingEnabled = true;
            this.Tab1PlanetList.ItemHeight = 17;
            this.Tab1PlanetList.Location = new System.Drawing.Point(12, 44);
            this.Tab1PlanetList.Name = "Tab1PlanetList";
            this.Tab1PlanetList.Size = new System.Drawing.Size(141, 102);
            this.Tab1PlanetList.TabIndex = 0;
            this.Tab1PlanetList.SelectedIndexChanged += new System.EventHandler(this.Tab1PlanetList_SelectedIndexChanged);
            // 
            // Tab1SelectedSystemLabel
            // 
            this.Tab1SelectedSystemLabel.BackColor = System.Drawing.Color.Transparent;
            this.Tab1SelectedSystemLabel.Font = new System.Drawing.Font("NMS Futura Pro Book", 16F);
            this.Tab1SelectedSystemLabel.Location = new System.Drawing.Point(12, 11);
            this.Tab1SelectedSystemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tab1SelectedSystemLabel.Name = "Tab1SelectedSystemLabel";
            this.Tab1SelectedSystemLabel.Size = new System.Drawing.Size(163, 30);
            this.Tab1SelectedSystemLabel.TabIndex = 0;
            this.Tab1SelectedSystemLabel.Text = "SELECT A SYSTEM";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::NMS_Database.Properties.Resources.nms_bg_1;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Size = new System.Drawing.Size(827, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Planet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(827, 472);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Add System";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(827, 472);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Testing Stuff";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 505);
            this.Controls.Add(this.tabpanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("NMS Futura Pro Book", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "No Man\'s Pedia";
            this.tabpanel.ResumeLayout(false);
            this.inspectsystem.ResumeLayout(false);
            this.SystemInspector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.portal_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portal_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab1ImageOfPlanet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab1ShowSpecies)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RichTextBox SearchGalaxyBox;

        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;

        // TAB 1
        private System.Windows.Forms.PictureBox portal_1;
        private System.Windows.Forms.PictureBox portal_2;
        private System.Windows.Forms.PictureBox portal_3;
        private System.Windows.Forms.PictureBox portal_4;
        private System.Windows.Forms.PictureBox portal_5;
        private System.Windows.Forms.PictureBox portal_6;
        private System.Windows.Forms.PictureBox portal_7;
        private System.Windows.Forms.PictureBox portal_8;
        private System.Windows.Forms.PictureBox portal_9;
        private System.Windows.Forms.PictureBox portal_10;
        private System.Windows.Forms.PictureBox portal_11;
        private System.Windows.Forms.PictureBox portal_12;
        
        private System.Windows.Forms.PictureBox Tab1ImageOfPlanet;
        
        private System.Windows.Forms.Label Tab1DescriptionLabel;

        private System.Windows.Forms.Label Tab1SystemInfoLabel;
        
        private System.Windows.Forms.PictureBox Tab1ShowSpecies;
        
        private System.Windows.Forms.ListBox Tab1PlanetList;

        private System.Windows.Forms.Label Tab1SelectedSystemLabel;

        private System.Windows.Forms.Label Tab1LabelSystem;

        private System.Windows.Forms.ListBox Tab1SystemList;
        private System.Windows.Forms.ListBox Tab1GalaxyList;

        private System.Windows.Forms.Label Tab1LabelGalaxy;

        private System.Windows.Forms.Label Tab1PlanetNameLabel;

        private System.Windows.Forms.Panel SystemInspector;
        
        private System.Windows.Forms.TabPage inspectsystem;

        private System.Windows.Forms.TabControl tabpanel;

        private System.Windows.Forms.TabPage tabPage2;


        #endregion
    }
}