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

        public SignUp_Form()
        {
            InitializeComponent();

            // Initialize the Control list here
            controls = new List<Control> { username_txt, password_txt, phoneNo_txt, firstname_txt, lastname_txt };

            // Set KeyPreview to true
            this.KeyPreview = true;

            // Add the KeyDown event handler
            this.KeyDown += SignUp_Form_KeyDown;

            // Add a Shown event handler
            this.Shown += SignUp_Form_Load;

            // attach the KeyPress event to your TextBox controls
            username_txt.KeyPress += (s, e) => CheckSpace_KeyPress(s, e, "Username");
            password_txt.KeyPress += (s, e) => CheckSpace_KeyPress(s, e, "Password");
            phoneNo_txt.KeyPress += (s, e) => CheckSpace_KeyPress(s, e, "Phone Number");

           

            // attach the TextChanged event to your TextBox controls
            username_txt.TextChanged += ResetColor_TextChanged;
            password_txt.TextChanged += ResetColor_TextChanged;
            phoneNo_txt.TextChanged += ResetColor_TextChanged;

            //check if any charachter rather than a numeric is entered
            phoneNo_txt.KeyPress += phoneNumber_txt_KeyPress;
        }

        DBConnection dbConnection = new DBConnection();

        private void SignUp_Form_Load(object sender, EventArgs e)
        {
            // Set focus on username_txt
            username_txt.Focus();

        }

        private bool IsAdminExists()
        {
            // Open a connection to the database
            SqlConnection connection = dbConnection.OpenConnection();

            using (SqlCommand cmd = new SqlCommand("sp_CheckAdminExists", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                int adminCount = (int)cmd.ExecuteScalar();

                // Close the connection
                dbConnection.CloseConnection();

                return adminCount > 0;
            }
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            // Validate all the input fields
            if (IsTextboxEmpty(username_txt, "Username") ||
                IsTextboxEmpty(password_txt, "Password") ||
                IsTextboxEmpty(phoneNo_txt, "Phone Number") ||
                IsTextboxEmpty(firstname_txt, "First Name") ||
                IsTextboxEmpty(lastname_txt, "Last Name") ||
                IsComboBoxEmpty(cmbRole, "role"))
            {
                return;
            }

            // Retrieve all the input values
            string firstName = firstname_txt.Text;
            string lastName = lastname_txt.Text;
            string username = username_txt.Text;
            string password = password_txt.Text;
            // Validate and transform the phone number
            string phoneNo = ValidateAndTransformPhoneNumber(phoneNo_txt);

            if (phoneNo == null)
            {
                return;
            }
            string selectedRole = cmbRole.SelectedItem.ToString();

            // Open a connection to the database
            SqlConnection connection = dbConnection.OpenConnection();

            // Insert the new user into the database
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, Password, PhoneNo, FirstName, LastName, Role) VALUES (@username, @password, @PhoneNo, @firstName, @lastName, @role)", connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@PhoneNo", phoneNo);
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

        private void SignUp_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                // Check if the button is currently focused
                if (signup_btn.Focused)
                {
                    if (e.KeyCode == Keys.Down)
                    {
                        // Wrap back to the first TextBox
                        controls[0].Focus();
                    }
                    else if (e.KeyCode == Keys.Up)
                    {
                        // Focus the last TextBox
                        controls[controls.Count - 1].Focus();
                    }
                }
                else
                {
                    // Find the current focused TextBox
                    var focusedTextBox = controls.FirstOrDefault(tb => tb.Focused);

                    // Get the index of the current focused TextBox
                    int currentIndex = controls.IndexOf(focusedTextBox);

                    // Calculate the next index
                    int nextIndex = e.KeyCode == Keys.Down ? currentIndex + 1 : currentIndex - 1;

                    // If the next index is valid, change the focus
                    if (nextIndex >= 0 && nextIndex < controls.Count)
                    {
                        controls[nextIndex].Focus();
                    }
                    else if (e.KeyCode == Keys.Down && nextIndex >= controls.Count)
                    {
                        // If the down arrow key was pressed and we're at the end of the TextBoxes list,
                        // move the focus to the button
                        signup_btn.Focus();
                    }
                    else if (e.KeyCode == Keys.Up && nextIndex < 0)
                    {
                        // If the up arrow key was pressed and we're at the start of the TextBoxes list,
                        // wrap around to the button
                        signup_btn.Focus();
                    }
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

        private void phoneNumber_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the key pressed is not a digit
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press
                MessageBox.Show("Phone number can only contain digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetColor_TextChanged(sender, e); // Reset color after showing the MessageBox
            }
            else
            {
                phoneNo_txt.BackColor = SystemColors.Window; // Return to the default color
            }
        }

        private string ValidateAndTransformPhoneNumber(TextBox textBox)
        {
            string phoneNumber = textBox.Text;

            if (!phoneNumber.StartsWith("0") || phoneNumber.Length != 10)
            {
                MessageBox.Show("Phone Number must start with '09' and be 10 digits long.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return null;
            }

            // Convert phone number to international format
            return "+251 " + phoneNumber.Substring(1);
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

        private bool IsComboBoxEmpty(ComboBox comboBox, string fieldName)
        {
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a " + fieldName + ".", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox.Focus(); // Set the focus to this combobox
                return true;
            }
            return false;
        }

        private void ClearFormControls()
        {
            // Clear all TextBox controls
            username_txt.Clear();
            password_txt.Clear();
            phoneNo_txt.Clear();
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
