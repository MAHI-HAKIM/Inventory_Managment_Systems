using IMS_DataAccess;
using IMS_GUI.GUI_Form;

namespace IMS_GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IHandleDbOperation hdo = new HandleDbOperation();
            Signup_Form signUpForm = new Signup_Form();
            Login_Form loginForm = new Login_Form();

            //if (hdo.SuperAdminExists())
            //{
            //    Application.Run(loginForm); // Run Login form if admin exists
            //}
            //else if (hdo.AdminExist())
            //{
            //    Application.Run(loginForm); // Run Login form if admin exists
            //}
            //else
            //{
            //    Application.Run(signUpForm); // Run Signup form if no admin exists
            //}

            //Application.Run(new Admin_Form());
            Application.Run(new Login_Form());

        }
    }
}