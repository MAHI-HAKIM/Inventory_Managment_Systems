﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMS_DataAccess;
using User_Repo;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace IMS_GUI.GUI_Form
{
    public partial class Signup_Form : Form
    {
        //Some Class initializing
        IFormValidator validator;
        IDBConnection dbConnection;
        IHandleDbOperation hdo;
        PasswordWithSaltHasher hashing;

        public Signup_Form()
        {
            InitializeComponent();

            // Initialize the IDatabaseConnection object here
            dbConnection = new DBConnection();
            // Initialize the IFormValidator object here
            validator = new FormValidator();
            // Initialize the PassWordWithSaltHasher object here
            hashing = new PasswordWithSaltHasher();
            // Initialize the HandleDbOperation object here
            hdo = new HandleDbOperation();

            // Set KeyPreview to true
            this.KeyPreview = true;
            //validator.SetupNavigation(this, controls);

            // Add a Shown event handler
            this.Shown += Signup_Form_Load;

            //check if any charachter rather than a numeric is entered
            phoneNo_txt.KeyPress += (sender, e) => validator.CheckNumeric_KeyPress(sender as Control, e, "Phone Number");
        }

        private void Signup_Form_Load(object sender, EventArgs e)
        {
            if (hdo.SuperAdminExists())
            {
                superad_rd.Visible = false;
            }
            if (hdo.AdminExist())
            {
                admin_rd.Visible = false;
            }
            // Set focus on username_txt
            username_txt.Focus();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            //// Step 1: Input validation
            //if (validator.IsTextBoxEmpty(username_txt, "UserName") ||
            //    validator.IsTextBoxEmpty(password_txt, "Password") ||
            //    validator.IsTextBoxEmpty(phoneNo_txt, "Phone Number") ||
            //    validator.IsTextBoxEmpty(firstname_txt, "First Name") ||
            //    validator.IsTextBoxEmpty(lastname_txt, "Last Name"))
            //{
            //    return;
            //}

            //// Validate and transform phone number
            //string phoneNumber = validator.ValidateAndTransformPhoneNumber(phoneNo_txt);
            //if (phoneNumber == null) return;

            ////Validate Role and Choose which role is selected
            ////Role? role = validator.ValidateRoleSelection(superad_rd.Checked, admin_rd.Checked, employee_rd.Checked);
            //string enteredAddress = string.IsNullOrWhiteSpace(address_txt.Text) ? "ET" : address_txt.Text;

            //string password = password_txt.Text;
            //string salt = hashing.GenerateSalt();
            //string hashedPassword = hashing.HashPassword(password, salt);

            ////if (role == null)
            ////{
            ////    return; // Exit if no role was selected.
            ////}

            //if (hdo.DoesUserExist(username_txt.Text))
            //{
            //    MessageBox.Show("Username already exists.");
            //    username_txt.Clear();
            //    username_txt.Focus();
            //}
            //else
            //{

            //    // Step 2: Create User and ContactInfo objects
            //    ContactInfo contact = new ContactInfo()
            //    {
            //        FirstName = firstname_txt.Text,
            //        LastName = lastname_txt.Text,
            //        PhoneNo = phoneNumber,
            //        Address = enteredAddress
            //    };
            //    User user = new User()
            //    {
            //        Username = username_txt.Text,
            //        PasswordHash = hashedPassword,
            //        Salt = salt,
            //        Role = (Role)role, // Or whichever role they've selected
            //        Contact = contact
            //    };

            //    // Step 3: Use UserRepository to create the user
            //    try
            //    {
            //        // Use UserRepository to create the user
            //        IUserRepository userRepository = new UserRepository();
            //        userRepository.CreateUser(user);

            //        // Show a success message
            //        MessageBox.Show("Successfully signed up!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        //validator.ClearFormControls(controls);
            //        //validator.UncheckRadioButtons(radios);
            //        //// Clear the form or close it, depending on your needs
            //    }
            //    catch (SqlException ex)
            //    {
            //        // This block will catch any SQL related exceptions
            //        MessageBox.Show("A SQL error occurred: " + ex.Message);
            //    }
            //    catch (Exception ex)
            //    {
            //        // This block will catch any general exceptions
            //        MessageBox.Show("An error occurred: " + ex.Message);
            //    }
            //    finally
            //    {
            //        dbConnection.CloseConnection();
            //    }
            //}
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Admin_Form lg = new Admin_Form();
            this.Hide();
            lg.Show();
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

        private void delete_btn_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new UserRepository();

            try
            {

                if (!hdo.AnyUserExists())
                {
                    MessageBox.Show("No users exist to delete.");
                    return;
                }
                int userId = Convert.ToInt32(deleteUser_txt.Text);

                if (hdo.UserExistsById(userId))
                {
                    //userRepository.DeleteUser(userId);
                    MessageBox.Show("User deleted successfully.");
                }
                else
                {
                    MessageBox.Show("No user with the provided ID exists.");
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
    
}
