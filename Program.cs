using System;
using System.Windows.Forms;

namespace Remote_Desktop_Connection_List_Manager {
    static class Program
    {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManagerForm());
        }
    }
}
