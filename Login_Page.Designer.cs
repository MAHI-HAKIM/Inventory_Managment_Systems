
namespace Inventory_Managment_System
{
    partial class Login_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            this.login_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.login_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ForgetPassword = new System.Windows.Forms.LinkLabel();
            this.password_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.username_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.signup_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_elipse
            // 
            this.login_elipse.BorderRadius = 3;
            this.login_elipse.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1090, 6);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(42, 28);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(812, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME";
            // 
            // Login_DragControl
            // 
            this.Login_DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.Login_DragControl.TargetControl = this;
            this.Login_DragControl.UseTransparentDrag = true;
            // 
            // login_btn
            // 
            this.login_btn.BorderRadius = 15;
            this.login_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_btn.FillColor = System.Drawing.Color.Blue;
            this.login_btn.FillColor2 = System.Drawing.Color.Navy;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.HoverState.FillColor = System.Drawing.Color.Navy;
            this.login_btn.HoverState.FillColor2 = System.Drawing.Color.Blue;
            this.login_btn.Location = new System.Drawing.Point(757, 445);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(160, 55);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Login";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // ForgetPassword
            // 
            this.ForgetPassword.AutoSize = true;
            this.ForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPassword.LinkColor = System.Drawing.Color.Navy;
            this.ForgetPassword.Location = new System.Drawing.Point(948, 412);
            this.ForgetPassword.Name = "ForgetPassword";
            this.ForgetPassword.Size = new System.Drawing.Size(114, 17);
            this.ForgetPassword.TabIndex = 7;
            this.ForgetPassword.TabStop = true;
            this.ForgetPassword.Text = "Forget Password";
            // 
            // password_txt
            // 
            this.password_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_txt.DefaultText = "";
            this.password_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_txt.FocusedState.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.password_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_txt.HoverState.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.password_txt.IconLeft = ((System.Drawing.Image)(resources.GetObject("password_txt.IconLeft")));
            this.password_txt.IconRight = global::Inventory_Managment_System.Properties.Resources.hide;
            this.password_txt.Location = new System.Drawing.Point(757, 348);
            this.password_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '\0';
            this.password_txt.PlaceholderText = "Password";
            this.password_txt.SelectedText = "";
            this.password_txt.Size = new System.Drawing.Size(313, 48);
            this.password_txt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.password_txt.TabIndex = 5;
            this.password_txt.TextOffset = new System.Drawing.Point(10, 0);
            this.password_txt.IconRightClick += new System.EventHandler(this.password_txt_IconRightClick);
            this.password_txt.Enter += new System.EventHandler(this.password_txt_Enter);
            this.password_txt.Leave += new System.EventHandler(this.password_txt_Leave);
            // 
            // username_txt
            // 
            this.username_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_txt.DefaultText = "";
            this.username_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_txt.FocusedState.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.username_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username_txt.HoverState.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.username_txt.IconLeft = ((System.Drawing.Image)(resources.GetObject("username_txt.IconLeft")));
            this.username_txt.Location = new System.Drawing.Point(757, 240);
            this.username_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_txt.Name = "username_txt";
            this.username_txt.PasswordChar = '\0';
            this.username_txt.PlaceholderText = "Username";
            this.username_txt.SelectedText = "";
            this.username_txt.Size = new System.Drawing.Size(313, 48);
            this.username_txt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.username_txt.TabIndex = 4;
            this.username_txt.TextOffset = new System.Drawing.Point(10, 0);
            this.username_txt.Enter += new System.EventHandler(this.username_txt_Enter);
            this.username_txt.Leave += new System.EventHandler(this.username_txt_Leave);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Inventory_Managment_System.Properties.Resources.shop;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(842, 54);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(98, 63);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImage = global::Inventory_Managment_System.Properties.Resources.blue_wave;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, -8);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(644, 570);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackgroundImage = global::Inventory_Managment_System.Properties.Resources.analysis_pic;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel2.Location = new System.Drawing.Point(123, 62);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(496, 376);
            this.guna2Panel2.TabIndex = 0;
            // 
            // signup_btn
            // 
            this.signup_btn.BorderRadius = 15;
            this.signup_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signup_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signup_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signup_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signup_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signup_btn.FillColor = System.Drawing.Color.Lime;
            this.signup_btn.FillColor2 = System.Drawing.Color.Green;
            this.signup_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.ForeColor = System.Drawing.Color.White;
            this.signup_btn.HoverState.FillColor = System.Drawing.Color.Green;
            this.signup_btn.HoverState.FillColor2 = System.Drawing.Color.Lime;
            this.signup_btn.Location = new System.Drawing.Point(923, 445);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(147, 55);
            this.signup_btn.TabIndex = 8;
            this.signup_btn.Text = "Signup";
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1139, 557);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.ForgetPassword);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Page";
            this.Load += new System.EventHandler(this.Login_Page_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_Page_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse login_elipse;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox username_txt;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox password_txt;
        private Guna.UI2.WinForms.Guna2GradientButton login_btn;
        private Guna.UI2.WinForms.Guna2DragControl Login_DragControl;
        private System.Windows.Forms.LinkLabel ForgetPassword;
        private Guna.UI2.WinForms.Guna2GradientButton signup_btn;
    }
}