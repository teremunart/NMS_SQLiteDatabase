using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NMS_Database {
    public class Utils {
        private readonly string _connectionstring = @"Data Source=" + Path.GetFullPath(@"..\..\database\database.db") + "; Version = 3;";

        public SQLiteDataReader GetDatabase(string sql) {
            SQLiteDataReader reader = null;
            
            SQLiteConnection connection = new SQLiteConnection(_connectionstring); 
            connection.Open();
            
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader rdr = command.ExecuteReader();
            
            if (rdr.HasRows) reader = rdr;

            return reader;
        }
        
        public Bitmap GlyphsTranslator(char glyph) {
            return glyph switch {
                '0' => Properties.Resources._0,
                '1' => Properties.Resources._1,
                '2' => Properties.Resources._2,
                '3' => Properties.Resources._3,
                '4' => Properties.Resources._4,
                '5' => Properties.Resources._5,
                '6' => Properties.Resources._6,
                '7' => Properties.Resources._7,
                '8' => Properties.Resources._8,
                '9' => Properties.Resources._9,
                'A' => Properties.Resources.A,
                'B' => Properties.Resources.B,
                'C' => Properties.Resources.C,
                'D' => Properties.Resources.D,
                'E' => Properties.Resources.E,
                'F' => Properties.Resources.F,
                _ => null
            };
        }
        
        public string GalacticToPortal(string galAdd) {
            int index = 0;
            int counter = 0;
            int[] block = new int[4];

            foreach (var id in galAdd) {
                block[index] = block[index] + id;
                counter++;
                if (counter > 4) {
                    index++;
                    counter = 0;
                }
            }

            //Voxel Coordinates to Portal Code --> Calculation by Kevin0M16 - https://github.com/Kevin0M16
            
            int dd1 = block[0] + 2047;
            int dd2 = block[1] + 127;
            int dd3 = block[2] + 2047;

            string g1 = dd1.ToString("X");
            string g2 = dd2.ToString("X");
            string g3 = dd3.ToString("X");
            string g4 = block[3].ToString("X");

            int dec1 = Convert.ToInt32(g1, 16); // X[HEX] to X[DEC]
            int dec2 = Convert.ToInt32(g2, 16); // Y[HEX] to X[DEC]
            int dec3 = Convert.ToInt32(g3, 16); // Z[HEX] to X[DEC]
            
            int dec5 = Convert.ToInt32("801", 16); // 801[HEX] to 801[DEC]
            int dec6 = Convert.ToInt32("81", 16); // 81[HEX] to 81[DEC]
            int dec7 = Convert.ToInt32("1000", 16); // 100[HEX] to 1000[DEC]
            int dec8 = Convert.ToInt32("100", 16); // 100[HEX] to 100[DEC]
            
            int calc1 = (dec1 + dec5) % dec7; // (X[DEC] + 801[DEC]) MOD (1000[DEC])
            int calc2 = (dec2 + dec6) % dec8; // (Y[DEC] + 81[DEC]) MOD (100[DEC])
            int calc3 = (dec3 + dec5) % dec7; // (Z[DEC] + 801[DEC]) MOD (1000[DEC])
            
            string hexX = calc1.ToString("X"); //Calculated portal X[DEC] to X[HEX]
            string hexY = calc2.ToString("X"); //Calculated portal Y[DEC] to Y[HEX]
            string hexZ = calc3.ToString("X"); //Calculated portal Z[DEC] to Z[HEX]
            
            int ihexX = (Convert.ToInt32(hexX, 16) & 0xFFF); // X[HEX] to X[DEC] 3 digits
            int ihexY = (Convert.ToInt32(hexY, 16) & 0xFF); // Y[HEX] to Y[DEC] 2 digits
            int ihexZ = (Convert.ToInt32(hexZ, 16) & 0xFFF); // Z[HEX] to Z[DEC] 3 digits
            int ihexSSI = (Convert.ToInt32(g4, 16) & 0xFFF); // SSI[HEX] to SSI[DEC] 3 digits

            return $"0{ihexSSI:X3}{ihexY:X2}{ihexZ:X3}{ihexX:X3}"; // Format digits 1 3 2 3 3;
        }

        public void ChangeGlyphs(PictureBox[] imgGlyph, char[] portalAddress) {
            for (int i = 0; i < imgGlyph.Length; i++) {
                imgGlyph[i].Image = GlyphsTranslator(portalAddress[i]);
            }
        }

        public string GalaxyColorTranslator(string color) {
            return color switch {
                "N/A"           => "#000000", 
                "White"         => "#FFFFFF",
                "Deep Pink"     => "#FF1493",
                "Medium Orchid" => "#ba55d3",
                "Violet"        => "#ee82ee",
                "Light Blue"    => "#add8e6",
                "Turquoise"     => "#40e0d0",
                "Green"         => "#90ee90",
                "Lime Green"    => "#32cd32",
                "Yellow"        => "#FFFF00",
                "Orange"        => "#ffa500",
                "Indigo"        => "#8A2BE2",
                _               => "#000000"
            };
        }
    }
}