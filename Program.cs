using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
namespace Inventory_Managment_System
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new windows);

            //    IHandleDbOperation hdo = new HandleDbOperations();

            //  SignUp_Form signUpForm = new SignUp_Form();
            //  Login_Form loginForm = new Login_Form();


            /* if (hdo.SuperAdminExists())
             {
                 Application.Run(loginForm); // Run Login form if admin exists
             }
             else
             {
                 Application.Run(signUpForm); // Run Signup form if no admin exists
             }
             */


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Users
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
