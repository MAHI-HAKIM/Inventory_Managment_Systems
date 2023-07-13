using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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


            SignUp_Form signUpForm = new SignUp_Form();
            Login_Form loginForm = new Login_Form();

            HandleDbOperations hdo = new HandleDbOperations();


            //if (hdo.IsAdminExists())
            //{
            //    Application.Run(loginForm); // Run Login form if admin exists
            //}
            //else
            //{
            //    Application.Run(signUpForm); // Run Signup form if no admin exists
            //}

            Application.Run(new SignUp_Form());
        }
    }
}
