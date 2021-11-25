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
            this.Loading = new System.Windows.Forms.ProgressBar();
            this.CmdBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Loading
            // 
            this.Loading.ForeColor = System.Drawing.Color.Red;
            this.Loading.Location = new System.Drawing.Point(0, 509);
            this.Loading.MarqueeAnimationSpeed = 200;
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(937, 12);
            this.Loading.Step = 1;
            this.Loading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Loading.TabIndex = 1;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 543);
            this.Controls.Add(this.CmdBox);
            this.Controls.Add(this.Loading);
            this.Font = new System.Drawing.Font("NMS GeoSans", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "No Man\'s Pedia";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox CmdBox;
        private System.Windows.Forms.ProgressBar Loading;

        #endregion
    }
}