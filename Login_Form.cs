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
using System.Data.SqlClient;

namespace Inventory_Managment_System
{
    public partial class Login_Form : Form
    {
        DBConnection dbConnection = new DBConnection();

        public Login_Form()
        {
            InitializeComponent();


            // attach the KeyPress event to your TextBox controls
            username_txt.KeyPress += (s, e) => CheckSpace_KeyPress(s, e, "Username");
            password_txt.KeyPress += (s, e) => CheckSpace_KeyPress(s, e, "Password");

            // attach the TextChanged event to your TextBox controls
            username_txt.TextChanged += ResetColor_TextChanged;
            password_txt.TextChanged += ResetColor_TextChanged;
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            // Validate all the input fields
            if (IsTextboxEmpty(username_txt, "Username") ||
                IsTextboxEmpty(password_txt, "Password") )
            {
                return;
            }
            
            // Retrieve all the input values
            string username = username_txt.Text;
            string password = password_txt.Text;

            // Open a connection to the database
            SqlConnection connection = dbConnection.OpenConnection();

            // Select the user from the database
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Username = @username AND Password = @password", connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Welcome_Form welcomeForm = new Welcome_Form();
                        welcomeForm.WelcomeMessage = "Welcome";
                        welcomeForm.FirstNameMessage = reader["FirstName"].ToString();
                        welcomeForm.LastNameMessage = reader["LastName"].ToString();


                        this.Hide();
                        welcomeForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            // Close the connection
            dbConnection.CloseConnection();
        }


        private void CheckSpace_KeyPress(object sender, KeyPressEventArgs e, string fieldName)
        {
            if (e.KeyChar == ' ') // ASCII value for space
            {
                e.Handled = true; // Stops the character from being entered into the TextBox
                ((TextBox)sender).ForeColor = Color.Red; // Change the TextBox's text color to red
                MessageBox.Show(fieldName + " cannot contain spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetColor_TextChanged(sender, e); // Reset color after showing the MessageBox

            }
        }

        private void ResetColor_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!textBox.Text.Contains(" ")) // If the TextBox's text no longer contains a space
            {
                textBox.ForeColor = SystemColors.WindowText; // Reset the TextBox's text color to default
            }
        }

        private bool IsTextboxEmpty(TextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(fieldName + " field cannot be empty.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus(); // Set the focus to this textbox
                return true;
            }
            return false;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {

            username_txt.Clear();
            password_txt.Clear();

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
            SqlConnection connection = dbConnection.OpenConnection();

            if (connection.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Connection to database successful.");
                dbConnection.CloseConnection();
            }
            else
            {
                MessageBox.Show("Connection to database failed.");
            }
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            SignUp_Form sg = new SignUp_Form();
            this.Hide();
            sg.Show();
        }

       
    }
}
