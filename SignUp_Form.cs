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
        public SignUp_Form()
        {
            InitializeComponent();

            // Add a Shown event handler
            this.Shown += SignUp_Form_Load;
        }

        DBConnection dbConnection = new DBConnection();

        private void SignUp_Form_Load(object sender, EventArgs e)
        {
            // Set focus on username_txt
            username_txt.Focus();

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            // Validate all the input fields
            if (IsTextboxEmpty(username_txt, "Username") ||
                IsTextboxEmpty(password_txt, "Password") ||
                IsTextboxEmpty(email_txt, "Email") ||
                IsTextboxEmpty(firstname_txt, "First Name") ||
                IsTextboxEmpty(lastname_txt, "Last Name") ||
                IsComboBoxEmpty(cmbRole, "role"))
            {
                return;
            }

            // Retrieve all the input values
            string email = email_txt.Text;
            string firstName = firstname_txt.Text;
            string lastName = lastname_txt.Text;
            string username = username_txt.Text;
            string password = password_txt.Text;
            string selectedRole = cmbRole.SelectedItem.ToString();

            // Open a connection to the database
            SqlConnection connection = dbConnection.OpenConnection();

            // Insert the new user into the database
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, Password, Email, FirstName, LastName, Role) VALUES (@username, @password, @email, @firstName, @lastName, @role)", connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@role", selectedRole);

                int affectedRows = cmd.ExecuteNonQuery(); // Get the number of affected rows

                // If the insertion was successful, the affectedRows should be greater than 0
                if (affectedRows > 0)
                {
                    MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Clear the form controls
                    ClearFormControls();
                }
                else
                {
                    MessageBox.Show("Signup failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Clear the form controls
                    ClearFormControls();
                }
            }

            // Close the connection
            dbConnection.CloseConnection();

        }

        private bool IsTextboxEmpty(TextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(fieldName + " field cannot be empty.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private bool IsComboBoxEmpty(ComboBox comboBox, string fieldName)
        {
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a " + fieldName + ".", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void ClearFormControls()
        {
            // Clear all TextBox controls
            username_txt.Clear();
            password_txt.Clear();
            email_txt.Clear();
            firstname_txt.Clear();
            lastname_txt.Clear();

            // Clear the ComboBox
            cmbRole.SelectedIndex = -1;

            // Set focus on username_txt
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

        private void back_btn_Click(object sender, EventArgs e)
        {
            Login_Form lg = new Login_Form();

            this.Hide();
            lg.Show();

        }
    }
}
