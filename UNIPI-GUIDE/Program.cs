using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    internal static class Program
    {   
        public static class User
        {
            private static bool _loggedIn = false;
            public static bool loggedIn
            {
                get { return _loggedIn; }
                set { _loggedIn = value; }
            }

            private static int _id = -1;
            public static int id
            {
                get { return _id; }
                set { _id = value; }
            }

            private static string _username = string.Empty;
            public static string username
            {
                get { return _username; }
                set { _username = value; }
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}
