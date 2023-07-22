﻿using System;
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

            IHandleDbOperation hdo = new HandleDbOperations();

            SignUp_Form signUpForm = new SignUp_Form();
            Login_Page loginForm = new Login_Page();

            if (hdo.SuperAdminExists())
            {
                Application.Run(loginForm); // Run Login form if admin exists
            }
            else if (hdo.AdminExist())
            {
                Application.Run(loginForm); // Run Login form if admin exists
            }
            else
            {
                Application.Run(signUpForm); // Run Signup form if no admin exists
            }

            //Application.Run(new Login_Page());
        }
    }
}
