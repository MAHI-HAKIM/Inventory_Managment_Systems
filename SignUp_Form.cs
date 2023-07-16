using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Managment_System
{
    public partial class SignUp_Form : Form 
    {
        // Create a list that contains your TextBoxes and Buttons in the order they should be navigated
        List<Control> controls;

        //Some Class initializing
        IFormValidator validator;
        IDBConnection dbConnection;
        PasswordWithSaltHasher hashing;
        HandleDbOperations hdo;

        public SignUp_Form()
        {
            InitializeComponent();

            // Initialize the Control list here
            controls = new List<Control> { username_txt, password_txt, phoneNo_txt, firstname_txt, lastname_txt };

            // Initialize the IDatabaseConnection object here
            dbConnection = new DBConnection();
            // Initialize the IFormValidator object here
            validator = new FormValidator();
            // Initialize the PassWordWithSaltHasher object here
            hashing = new PasswordWithSaltHasher();
            // Initialize the HandleDbOperation object here
            hdo = new HandleDbOperations();

            // Set KeyPreview to true
            this.KeyPreview = true;
            validator.SetupNavigation(this, controls);

            // Add a Shown event handler
            this.Shown += SignUp_Form_Load;

            // attach the KeyPress event to your TextBox controls
            username_txt.KeyPress += (sender, e) => validator.CheckSpace_KeyPress(sender as Control, e, "Username");
            password_txt.KeyPress += (sender, e) => validator.CheckSpace_KeyPress(sender as Control, e, "Password");
            phoneNo_txt.KeyPress += (sender, e) => validator.CheckSpace_KeyPress(sender as Control, e, "Phone Number");

            // attach the TextChanged event to your TextBox controls
            validator.ResetColor_TextChanged(username_txt);
            validator.ResetColor_TextChanged(password_txt);
            validator.ResetColor_TextChanged(phoneNo_txt);

            //check if any charachter rather than a numeric is entered
            phoneNo_txt.KeyPress += (sender, e) => validator.CheckNumeric_KeyPress(sender as Control, e , "Phone Number");
        }

        #region //Form Related Controls

        private void SignUp_Form_Load(object sender, EventArgs e)
        {
            // Set focus on username_txt
            username_txt.Focus();

        }
        private void signup_btn_Click(object sender, EventArgs e)
        {
   
            if (validator.IsTextBoxEmpty(username_txt, "Name") ||
                validator.IsTextBoxEmpty(password_txt, "Password") ||
                validator.IsTextBoxEmpty(phoneNo_txt, "Phone Number") ||
                validator.IsTextBoxEmpty(firstname_txt, "First Name")||
                validator.IsTextBoxEmpty(lastname_txt, "Last Name"))
            {
                return;
            }

            string role = validator.ValidateRole(admin_rd, employee_rd);
            if (role == null) return;


            // Retrieve all the input values
            string firstName = firstname_txt.Text;
            string lastName = lastname_txt.Text;
            string username = username_txt.Text;
            string password = password_txt.Text;
            // Validate and transform phone number
            string phoneNumber = validator.ValidateAndTransformPhoneNumber(phoneNo_txt);
            if (phoneNumber == null) return;

            string salt = hashing.GenerateSalt();
            string hashedPassword = hashing.HashPassword(password, salt);

                try
                {
                    // Opening the connection
                    using (var connection = dbConnection.OpenConnection())
                    {

                    if (hdo.DoesUserExist(username))
                    {
                        MessageBox.Show("This username already exists. Please choose a different username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        username_txt.Focus();
                        return;
                    }
                    //string query = "INSERT INTO Users (Username, PasswordHash, Salt, PhoneNo, FirstName, LastName, Role) VALUES (@username, @hashed, @salt, @phoneNo, @firstName, @lastName, @role)";

                    using (SqlCommand cmd = new SqlCommand("CreateUser", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@hashed", hashedPassword);
                            cmd.Parameters.AddWithValue("@salt", salt);
                            cmd.Parameters.AddWithValue("@phoneNo", phoneNumber);
                            cmd.Parameters.AddWithValue("@firstName", firstName);
                            cmd.Parameters.AddWithValue("@lastName", lastName);
                            cmd.Parameters.AddWithValue("@role", role);

                            int affectedRows = cmd.ExecuteNonQuery(); // Get the number of affected rows

                            // If the insertion was successful, the affectedRows should be greater than 0
                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear the form controls
                            validator.ClearFormControls(controls);
                            }
                            else
                            {
                                MessageBox.Show("Signup failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // Clear the form controls
                            validator.ClearFormControls(controls);
                        }
                    }
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception and display a user-friendly message
                    // Note: you might want to log the exception details somewhere, for example in a file or a logging service
                    MessageBox.Show("An error occurred while attempting to sign up. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            finally
            {
                dbConnection.CloseConnection();
            }


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

        private void back_btn_Click(object sender, EventArgs e)
        {
            Login_Form lg = new Login_Form();

            this.Hide();
            lg.Show();

        }

        #endregion
        
    }
}
