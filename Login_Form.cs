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
        List<Control> controls;

        DBConnection dbConnection = new DBConnection();
        PasswordWithSaltHasher hasher = new PasswordWithSaltHasher();

        public Login_Form()
        {
            InitializeComponent();

            controls = new List<Control> { username_txt, password_txt};

            // Add the KeyDown event handler
            this.KeyDown += Login_Form_KeyDown;
            this.KeyPreview = true;

            // attach the KeyPress event to your TextBox controls
            username_txt.KeyPress += (s, e) => CheckSpace_KeyPress(s, e, "Username");
            password_txt.KeyPress += (s, e) => CheckSpace_KeyPress(s, e, "Password");

            // attach the TextChanged event to your TextBox controls
            username_txt.TextChanged += ResetColor_TextChanged;
            password_txt.TextChanged += ResetColor_TextChanged;
        }

        #region Form Related Control Functions
        private void Login_Form_Load(object sender, EventArgs e)
        {
            // Set focus on username_txt
            username_txt.Focus();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            // Validate all the input fields
            if (IsTextboxEmpty(username_txt, "Username") ||
                IsTextboxEmpty(password_txt, "Password"))
            {
                return;
            }

            // Get user input
            string enteredUsername = username_txt.Text;
            string enteredPassword = password_txt.Text;

            // Retrieve the salt and hashed password from the database
            string storedSalt, storedHashedPassword , firstname , lastname;

            SqlConnection connection = dbConnection.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT FirstName , LastName , Salt, PasswordHash FROM Users WHERE Username = @username", connection))
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
            dbConnection.CloseConnection();

            // Hash the entered password with the retrieved salt
            string hashedEnteredPassword = hasher.HashPassword(enteredPassword, storedSalt);

            // Compare the newly hashed password with the retrieved hashed password
            if (hashedEnteredPassword == storedHashedPassword)
            {
                // If they match, the entered password is correct.
                // Authenticate the user and proceed to the welcome screen.
                Welcome_Form welcomeForm = new Welcome_Form(firstname , lastname);
                welcomeForm.Show();
                this.Hide();
            }
            else
            {
                // If they don't match, the entered password is incorrect.
                MessageBox.Show("Invalid username or password.");
            }
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

        #endregion

        #region Additional User Input Validator Control
        private void Login_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                // Find the current focused textbox
                var focusedTextBox = controls.FirstOrDefault(tb => tb.Focused);

                // Get the index of the current focused textbox
                int currentIndex = controls.IndexOf(focusedTextBox);

                // Calculate the next index
                int nextIndex = e.KeyCode == Keys.Down ? currentIndex + 1 : currentIndex - 1;

                // If the next index is valid, change the focus
                if (nextIndex >= 0 && nextIndex < controls.Count)
                {
                    controls[nextIndex].Focus();
                }

                // Suppress the key press to prevent further processing (like scrolling)
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
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

        #endregion

    }
}
