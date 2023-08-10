using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; //Simpler way to Hash and Salt Passwords for a better Securtiy
using IMS_DataAccess;
using System.Data.SqlClient;

namespace IMS_GUI.GUI_Form
{
    public partial class Login_Form : Form
    {
        // Create a list that contains your TextBoxes and Buttons in the order they should be navigated
        List<Guna.UI2.WinForms.Guna2TextBox> controls;

        //Some Class initializing
        IFormValidator validator;
        IDBConnection dbConnection;
        PasswordWithSaltHasher hasher;

        public Login_Form()
        {
            InitializeComponent();

            this.Shown += new EventHandler(Login_Form_Load);

            // Set the password to be hidden initially
            password_txt.UseSystemPasswordChar = true;

            // Initialize the Control list here
            controls = new List<Guna.UI2.WinForms.Guna2TextBox> { username_txt, password_txt };

            // Initialize the IDatabaseConnection object here
            dbConnection = new DBConnection();
            // Initialize the IFormValidator object here
            validator = new FormValidator();
            // Initialize the PassWordWithSaltHasher object here
            hasher = new PasswordWithSaltHasher();

            // Set KeyPreview to true
            this.KeyPreview = true;
            validator.SetupNavigation(this, controls);

            // attach the KeyPress event to your TextBox controls
            // attach the KeyPress event to your TextBox controls
            username_txt.KeyPress += (sender, e) => validator.CheckSpace_KeyPress(sender as Guna.UI2.WinForms.Guna2TextBox, e, "Username");
            password_txt.KeyPress += (sender, e) => validator.CheckSpace_KeyPress(sender as Guna.UI2.WinForms.Guna2TextBox, e, "Password");

            // attach the TextChanged event to your TextBox controls
            validator.ResetColor_TextChanged(username_txt);
            validator.ResetColor_TextChanged(password_txt);

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            // Set focus on username_txt
            username_txt.Focus();
        }

        #region Button Controls

        private void login_btn_MouseDown(object sender, MouseEventArgs e)
        {
            // Respond only to the left mouse button
            if (e.Button == MouseButtons.Left)
            {
                try
                {

                    // Validate all the input fields
                    if (validator.IsTextBoxEmpty(username_txt, "Name") ||
                        validator.IsTextBoxEmpty(password_txt, "Password"))
                    {
                        return;
                    }
                    // Get user input
                    string enteredUsername = username_txt.Text;
                    string enteredPassword = password_txt.Text;

                    UserRepository userRepository = new UserRepository();
                    User user = userRepository.LogUserIn(enteredUsername, enteredPassword);

                    if (user != null)
                    {
                        // If user is not null, it means the login was successful.
                        // Authenticate the user and proceed to the welcome screen.
                        //Welcom_Form welcomeForm = new Welcom_Form(user.Contact.FirstName, user.Contact.LastName);
                        Admin_Form ad = new Admin_Form();
                        //Welcom_Form welcomeForm = new Welcom_Form();

                        ad.FormClosed += (s, args) => this.Close();
                        this.Hide();
                        ad.Show();
                    }
                    else
                    {
                        // If user is null, it means the login was not successful.
                        MessageBox.Show("Invalid username or password.");
                        password_txt.Focus();
                    }
                }
                catch (SqlException ex)
                {
                    // This block will catch any SQL related exceptions
                    MessageBox.Show("A SQL error occurred: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // This block will catch any general exceptions
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    dbConnection.CloseConnection();
                }
            }
        }
        private void signup_btn_Click(object sender, EventArgs e)
        {
            Signup_Form sg = new Signup_Form();
            this.Hide();
            sg.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }
        #endregion

        #region Additional Form Features
        private void Login_Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) // if the pressed key is Enter
            {
                login_btn.PerformClick(); // programmatically click the login button
            }
        }
        private void username_txt_Enter(object sender, EventArgs e)
        {
            username_txt.IconLeft = Properties.Resources.userblue;
        }
        private void username_txt_Leave(object sender, EventArgs e)
        {
            username_txt.IconLeft = Properties.Resources.user;

        }
        private void password_txt_Enter(object sender, EventArgs e)
        {
            password_txt.IconLeft = Properties.Resources.lockblue;

        }
        private void password_txt_Leave(object sender, EventArgs e)
        {
            password_txt.IconLeft = Properties.Resources.padlock;

        }
        private void password_txt_IconRightClick(object sender, EventArgs e)
        {
            // Toggle the UseSystemPasswordChar
            password_txt.UseSystemPasswordChar = !password_txt.UseSystemPasswordChar;

            // Change the PictureBox's image based on the current state of UseSystemPasswordChar
            if (password_txt.UseSystemPasswordChar)
            {
                password_txt.IconRight = Properties.Resources.hide;
            }
            else
            {
                password_txt.IconRight = Properties.Resources.eye;
            }
        }

        #endregion
    }
}
