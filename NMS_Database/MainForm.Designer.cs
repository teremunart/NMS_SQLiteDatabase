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
            this.Tab1LabelSystem = new System.Windows.Forms.Label();
            this.Tab1SystemList = new System.Windows.Forms.ListBox();
            this.Tab1LabelGalaxy = new System.Windows.Forms.Label();
            this.Tab1GalaxyList = new System.Windows.Forms.ListBox();
            this.SystemInspector = new System.Windows.Forms.Panel();
            this.Tab1DescriptionLabel = new System.Windows.Forms.Label();
            this.Tab1PlanetNameLabel = new System.Windows.Forms.Label();
            this.Tab1SystemInfoLabel = new System.Windows.Forms.Label();
            this.Tab1ShowSpecies = new System.Windows.Forms.PictureBox();
            this.Tab1PlanetList = new System.Windows.Forms.ListBox();
            this.Tab1SelectedSystemLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabpanel.SuspendLayout();
            this.inspectsystem.SuspendLayout();
            this.SystemInspector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab1ShowSpecies)).BeginInit();
            this.SuspendLayout();
            // 
            // tabpanel
            // 
            this.tabpanel.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabpanel.Controls.Add(this.inspectsystem);
            this.tabpanel.Controls.Add(this.tabPage2);
            this.tabpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpanel.HotTrack = true;
            this.tabpanel.Location = new System.Drawing.Point(0, 0);
            this.tabpanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabpanel.Name = "tabpanel";
            this.tabpanel.Padding = new System.Drawing.Point(0, 0);
            this.tabpanel.SelectedIndex = 0;
            this.tabpanel.Size = new System.Drawing.Size(835, 577);
            this.tabpanel.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabpanel.TabIndex = 0;
            // 
            // inspectsystem
            // 
            this.inspectsystem.BackColor = System.Drawing.Color.Black;
            this.inspectsystem.Controls.Add(this.Tab1LabelSystem);
            this.inspectsystem.Controls.Add(this.Tab1SystemList);
            this.inspectsystem.Controls.Add(this.Tab1LabelGalaxy);
            this.inspectsystem.Controls.Add(this.Tab1GalaxyList);
            this.inspectsystem.Controls.Add(this.SystemInspector);
            this.inspectsystem.Location = new System.Drawing.Point(4, 29);
            this.inspectsystem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inspectsystem.Name = "inspectsystem";
            this.inspectsystem.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inspectsystem.Size = new System.Drawing.Size(827, 544);
            this.inspectsystem.TabIndex = 0;
            this.inspectsystem.Text = "Inspect System";
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
            this.Tab1GalaxyList.Location = new System.Drawing.Point(6, 50);
            this.Tab1GalaxyList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Tab1GalaxyList.Name = "Tab1GalaxyList";
            this.Tab1GalaxyList.Size = new System.Drawing.Size(142, 136);
            this.Tab1GalaxyList.TabIndex = 1;
            this.Tab1GalaxyList.SelectedIndexChanged += new System.EventHandler(this.Tab1GalaxyList_SelectedIndexChanged);
            // 
            // SystemInspector
            // 
            this.SystemInspector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SystemInspector.Controls.Add(this.Tab1DescriptionLabel);
            this.SystemInspector.Controls.Add(this.Tab1PlanetNameLabel);
            this.SystemInspector.Controls.Add(this.Tab1SystemInfoLabel);
            this.SystemInspector.Controls.Add(this.Tab1ShowSpecies);
            this.SystemInspector.Controls.Add(this.Tab1PlanetList);
            this.SystemInspector.Controls.Add(this.Tab1SelectedSystemLabel);
            this.SystemInspector.Location = new System.Drawing.Point(174, 6);
            this.SystemInspector.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SystemInspector.Name = "SystemInspector";
            this.SystemInspector.Size = new System.Drawing.Size(646, 530);
            this.SystemInspector.TabIndex = 0;
            // 
            // Tab1DescriptionLabel
            // 
            this.Tab1DescriptionLabel.Location = new System.Drawing.Point(199, 217);
            this.Tab1DescriptionLabel.Name = "Tab1DescriptionLabel";
            this.Tab1DescriptionLabel.Size = new System.Drawing.Size(227, 112);
            this.Tab1DescriptionLabel.TabIndex = 6;
            // 
            // Tab1PlanetNameLabel
            // 
            this.Tab1PlanetNameLabel.Font = new System.Drawing.Font("NMS Futura Pro Book", 16F);
            this.Tab1PlanetNameLabel.Location = new System.Drawing.Point(199, 179);
            this.Tab1PlanetNameLabel.Name = "Tab1PlanetNameLabel";
            this.Tab1PlanetNameLabel.Size = new System.Drawing.Size(227, 32);
            this.Tab1PlanetNameLabel.TabIndex = 5;
            // 
            // Tab1SystemInfoLabel
            // 
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
            this.Tab1SelectedSystemLabel.Size = new System.Drawing.Size(299, 30);
            this.Tab1SelectedSystemLabel.TabIndex = 0;
            this.Tab1SelectedSystemLabel.Text = "SELECT A SYSTEM";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Size = new System.Drawing.Size(827, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 577);
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
            ((System.ComponentModel.ISupportInitialize)(this.Tab1ShowSpecies)).EndInit();
            this.ResumeLayout(false);
        }

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