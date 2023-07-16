﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; //Simpler way to Hash and Salt Passwords for a better Securtiy
using System.Data.SqlClient;

namespace Inventory_Managment_System
{
    public partial class Login_Form : Form
    {
        // Create a list that contains your TextBoxes and Buttons in the order they should be navigated
        List<Control> controls;

        //Some Class initializing
        IFormValidator validator;
        DBConnection dbConnection;
        PasswordWithSaltHasher hasher;

        public Login_Form()
        {
            InitializeComponent();

            // Initialize the Control list here
            controls = new List<Control> { username_txt, password_txt};

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
            username_txt.KeyPress += (sender, e) => validator.CheckSpace_KeyPress(sender as Control, e, "Username");
            password_txt.KeyPress += (sender, e) => validator.CheckSpace_KeyPress(sender as Control, e, "Password");

            // attach the TextChanged event to your TextBox controls
            validator.ResetColor_TextChanged(username_txt);
            validator.ResetColor_TextChanged(password_txt);
        }

        #region Form Related Control Functions
        private void Login_Form_Load(object sender, EventArgs e)
        {
            // Set focus on username_txt
            username_txt.Focus();
        }

        private void login_btn_Click(object sender, EventArgs e)
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

                // Retrieve the salt and hashed password from the database
                string storedSalt, storedHashedPassword , firstname , lastname;

                // Opening the connection
                using (var connection = dbConnection.OpenConnection())
                {
                    string query = "SELECT FirstName,LastName,Salt,PasswordHash FROM Users WHERE Username = @username";
                    using (SqlCommand cmd = new SqlCommand(query, dbConnection.Connection))
                    {
                        cmd.Parameters.AddWithValue("@username", enteredUsername);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                storedSalt = reader["Salt"].ToString();
                                storedHashedPassword = reader["PasswordHash"].ToString();
                                firstname = reader["FirstName"].ToString();
                                lastname = reader["LastName"].ToString();
                            }
                            else
                            {
                                // No user with the entered username found in the database
                                MessageBox.Show("Invalid username or password.");
                                return;
                            }
                        }
                    }

                    // Hash the entered password with the retrieved salt
                    string hashedEnteredPassword = hasher.HashPassword(enteredPassword, storedSalt);

                    // Compare the newly hashed password with the retrieved hashed password
                    if (hashedEnteredPassword == storedHashedPassword)
                    {
                        // If they match, the entered password is correct.
                        // Authenticate the user and proceed to the welcome screen.
                        Welcome_Form welcomeForm = new Welcome_Form(firstname, lastname);
                        welcomeForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // If they don't match, the entered password is incorrect.
                        MessageBox.Show("Invalid username or password.");
                    }
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
        private void clear_btn_Click(object sender, EventArgs e)
        {

            validator.ClearFormControls(controls);

            username_txt.Focus();
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
                username_txt.Focus();
            }
        }
        private void test_btn_Click(object sender, EventArgs e)
        {
            try
            {
                 dbConnection.OpenConnection();

                if (dbConnection.Connection.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Connection to database successful.");
                }
                else
                {
                    MessageBox.Show("Connection to database failed.");
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
        private void signup_btn_Click(object sender, EventArgs e)
        {
            SignUp_Form sg = new SignUp_Form();
            this.Hide();
            sg.Show();
        }
        #endregion
    }
}
