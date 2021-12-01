using System.ComponentModel;

namespace No_Mans_Sky_Planetbase {
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
            this.CmdBox = new System.Windows.Forms.TextBox();
            this.Button_AddPlanet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdBox
            // 
            this.CmdBox.BackColor = System.Drawing.Color.Black;
            this.CmdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CmdBox.Font = new System.Drawing.Font("Consolas", 12F);
            this.CmdBox.ForeColor = System.Drawing.Color.Red;
            this.CmdBox.Location = new System.Drawing.Point(14, 14);
            this.CmdBox.Name = "CmdBox";
            this.CmdBox.Size = new System.Drawing.Size(906, 19);
            this.CmdBox.TabIndex = 2;
            this.CmdBox.Text = "Try /addplanet Commander!";
            this.CmdBox.TextChanged += new System.EventHandler(this.CmdBox_TextChanged);
            // 
            // Button_AddPlanet
            // 
            this.Button_AddPlanet.ForeColor = System.Drawing.Color.Black;
            this.Button_AddPlanet.Location = new System.Drawing.Point(12, 39);
            this.Button_AddPlanet.Name = "Button_AddPlanet";
            this.Button_AddPlanet.Size = new System.Drawing.Size(166, 32);
            this.Button_AddPlanet.TabIndex = 3;
            this.Button_AddPlanet.Text = "Add Planet";
            this.Button_AddPlanet.UseVisualStyleBackColor = true;
            this.Button_AddPlanet.Click += new System.EventHandler(this.Button_AddPlanet_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 543);
            this.Controls.Add(this.Button_AddPlanet);
            this.Controls.Add(this.CmdBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "No Man\'s Pedia";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button Button_AddPlanet;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox CmdBox;

        #endregion
    }
}