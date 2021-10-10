namespace No_Mans_Sky_Planetbase {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.add_planet_btn = new System.Windows.Forms.Button();
            this.rem_planet_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_planet_btn
            // 
            this.add_planet_btn.Font = new System.Drawing.Font("NMS Futura Pro Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_planet_btn.Location = new System.Drawing.Point(31, 138);
            this.add_planet_btn.Name = "add_planet_btn";
            this.add_planet_btn.Size = new System.Drawing.Size(177, 42);
            this.add_planet_btn.TabIndex = 0;
            this.add_planet_btn.Text = "Add Planet";
            this.add_planet_btn.UseVisualStyleBackColor = true;
            this.add_planet_btn.Click += new System.EventHandler(this.add_planet_btn_Click);
            // 
            // rem_planet_btn
            // 
            this.rem_planet_btn.Font = new System.Drawing.Font("NMS Futura Pro Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rem_planet_btn.Location = new System.Drawing.Point(31, 186);
            this.rem_planet_btn.Name = "rem_planet_btn";
            this.rem_planet_btn.Size = new System.Drawing.Size(177, 42);
            this.rem_planet_btn.TabIndex = 1;
            this.rem_planet_btn.Text = "Remove Planet";
            this.rem_planet_btn.UseVisualStyleBackColor = true;
            this.rem_planet_btn.Click += new System.EventHandler(this.rem_planet_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("NMS Futura Pro Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(31, 234);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(177, 42);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Search Database";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // title_label
            // 
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("NMS GeoSans", 18F, System.Drawing.FontStyle.Bold);
            this.title_label.Location = new System.Drawing.Point(31, 57);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(306, 64);
            this.title_label.TabIndex = 3;
            this.title_label.Text = "No Man\'s Sky Planetary Database";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.rem_planet_btn);
            this.Controls.Add(this.add_planet_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label title_label;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button rem_planet_btn;
        private System.Windows.Forms.Button search_btn;

        private System.Windows.Forms.Button add_planet_btn;

        #endregion
    }
}