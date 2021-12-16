using System.IO;

namespace No_Mans_Sky_Planetbase {
    public class Utils {
        internal readonly string CONNECTIONSTRING = @"Data Source=" + Path.GetFullPath(@"..\..\database\database.db") + "; Version = 3;";
    }
}