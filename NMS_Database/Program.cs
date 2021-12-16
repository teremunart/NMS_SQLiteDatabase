using System.Windows.Forms;

namespace NMS_Database {
    
    static class Program {
        
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}