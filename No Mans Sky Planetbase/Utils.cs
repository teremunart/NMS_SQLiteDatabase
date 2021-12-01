using System.IO;

namespace No_Mans_Sky_Planetbase {
    public class Utils {
        private static readonly string CONNECTIONSTRING = @"Data Source=" + Path.GetFullPath(@"..\..\database\database.db") + "; Version = 3;";

        internal string GetConnectionString() {
            return (@"Data Source=" + Path.GetFullPath(@"..\..\database\database.db") + "; Version = 3;");
        }
    }
}