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
        }

        DBConnection dbConnection = new DBConnection();

        private void signup_btn_Click(object sender, EventArgs e)
        {
            // Open a connection to the database
            SqlConnection connection = dbConnection.OpenConnection();


            string email = email_txt.Text;         // Retrieve the entered email
            string firstName = firstname_txt.Text; // Retrieve the entered first name
            string lastName = lastname_txt.Text;   // Retrieve the entered last name
            string username = username_txt.Text;    // Retrieve the entered username
            string selectedRole = cmbRole.SelectedItem.ToString();    // Retrieve the selected role

            // Hash and salt the password (as shown earlier)
            PasswordWithSaltHasher hasher = new PasswordWithSaltHasher();
            string password = password_txt.Text;    // Retrieve the entered password

            byte[] hashedPasswordBytes = hasher.Hash(password);
            string hashedPassword = Convert.ToBase64String(hashedPasswordBytes);


            // Insert the new user into the database
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, PasswordHash, Role, Email, FirstName, LastName) VALUES (@username, @passwordHash, @role, @email, @firstName, @lastName)", connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@passwordHash", hashedPassword);
                cmd.Parameters.AddWithValue("@role", selectedRole);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);

                cmd.ExecuteNonQuery();
            }

            // Close the connection
            dbConnection.CloseConnection();
        }
    }
}
