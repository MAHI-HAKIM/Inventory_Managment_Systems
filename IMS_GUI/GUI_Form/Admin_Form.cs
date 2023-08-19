using IMS_GUI.GUI_Pages.Admin_Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_GUI.GUI_Form
{
    public partial class Admin_Form : Form
    {
        private List<Guna.UI2.WinForms.Guna2CircleButton> buttons;

        public Admin_Form()
        {
            InitializeComponent();
            this.buttons = new List<Guna.UI2.WinForms.Guna2CircleButton> { btn_homepage, btn_userpage, btn_setting };
        }
        private void Admin_Form_Load(object sender, EventArgs e)
        {
            ShowUserControl(typeof(UserMng_Page));

        }

        private void ShowUserControl(Type userControlType)
        {
            // Clear any existing controls
            menu_panel.Controls.Clear();

            // Create an instance of the user control
            UserControl control = Activator.CreateInstance(userControlType) as UserControl;

            // Add the user control to the panel
            if (control != null)
            {
                control.Dock = DockStyle.Fill;
                menu_panel.Controls.Add(control);
            }
        }
        // Method to activate a specific button
        private void ActivateButton(Guna.UI2.WinForms.Guna2CircleButton btn, Image image)
        {
            btn.FillColor = Color.FromArgb(192, 192, 255);
            btn.Image = image;
        }
        // Method to reset all buttons to default state
        private void ResetAllButtons()
        {
            foreach (Guna.UI2.WinForms.Guna2CircleButton btn in buttons)
            {
                btn.FillColor = Color.Transparent; // Set to default fillcolor
            }
            btn_homepage.Image = Properties.Resources.dashboard;
            btn_userpage.Image = Properties.Resources.group__3_;
            btn_setting.Image = Properties.Resources.settings;
        }

        private void btn_userpage_MouseDown(object sender, MouseEventArgs e)
        {
            // Respond only to the left mouse button
            if (e.Button == MouseButtons.Left)
            {
                ResetAllButtons();
                ActivateButton(btn_userpage, Properties.Resources.group_2_);
                ShowUserControl(typeof(UserMng_Page));
            }

        }

        private void btn_homepage_MouseDown(object sender, MouseEventArgs e)
        {
            // Respond only to the left mouse button
            if (e.Button == MouseButtons.Left)
            {
                ResetAllButtons();
                ActivateButton(btn_homepage, Properties.Resources.dashboard__1_);
                ShowUserControl(typeof(UserMng_Page));
            }


        }

        private void btn_setting_MouseDown(object sender, MouseEventArgs e)
        { // Respond only to the left mouse button
            if (e.Button == MouseButtons.Left)
            {
                Signup_Form sg = new Signup_Form();
                this.Hide();
                sg.Show();
            }

        }

        private void logout_btn_MouseDown(object sender, MouseEventArgs e)
        {
            // Respond only to the left mouse button
            if (e.Button == MouseButtons.Left)
            {
                Login_Form lg = new Login_Form();
                //Welcom_Form welcomeForm = new Welcom_Form();

                lg.FormClosed += (s, args) => this.Close();
                this.Hide();
                lg.Show();
            }
        }
    }
}
