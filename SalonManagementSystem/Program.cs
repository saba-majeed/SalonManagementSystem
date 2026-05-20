using System;
using System.Windows.Forms;
using SalonManagementSystem.Forms;

namespace SalonManagementSystem
{
    /// <summary>
    /// Application Entry Point
    /// App frmLogin se shuru hoti hai
    /// </summary>
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ⚠️ Dashboard nahi, Login se start karo
            Application.Run(new frmLogin());
        }
    }
}
