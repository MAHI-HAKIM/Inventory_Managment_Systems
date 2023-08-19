using Guna.UI2.WinForms;
using IMS_DataAccess;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IMS_GUI
{
    public partial class User_Page : UserControl
    {


        IDBConnection dbConnection;
        User_Mg_control userManagement;

        public User_Page()
        {
            InitializeComponent();

            //textBoxes = new List<Guna2TextBox> { username_txt, password_txt, phoneno_txt, firstname_txt, lastname_txt, address_txt };

            dbConnection = new DBConnection();
            userManagement = new User_Mg_control();
        }
        private void User_Page_Load(object sender, EventArgs e)
        {
            // Retrieve user details from the database
            LoadUser();


            flowLayoutPanel.WrapContents = false; // Prevents horizontal wrapping

            LoadUsersinlabel();
        }
        public void LoadUser()
        {
            string query = "SELECT FirstName, LastName, PhoneNo , Address FROM ContactInfo";

            dbConnection.OpenConnection();

            using (SqlCommand command = new SqlCommand(query, dbConnection.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                user_dgv.DataSource = dataTable;
            }
            dbConnection.CloseConnection();
        }
        // Method to load users and add panels
        private void LoadUsersinlabel()
        {
            //foreach (UserDetail user in userManagement.GetAllUsers())
            //{
            //    //User_Panel userPanel = new User_Panel(user.UserID);

            //    //// Set the properties you've exposed
            //    //userPanel.FullName = user.FirstName + " " + user.LastName;
            //    //userPanel.PhoneNumber = user.PhoneNumber;

            //    //// Hook into the UserDeleted event
            //    //userPanel.UserDeleted += Panel_UserDeleted;

            //    //// Add the shadow panel to the flow panel
            //    ////main_shadowpanel.Controls.Add(userPanel);
            //    //flowLayoutPanel.Controls.Add(userPanel);
            //}
        }
        private void Panel_UserDeleted(object sender, EventArgs e)
        {
            RefreshPage();
        }
        public void RefreshPage()
        {
            // Clear existing controls from the flowLayoutPanel
            flowLayoutPanel.Controls.Clear();

            // Reload users into the panel
            LoadUsersinlabel();
        }
        private void Activity_btn_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                main_tabcontrol.SelectedIndex = 0;
            }
        }
        private void Activity_btn_Enter_1(object sender, EventArgs e)
        {
            Activity_btn.CustomBorderColor = Color.Blue;
        }
        private void Activity_btn_Leave_1(object sender, EventArgs e)
        {
            Activity_btn.CustomBorderColor = Color.White;
        }


        private void add_btn_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                main_tabcontrol.SelectedIndex = 1;
            }
        }
        private void add_btn_Enter_1(object sender, EventArgs e)
        {
            add_btn.CustomBorderColor = Color.Blue;
        }
        private void add_btn_Leave_1(object sender, EventArgs e)
        {
            add_btn.CustomBorderColor = Color.White;
        }


        private void update_btn_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                main_tabcontrol.SelectedIndex = 2;
            }
        }
        private void update_btn_Enter_1(object sender, EventArgs e)
        {
            update_btn.CustomBorderColor = Color.Blue;
        }
        private void update_btn_Leave_1(object sender, EventArgs e)
        {
            update_btn.CustomBorderColor = Color.White;
        }
    }
}
