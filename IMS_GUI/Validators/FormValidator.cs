using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Repo;
using IMS_DataAccess;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace IMS_GUI
{
    public class FormValidator : IFormValidator
    {
        public bool IsTextBoxEmpty(Control control)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                control.Focus();
                return true;
            }
            return false;
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
                else if (control is Guna.UI2.WinForms.Guna2TextBox)
                {
                    Guna.UI2.WinForms.Guna2TextBox guna2TextBox = (Guna.UI2.WinForms.Guna2TextBox)control;
                    guna2TextBox.Text = string.Empty;
                }
            }
        }
        public void CheckSpace_KeyPress(Guna.UI2.WinForms.Guna2TextBox control, KeyPressEventArgs e, string fieldName)
        {
            if (e.KeyChar == ' ') // ASCII value for space
            {
                e.Handled = true; // Stops the character from being entered into the TextBox
                ((Guna.UI2.WinForms.Guna2TextBox)control).ForeColor = Color.Red; // Change the TextBox's text color to red
                MessageBox.Show(fieldName + " cannot contain spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetColor_TextChanged(control); // Reset color after showing the MessageBox
            }
        }

        public void CheckNumeric_KeyPress(Control control, KeyPressEventArgs e, String fieldName)
        {
            Guna.UI2.WinForms.Guna2TextBox textBox = control as Guna.UI2.WinForms.Guna2TextBox;

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
            string phoneNumber = "";

            // For standard TextBox
            if (control is TextBox textBox)
            {
                phoneNumber = textBox.Text;
            }
            // For Guna2TextBox
            else if (control is Guna.UI2.WinForms.Guna2TextBox guna2TextBox)
            {
                phoneNumber = guna2TextBox.Text;
            }
            else
            {
                // If you get here, it means neither a TextBox nor a Guna2TextBox was passed.
                // Decide how you want to handle this scenario. Maybe return null or throw an exception.
                return null;
            }

            if (!phoneNumber.StartsWith("0") || phoneNumber.Length != 10)
            {
                MessageBox.Show("Phone Number must start with '09' and be 10 digits long.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus(); // This focuses the control, be it TextBox or Guna2TextBox
                return null;
            }

            // Convert phone number to international format
            return "+251 " + phoneNumber.Substring(1);
        }

        public void ResetColor_TextChanged(Guna.UI2.WinForms.Guna2TextBox control)
        {
            if (control is Guna.UI2.WinForms.Guna2TextBox)
            {
                Guna.UI2.WinForms.Guna2TextBox textBox = (Guna.UI2.WinForms.Guna2TextBox)control;
                textBox.ForeColor = SystemColors.WindowText; // Or any default color
            }
        }

        public void SetupNavigation(Form form, List<Guna.UI2.WinForms.Guna2TextBox> controls)
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
