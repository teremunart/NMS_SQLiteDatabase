using System.IO;

namespace No_Mans_Sky_Planetbase {
    public class Utils {
        public string GetConnectionString() {
            return (@"Data Source=" + Path.GetFullPath(@"..\..\database\database.db") + "; Version = 3;");
        }
    }
}