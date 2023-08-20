using Guna.UI2.WinForms;
using IMS_DataAccess;
using Microsoft.VisualBasic.ApplicationServices;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Repo;
using User_Repo.User_Access;
using User_Repo.User_Repo;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace IMS_GUI.GUI_Pages.Admin_Pages
{
    public partial class UserMng_Page : UserControl
    {
        List<Guna.UI2.WinForms.Guna2TextBox> textboxes;
        List<UserDetails> userDetailsList;
        List<Role> rolesList;

        //Some Class initializing
        IFormValidator validator;
        IDBConnection dbConnection;
        IHandleDbOperation hdo;
        PasswordWithSaltHasher hashing;

        IUser_Accessory accessUser = new User_Accessory();


        private event EventHandler UserDeleted;

        public UserMng_Page()
        {
            InitializeComponent();

            textboxes = new List<Guna.UI2.WinForms.Guna2TextBox> { username_txt, password_txt, phonenumber_txt, firstname_txt, lastname_txt, address_txt };
            rolesList = accessUser.FetchRoles();

            // Initialize the IDatabaseConnection object here
            dbConnection = new DBConnection();
            // Initialize the IFormValidator object here
            validator = new FormValidator();
            // Initialize the PassWordWithSaltHasher object here
            hashing = new PasswordWithSaltHasher();
            // Initialize the HandleDbOperation object here
            hdo = new HandleDbOperation();


            // attach the KeyPress event to your TextBox controls
            username_txt.KeyPress += (sender, e) => validator.CheckSpace_KeyPress(sender as Guna.UI2.WinForms.Guna2TextBox, e, "Username");
            password_txt.KeyPress += (sender, e) => validator.CheckSpace_KeyPress(sender as Guna.UI2.WinForms.Guna2TextBox, e, "Password");

            // attach the TextChanged event to your TextBox controls
            validator.ResetColor_TextChanged(username_txt);
            validator.ResetColor_TextChanged(password_txt);

            //check if any charachter rather than a numeric is entered
            phonenumber_txt.KeyPress += (sender, e) => validator.CheckNumeric_KeyPress(sender as Control, e, "Phone Number");
        }
        private void UserMng_Page_Load(object sender, EventArgs e)
        {
            PopulateRoleComboBox();
            SetDefaultRole();  // set the default role after populating the ComboBox
            Loaddata();
        }

        #region Button Functionality
        private void save_btn_Click_1(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            string phoneNumber = validator.ValidateAndTransformPhoneNumber(phonenumber_txt);
            if (phoneNumber == null) return;

            string enteredAddress = string.IsNullOrWhiteSpace(address_txt.Text) ? "ET" : address_txt.Text;

            string password = password_txt.Text;
            string salt = hashing.GenerateSalt();
            string hashedPassword = hashing.HashPassword(password, salt);


            // Step 3: Use UserRepository to create the user
            try
            {
                // Create a new Contact object
                ContactInfo newContact = new ContactInfo
                {
                    FirstName = firstname_txt.Text,
                    LastName = lastname_txt.Text,
                    PhoneNumber = phoneNumber,
                    Address = enteredAddress
                };

                Role selectedRole = (Role)Role_cmb.SelectedItem;

                // Create a new User object
                User_Repo.User newUser = new User_Repo.User
                {
                    Username = username_txt.Text,
                    PasswordHash = hashedPassword,
                    Salt = salt,
                    IsActive = true, // Assuming the user is active upon creation
                    AssignedDate = DateTime.Now,
                    RoleAssignment = DateTime.Now,
                    RoleId = selectedRole.RoleID, // The function we discussed earlier
                    UserContact = newContact
                };

                // Use UserRepository to create the user
                IUserRepository userRepository = new UserRepository();

                userRepository.CreateUser(newUser);

                // Show a success message
                MessageBox.Show("Successfully signed up!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // validator.ClearFormControls(textboxes);
                Users_Dgv.DataSource = null;
                Users_Dgv.DataSource = accessUser.GetAllUserDetails();
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
        private void add_btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                menu_panel.Visible = true;
                username_txt.Focus();
            }
        }
        private void pnlClose_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                menu_panel.Visible = false;
            }
        }
        private void Users_Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (e.ColumnIndex == delete_U.Index)
            {
                IUserRepository userRepository = new UserRepository();

                try
                {
                    // Get the UserID associated with the clicked row's index
                    int userIdToDelete = userDetailsList[e.RowIndex].UserId;

                    if (!hdo.AnyUserExists())
                    {
                        MessageBox.Show("No users exist to delete.");
                        return;
                    }
                    if (hdo.UserExistsById(userIdToDelete))
                    {
                        DialogResult res;
                        res = MessageBox.Show("Are you sure to delete this user", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (res == DialogResult.Yes)
                        {
                            userRepository.DeleteUser(userIdToDelete);
                            MessageBox.Show("User deleted successfully.");

                            // Raise the UserDeleted event
                            UserDeleted?.Invoke(this, EventArgs.Empty);
                            Loaddata();
                        }
                        else
                        {
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error happened while attemptig to delete,try again later", "Error");
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
            else if (e.ColumnIndex == Edit.Index)
            {
                // Validate and transform phone number
                string phoneNumber = validator.ValidateAndTransformPhoneNumber(phonenumber_txt);
                if (phoneNumber == null) return;
                //MessageBox.Show("Successfully signed up!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string enteredAddress = string.IsNullOrWhiteSpace(address_txt.Text) ? "ET" : address_txt.Text;

                string password = password_txt.Text;
                string salt = hashing.GenerateSalt();
                string hashedPassword = hashing.HashPassword(password, salt);
            }
        }
        #endregion

        #region Access Functions
        private void Loaddata()
        {
            try
            {
                userDetailsList = accessUser.GetAllUserDetails();

                Users_Dgv.AutoGenerateColumns = false;
                Users_Dgv.DataSource = null;
                Users_Dgv.DataSource = userDetailsList;

                // Attach each UserDetails object to the corresponding row's Tag property
                for (int i = 0; i < userDetailsList.Count; i++)
                {
                    Users_Dgv.Rows[i].Tag = userDetailsList[i];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
        private void PopulateRoleComboBox()
        {
            Role_cmb.DataSource = rolesList;
            Role_cmb.DisplayMember = "RoleName";  // This is the text that's displayed
            Role_cmb.ValueMember = "RoleID";      // This is the underlying value
        }
        private void SetDefaultRole()
        {
            Role_cmb.SelectedValue = rolesList.Find(role => role.RoleName == "Staff").RoleID;
        }
        private bool ValidateForm()
        {
            bool isUsernameEmpty = validator.IsTextBoxEmpty(username_txt);
            bool isPasswordEmpty = validator.IsTextBoxEmpty(password_txt);
            bool isPhoneEmpty = validator.IsTextBoxEmpty(phonenumber_txt);
            bool isFirstnameEmpty = validator.IsTextBoxEmpty(firstname_txt);
            bool isLastnameEmpty = validator.IsTextBoxEmpty(lastname_txt);

            // Update label visibility based on textbox content
            username_lbl.Visible = isUsernameEmpty;
            password_lbl.Visible = isPasswordEmpty;
            phonenumber_lbl.Visible = isPhoneEmpty;
            firstname_lbl.Visible = isFirstnameEmpty;
            lastname_lbl.Visible = isLastnameEmpty;

            if (isUsernameEmpty)
                username_txt.Focus();
            else if (isPasswordEmpty)
                password_txt.Focus();
            else if (isPhoneEmpty)
                phonenumber_txt.Focus();
            else if (isFirstnameEmpty)
                firstname_txt.Focus();
            else if (isLastnameEmpty)
                lastname_txt.Focus();

            return !(isUsernameEmpty || isPasswordEmpty || isPhoneEmpty || isFirstnameEmpty || isLastnameEmpty);
        }
        #endregion

        #region Form Features
        private void username_txt_TextChanged(object sender, EventArgs e)
        {
            username_lbl.Visible = false;
        }
        private void password_txt_TextChanged(object sender, EventArgs e)
        {
            password_lbl.Visible = false;
        }
        private void phonenumber_txt_TextChanged(object sender, EventArgs e)
        {
            phonenumber_lbl.Visible=false;
        }
        private void firstname_txt_TextChanged(object sender, EventArgs e)
        {
            firstname_lbl.Visible = false;
        }
        private void lastname_txt_TextChanged(object sender, EventArgs e)
        {
            lastname_lbl.Visible = false;
        }
        #endregion
    }
}
