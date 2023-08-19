using IMS_DataAccess;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Repo;

namespace IMS_GUI
{
    public partial class User_Panel : UserControl
    {
        private int baseHeight; // Field to store the base height
        private bool isSettingsPanelVisible = false; // Field to track visibility of the user_setting_panel
        private int userID;
        public event EventHandler UserDeleted;

        IDBConnection dbConnection;
        IHandleDbOperation hdo;
        User_Page userpage;
        public User_Panel(int UserID)
        {
            InitializeComponent();
            this.userID = UserID;

            // Initialize the IDatabaseConnection object here
            dbConnection = new DBConnection();
            // Initialize the HandleDbOperation object here
            hdo = new HandleDbOperation();


            userpage = new User_Page();
        }

        public string FullName
        {
            get { return fullName_lbl.Text; }
            set { fullName_lbl.Text = value; }
        }
        public string PhoneNumber
        {
            get { return userphoneno_lbl.Text; }
            set { userphoneno_lbl.Text = value; }
        }

        private void User_Panel_Load(object sender, EventArgs e)
        {
            // Store the initial height (without the user_setting_panel)
            baseHeight = this.Height - user_setting_panel.Height;

            user_setting_panel.Visible = false;
            this.Height = baseHeight; // Set the initial height to the base height
        }

        private void user_setting_MouseDown(object sender, MouseEventArgs e)
        {
            // Respond only to the left mouse button
            if (e.Button == MouseButtons.Left)
            {
                if (isSettingsPanelVisible)
                {
                    user_setting.Image = Properties.Resources.menu_user;

                    // Hide the user_setting_panel
                    user_setting_panel.Visible = false;

                    // Reset the height of the User_Panel to the base height (without the user_setting_panel)
                    this.Height = baseHeight;

                    // Set the flag to false as the settings panel is now hidden
                    isSettingsPanelVisible = false;
                }
                else
                {
                    user_setting.Image = Properties.Resources.menu_user1;

                    // Show the user_setting_panel
                    user_setting_panel.Visible = true;

                    // Adjust the height of the User_Panel to include the user_setting_panel
                    this.Height = baseHeight + user_setting_panel.Height;

                    // Set the flag to true as the settings panel is now visible
                    isSettingsPanelVisible = true;
                }
            }
        }

        private void delete_btn_MouseDown(object sender, MouseEventArgs e)
        {
            // Respond only to the left mouse button
            if (e.Button == MouseButtons.Left)
            {
                IUserRepository userRepository = new UserRepository();

                try
                {
                    if (!hdo.AnyUserExists())
                    {
                        MessageBox.Show("No users exist to delete.");
                        return;
                    }
                    if (hdo.UserExistsById(userID))
                    {
                        DialogResult res;
                        res = MessageBox.Show("Are you sure to delete this user", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (res == DialogResult.Yes)
                        {
                            userRepository.DeleteUser(userID);
                            MessageBox.Show("User deleted successfully.");

                            // Raise the UserDeleted event
                            UserDeleted?.Invoke(this, EventArgs.Empty);

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
        }
    }
}
