using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static bool SkipLogin = true; // 🔹 đổi sang false để bật lại login
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (SkipLogin)
                Application.Run(new frmMain("admin")); // Chạy thẳng form chính
            else
                Application.Run(new frmDangNhap()); // Chạy form đăng nhập
        }
    }
}
