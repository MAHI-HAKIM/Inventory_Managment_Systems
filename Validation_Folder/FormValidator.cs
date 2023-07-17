using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace Inventory_Managment_System
{
    public class FormValidator : IFormValidator
    {
        public bool IsTextBoxEmpty(Control control, string controlName)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                MessageBox.Show(controlName + " cannot be empty.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return true;
            }
            return false;
        }

        public Role? ValidateRoleSelection(bool isSuperAdminChecked, bool isAdminChecked, bool isEmployeeChecked)
        {
            if (isSuperAdminChecked)
            {
                return Role.SuperAdmin;
            }
            else if (isAdminChecked)
            {
                return Role.Admin;
            }
            else if (isEmployeeChecked)
            {
                return Role.Employee;
            }
            else
            {
                MessageBox.Show("Please select a role.", "Role Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public string ValidateRole(RadioButton adminRadio, RadioButton employeeRadio)
        {
            if (adminRadio.Checked)
            {
                return "Admin";
            }
            else if (employeeRadio.Checked)
            {
                return "Employee";
            }
            else
            {
                MessageBox.Show("Please select a role.", "Missing Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        public void ClearFormControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
                else if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Checked = false;
                }
                // If you have more types of controls that can be cleared, add more else if blocks here.
            }
        }
        public void UncheckRadioButtons(List<Control> containers)
        {
            foreach (Control container in containers)
            {
                 if (container is RadioButton)
                 {
                    RadioButton radioButton = (RadioButton)container;
                    radioButton.Checked = false;
                 }
            }
        }
        public void CheckSpace_KeyPress(Control control, KeyPressEventArgs e, string fieldName)
        {
            if (e.KeyChar == ' ') // ASCII value for space
            {
                e.Handled = true; // Stops the character from being entered into the TextBox
                ((TextBox)control).ForeColor = Color.Red; // Change the TextBox's text color to red
                MessageBox.Show(fieldName + " cannot contain spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetColor_TextChanged(control); // Reset color after showing the MessageBox
            }
        }

        public void CheckNumeric_KeyPress(Control control, KeyPressEventArgs e,String fieldName)
        {
            TextBox textBox = control as TextBox;

            if (textBox != null)
            {
                // If the key pressed is not a digit
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // Ignore the key press
                    MessageBox.Show(fieldName + " can only contain digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ResetColor_TextChanged(textBox);
                }
                else
                {
                    textBox.BackColor = SystemColors.Window; // Return to the default color
                }
            }
        }

        public string ValidateAndTransformPhoneNumber(Control control)
        {
            TextBox textBox = control as TextBox;

            if (textBox != null)
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

            return null;
        }

        public void ResetColor_TextChanged(Control control)
        {
            if (control is TextBox)
            {
                TextBox textBox = (TextBox)control;
                textBox.ForeColor = SystemColors.WindowText; // Or any default color
            }
        }
        public void SetupNavigation(Form form, List<Control> controls)
        {
            form.KeyDown += (sender, e) =>
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
            };
        }
    }
}
