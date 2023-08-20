using IMS_DataAccess;
using IMS_GUI.GUI_Form;
using System.Data.SqlClient;
using System.Transactions;

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
            try 
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                IHandleDbOperation hdo = new HandleDbOperation();
                Signup_Form signUpForm = new Signup_Form();
                Login_Form loginForm = new Login_Form();


                Application.Run(new Admin_Form());
                //  Application.Run(new Login_Form());

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
          

        }
    }
}