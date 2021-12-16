using System.IO;

namespace NMS_Database {
    public class Utils {
        internal readonly string CONNECTIONSTRING = @"Data Source=" + Path.GetFullPath(@"..\..\database\database.db") + "; Version = 3;";
    }
}