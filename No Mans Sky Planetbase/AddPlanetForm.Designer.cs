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
            this.label1 = new System.Windows.Forms.Label();
            this.PlanetNameTitle = new System.Windows.Forms.Label();
            this.DescriptionTitle = new System.Windows.Forms.Label();
            this.PlanetTypeTitle = new System.Windows.Forms.Label();
            this.CheckBoxGek = new System.Windows.Forms.CheckBox();
            this.PlanetNameBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.CheckBoxVykeen = new System.Windows.Forms.CheckBox();
            this.GalaxieTitle = new System.Windows.Forms.Label();
            this.GalaxyList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PlanetTypeList
            // 
            this.PlanetTypeList.Font = new System.Drawing.Font("NMS GeoSans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanetTypeList.FormattingEnabled = true;
            this.PlanetTypeList.ItemHeight = 18;
            this.PlanetTypeList.Items.AddRange(new object[] { "Lush", "Barren", "Dead", "Exotic", "Mega Exotic", "Scorched", "Frozen", "Toxic", "Irradiated", "Marsh", "Volcanic" });
            this.PlanetTypeList.Location = new System.Drawing.Point(12, 214);
            this.PlanetTypeList.Name = "PlanetTypeList";
            this.PlanetTypeList.Size = new System.Drawing.Size(244, 22);
            this.PlanetTypeList.TabIndex = 0;
            // 
            // CheckBoxKorvax
            // 
            this.CheckBoxKorvax.Font = new System.Drawing.Font("NMS GeoSans", 12F);
            this.CheckBoxKorvax.Location = new System.Drawing.Point(279, 214);
            this.CheckBoxKorvax.Name = "CheckBoxKorvax";
            this.CheckBoxKorvax.Size = new System.Drawing.Size(92, 22);
            this.CheckBoxKorvax.TabIndex = 3;
            this.CheckBoxKorvax.Text = "Korvax";
            this.CheckBoxKorvax.UseVisualStyleBackColor = true;
            // 
            // PushToDatabase
            // 
            this.PushToDatabase.Font = new System.Drawing.Font("NMS GeoSans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PushToDatabase.ForeColor = System.Drawing.Color.Crimson;
            this.PushToDatabase.Location = new System.Drawing.Point(279, 396);
            this.PushToDatabase.Name = "PushToDatabase";
            this.PushToDatabase.Size = new System.Drawing.Size(127, 42);
            this.PushToDatabase.TabIndex = 6;
            this.PushToDatabase.Text = "Push Planet";
            this.PushToDatabase.UseVisualStyleBackColor = true;
            this.PushToDatabase.Click += new System.EventHandler(this.PushToDatabase_Click);
            // 
            // UrlBox
            // 
            this.UrlBox.Location = new System.Drawing.Point(279, 165);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(148, 20);
            this.UrlBox.TabIndex = 7;
            this.UrlBox.TextChanged += new System.EventHandler(this.UrlBox_TextChanged);
            // 
            // PreviewImage
            // 
            this.PreviewImage.AllowNavigation = false;
            this.PreviewImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewImage.Location = new System.Drawing.Point(279, 14);
            this.PreviewImage.Margin = new System.Windows.Forms.Padding(0);
            this.PreviewImage.MaximumSize = new System.Drawing.Size(145, 145);
            this.PreviewImage.MinimumSize = new System.Drawing.Size(20, 20);
            this.PreviewImage.Name = "PreviewImage";
            this.PreviewImage.ScrollBarsEnabled = false;
            this.PreviewImage.Size = new System.Drawing.Size(145, 145);
            this.PreviewImage.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("NMS GeoSans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adding a planet";
            // 
            // PlanetNameTitle
            // 
            this.PlanetNameTitle.Font = new System.Drawing.Font("NMS GeoSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanetNameTitle.Location = new System.Drawing.Point(12, 45);
            this.PlanetNameTitle.Name = "PlanetNameTitle";
            this.PlanetNameTitle.Size = new System.Drawing.Size(87, 21);
            this.PlanetNameTitle.TabIndex = 10;
            this.PlanetNameTitle.Text = "Planet name:";
            // 
            // DescriptionTitle
            // 
            this.DescriptionTitle.Font = new System.Drawing.Font("NMS GeoSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTitle.Location = new System.Drawing.Point(12, 66);
            this.DescriptionTitle.Name = "DescriptionTitle";
            this.DescriptionTitle.Size = new System.Drawing.Size(87, 21);
            this.DescriptionTitle.TabIndex = 11;
            this.DescriptionTitle.Text = "Description:";
            // 
            // PlanetTypeTitle
            // 
            this.PlanetTypeTitle.Font = new System.Drawing.Font("NMS GeoSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanetTypeTitle.Location = new System.Drawing.Point(12, 190);
            this.PlanetTypeTitle.Name = "PlanetTypeTitle";
            this.PlanetTypeTitle.Size = new System.Drawing.Size(87, 21);
            this.PlanetTypeTitle.TabIndex = 12;
            this.PlanetTypeTitle.Text = "Planettype:";
            // 
            // CheckBoxGek
            // 
            this.CheckBoxGek.Font = new System.Drawing.Font("NMS GeoSans", 12F);
            this.CheckBoxGek.Location = new System.Drawing.Point(279, 242);
            this.CheckBoxGek.Name = "CheckBoxGek";
            this.CheckBoxGek.Size = new System.Drawing.Size(92, 22);
            this.CheckBoxGek.TabIndex = 14;
            this.CheckBoxGek.Text = "Gek";
            this.CheckBoxGek.UseVisualStyleBackColor = true;
            // 
            // PlanetNameBox
            // 
            this.PlanetNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.PlanetNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlanetNameBox.Font = new System.Drawing.Font("NMS GeoSans", 12F);
            this.PlanetNameBox.ForeColor = System.Drawing.Color.White;
            this.PlanetNameBox.Location = new System.Drawing.Point(105, 45);
            this.PlanetNameBox.Name = "PlanetNameBox";
            this.PlanetNameBox.Size = new System.Drawing.Size(151, 19);
            this.PlanetNameBox.TabIndex = 15;
            this.PlanetNameBox.Text = "Earth";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionBox.Font = new System.Drawing.Font("NMS GeoSans", 10F);
            this.DescriptionBox.ForeColor = System.Drawing.Color.White;
            this.DescriptionBox.Location = new System.Drawing.Point(105, 66);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(150, 118);
            this.DescriptionBox.TabIndex = 16;
            this.DescriptionBox.Text = "Earth is the third planet from the Sun and the only astronomical object known to " + "harbour and support life. About 29.2% of Earth\'s surface is land consisting of c" + "ontinents and islands.";
            // 
            // CheckBoxVykeen
            // 
            this.CheckBoxVykeen.Font = new System.Drawing.Font("NMS GeoSans", 12F);
            this.CheckBoxVykeen.Location = new System.Drawing.Point(279, 270);
            this.CheckBoxVykeen.Name = "CheckBoxVykeen";
            this.CheckBoxVykeen.Size = new System.Drawing.Size(92, 22);
            this.CheckBoxVykeen.TabIndex = 17;
            this.CheckBoxVykeen.Text = "Vykeen";
            this.CheckBoxVykeen.UseVisualStyleBackColor = true;
            // 
            // GalaxieTitle
            // 
            this.GalaxieTitle.Font = new System.Drawing.Font("NMS GeoSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GalaxieTitle.Location = new System.Drawing.Point(12, 243);
            this.GalaxieTitle.Name = "GalaxieTitle";
            this.GalaxieTitle.Size = new System.Drawing.Size(87, 21);
            this.GalaxieTitle.TabIndex = 19;
            this.GalaxieTitle.Text = "Galaxy:";
            // 
            // GalaxyList
            // 
            this.GalaxyList.Font = new System.Drawing.Font("NMS GeoSans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GalaxyList.FormattingEnabled = true;
            this.GalaxyList.ItemHeight = 18;
            this.GalaxyList.Items.AddRange(new object[] { "Euclid", "Hilbert Dimension", "Calypso", "Hesperius Dimension", "Hyades", "Ickjamatew", "Budullangr", "Kikolgallr", "Eltiensleen", "Eissentam", "Elkupalos", "Aptarkaba", "Ontiniangp", "Odiwagiri", "Ogtialabi", "Muhacksonto", "Hitonskyer", "Rerasmutul", "Isdoraijung", "Doctinawyra", "Loychazinq", "Zukasizawa", "Ekwathore", "Yeberhahne", "Twerbetek", "Sivarates", "Eajerandal", "Aldukesci", "Wotyarogii", "Sudzerbal", "Maupenzhay", "Sugueziume", "Brogoweldian", "Ehbogdenbu", "Ijsenufryos", "Nipikulha", "Autsurabin", "Lusontrygiamh", "Rewmanawa", "Ethiophodhe", "Urastrykle", "Xobeurindj", "Oniijialdu", "Wucetosucc", "Ebyeloof", "Odyavanta", "Milekistri", "Waferganh", "Agnusopwit", "Teyaypilny", "Zalienkosm", "Ladgudiraf", "Mushonponte", "Amsentisz", "Fladiselm", "Laanawemb", "Ilkerloor", "Davanossi", "Ploehrliou", "Corpinyaya", "Leckandmeram", "Quulngais", "Nokokipsechl", "Rinblodesa", "Loydporpen", "Ibtrevskip", "Elkowaldb", "Heholhofsko", "Yebrilowisod", "Husalvangewi", "Ovna\'uesed", "Bahibusey", "Nuybeliaure", "Doshawchuc", "Ruckinarkh", "Thorettac", "Nuponoparau", "Moglaschil", "Uiweupose", "Nasmilete", "Ekdaluskin", "Hakapanasy", "Dimonimba", "Cajaccari", "Olonerovo", "Umlanswick", "Henayliszm", "Utzenmate", "Umirpaiya", "Paholiang", "Iaereznika", "Yudukagath", "Boealalosnj", "Yaevarcko", "Coellosipp", "Wayndohalou", "Smoduraykl", "Apmaneessu", "Hicanpaav", "Akvasanta", "Tuychelisaor", "Rivskimbe", "Daksanquix", "Kissonlin", "Aediabiel", "Ulosaginyik", "Roclaytonycar", "Kichiaroa", "Irceauffey", "Nudquathsenfe", "Getaizakaal", "Hansolmien", "Bloytisagra", "Ladsenlay", "Luyugoslasr", "Ubredhatk", "Cidoniana", "Jasinessa", "Torweierf", "Saffneckm", "Thnistner", "Dotusingg", "Luleukous", "Jelmandan", "Otimanaso", "Enjaxusanto", "Sezviktorew", "Zikehpm", "Bephembah", "Broomerrai", "Meximicka", "Venessika", "Gaiteseling", "Zosakasiro", "Drajayanes", "Ooibekuar", "Urckiansi", "Dozivadido", "Emiekereks", "Meykinunukur", "Kimycuristh", "Roansfien", "Isgarmeso", "Daitibeli", "Gucuttarik", "Enlaythie", "Drewweste", "Akbulkabi", "Homskiw", "Zavainlani", "Jewijkmas", "Itlhotagra", "Podalicess", "Hiviusauer", "Halsebenk", "Puikitoac", "Gaybakuaria", "Grbodubhe", "Rycempler", "Indjalala", "Fontenikk", "Pasycihelwhee", "Ikbaksmit", "Telicianses", "Oyleyzhan", "Uagerosat", "Impoxectin", "Twoodmand", "Hilfsesorbs", "Ezdaranit", "Wiensanshe", "Ewheelonc", "Litzmantufa", "Emarmatosi", "Mufimbomacvi", "Wongquarum", "Hapirajua", "Igbinduina", "Wepaitvas", "Sthatigudi", "Yekathsebehn", "Ebedeagurst", "Nolisonia", "Ulexovitab", "Iodhinxois", "Irroswitzs", "Bifredait", "Beiraghedwe", "Yeonatlak", "Cugnatachh", "Nozoryenki", "Ebralduri", "Evcickcandj", "Ziybosswin", "Heperclait", "Sugiuniam", "Aaseertush", "Uglyestemaa", "Horeroedsh", "Drundemiso", "Ityanianat", "Purneyrine", "Dokiessmat", "Nupiacheh", "Dihewsonj", "Rudrailhik", "Tweretnort", "Snatreetze", "Iwunddaracos", "Digarlewena", "Erquagsta", "Logovoloin", "Boyaghosganh", "Kuolungau", "Pehneldept", "Yevettiiqidcon", "Sahliacabru", "Noggalterpor", "Chmageaki", "Veticueca", "Vittesbursul", "Nootanore", "Innebdjerah", "Kisvarcini", "Cuzcogipper", "Pamanhermonsu", "Brotoghek", "Mibittara", "Huruahili", "Raldwicarn", "Ezdartlic", "Badesclema", "Isenkeyan", "Iadoitesu", "Yagrovoisi", "Ewcomechio", "Inunnunnoda", "Dischiutun", "Yuwarugha", "Ialmendra", "Reponudrle", "Rinjanagrbo", "Zeziceloh", "Oeileutasc", "Zicniijinis", "Dugnowarilda", "Neuxoisan", "Ilmenhorn", "Rukwatsuku", "Nepitzaspru", "Chcehoemig", "Haffneyrin", "Uliciawai", "Tuhgrespod", "Iousongola" });
            this.GalaxyList.Location = new System.Drawing.Point(12, 267);
            this.GalaxyList.Name = "GalaxyList";
            this.GalaxyList.Size = new System.Drawing.Size(244, 22);
            this.GalaxyList.TabIndex = 18;
            // 
            // AddPlanetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.GalaxieTitle);
            this.Controls.Add(this.GalaxyList);
            this.Controls.Add(this.CheckBoxVykeen);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.PlanetNameBox);
            this.Controls.Add(this.CheckBoxGek);
            this.Controls.Add(this.PlanetTypeTitle);
            this.Controls.Add(this.DescriptionTitle);
            this.Controls.Add(this.PlanetNameTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PreviewImage);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.PushToDatabase);
            this.Controls.Add(this.CheckBoxKorvax);
            this.Controls.Add(this.PlanetTypeList);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddPlanetForm";
            this.Text = "Add Planet to Database";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox UrlBox;

        private System.Windows.Forms.ListBox GalaxyList;

        private System.Windows.Forms.Label GalaxieTitle;

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

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.WebBrowser PreviewImage;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.WebBrowser webBrowser1;

        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}