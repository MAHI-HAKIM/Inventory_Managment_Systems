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
using User_Repo;
using Guna.UI2.WinForms;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace IMS_GUI.GUI_Form
{
    public partial class Login_Form : Form
    {
        // Create a list that contains your TextBoxes and Buttons in the order they should be navigated
        List<Guna.UI2.WinForms.Guna2TextBox> textboxes;

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
            textboxes = new List<Guna.UI2.WinForms.Guna2TextBox> { username_txt, password_txt };

            // Initialize the IDatabaseConnection object here
            dbConnection = new DBConnection();
            // Initialize the IFormValidator object here
            validator = new FormValidator();
            // Initialize the PassWordWithSaltHasher object here
            hasher = new PasswordWithSaltHasher();

            // Set KeyPreview to true
            this.KeyPreview = true;

            validator.SetupNavigation(this, textboxes);

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
            if (e.Button == MouseButtons.Left)
            {
                ValidateAndPerformLogin();
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
        private void ValidateAndPerformLogin()
        {
            bool isUsernameEmpty = validator.IsTextBoxEmpty(username_txt);
            bool isPasswordEmpty = validator.IsTextBoxEmpty(password_txt);

            // Update label visibility based on textbox content
            username_lbl.Visible = isUsernameEmpty;
            password_label.Visible = isPasswordEmpty;

            if (isUsernameEmpty || isPasswordEmpty)
            {
                if (isUsernameEmpty)
                    username_txt.Focus();
                else if (isPasswordEmpty)
                    password_txt.Focus();

                return;
            }
            try
            {
                //    Get user input
                string enteredUsername = username_txt.Text;
                string enteredPassword = password_txt.Text;

                UserRepository userRepository = new UserRepository();
                Users user = userRepository.LogUserIn(enteredUsername, enteredPassword);

                if (user != null)
                {
                    //If user is not null, it means the login was successful.
                    if (user.IsActive)
                    {
                        // Successful login, and user is active
                        // You can also check the RoleId to determine access permissions
                        int roleId = user.RoleId;

                        Admin_Form ad = new Admin_Form();
                        ad.FormClosed += (s, args) => this.Close();
                        this.Hide();
                        ad.Show();

                    }

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
        private void Login_Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // if the pressed key is Enter
            {
                e.Handled = true; // Prevent the beep sound
                ValidateAndPerformLogin();
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
        private void username_txt_TextChanged(object sender, EventArgs e)
        {
            username_lbl.Visible = false;
        }
        private void password_txt_TextChanged(object sender, EventArgs e)
        {
            password_label.Visible=false;
        }

        #endregion

    }
}
