namespace IMS_GUI.GUI_Form
{
    partial class Login_Form
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            login_elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            username_txt = new Guna.UI2.WinForms.Guna2TextBox();
            password_txt = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            exit_btn = new Guna.UI2.WinForms.Guna2ControlBox();
            side_panel = new Panel();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            login_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            username_lbl = new Label();
            password_label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // login_elipse
            // 
            login_elipse.BorderRadius = 5;
            login_elipse.TargetControl = this;
            // 
            // username_txt
            // 
            username_txt.Cursor = Cursors.IBeam;
            username_txt.CustomizableEdges = customizableEdges7;
            username_txt.DefaultText = "";
            username_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            username_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            username_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            username_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            username_txt.FocusedState.BorderColor = Color.CornflowerBlue;
            username_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username_txt.ForeColor = Color.FromArgb(64, 64, 64);
            username_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            username_txt.IconLeft = Properties.Resources.user;
            username_txt.Location = new Point(690, 236);
            username_txt.Margin = new Padding(4, 6, 4, 6);
            username_txt.Name = "username_txt";
            username_txt.PasswordChar = '\0';
            username_txt.PlaceholderText = "Username";
            username_txt.SelectedText = "";
            username_txt.ShadowDecoration.CustomizableEdges = customizableEdges8;
            username_txt.Size = new Size(313, 67);
            username_txt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            username_txt.TabIndex = 4;
            username_txt.TextOffset = new Point(10, 0);
            username_txt.TextChanged += username_txt_TextChanged;
            username_txt.Enter += username_txt_Enter;
            username_txt.Leave += username_txt_Leave;
            // 
            // password_txt
            // 
            password_txt.Cursor = Cursors.IBeam;
            password_txt.CustomizableEdges = customizableEdges5;
            password_txt.DefaultText = "";
            password_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            password_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            password_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            password_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            password_txt.FocusedState.BorderColor = Color.CornflowerBlue;
            password_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password_txt.ForeColor = Color.FromArgb(64, 64, 64);
            password_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            password_txt.IconLeft = Properties.Resources.padlock;
            password_txt.IconRight = Properties.Resources.hide;
            password_txt.Location = new Point(690, 349);
            password_txt.Margin = new Padding(4, 6, 4, 6);
            password_txt.Name = "password_txt";
            password_txt.PasswordChar = '\0';
            password_txt.PlaceholderText = "Password";
            password_txt.SelectedText = "";
            password_txt.ShadowDecoration.CustomizableEdges = customizableEdges6;
            password_txt.Size = new Size(313, 67);
            password_txt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            password_txt.TabIndex = 5;
            password_txt.TextOffset = new Point(10, 0);
            password_txt.IconRightClick += password_txt_IconRightClick;
            password_txt.TextChanged += password_txt_TextChanged;
            password_txt.Enter += password_txt_Enter;
            password_txt.Leave += password_txt_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(773, 162);
            label1.Name = "label1";
            label1.Size = new Size(154, 45);
            label1.TabIndex = 6;
            label1.Text = "Welcome";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.shop;
            pictureBox1.Location = new Point(787, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // exit_btn
            // 
            exit_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exit_btn.CustomizableEdges = customizableEdges3;
            exit_btn.FillColor = Color.FromArgb(0, 0, 192);
            exit_btn.HoverState.FillColor = Color.Red;
            exit_btn.IconColor = Color.White;
            exit_btn.Location = new Point(1057, 0);
            exit_btn.Name = "exit_btn";
            exit_btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            exit_btn.Size = new Size(55, 43);
            exit_btn.TabIndex = 8;
            exit_btn.Click += exit_btn_Click;
            // 
            // side_panel
            // 
            side_panel.BackColor = Color.Transparent;
            side_panel.BackgroundImage = Properties.Resources.analysis_pic;
            side_panel.BackgroundImageLayout = ImageLayout.Zoom;
            side_panel.Location = new Point(123, 90);
            side_panel.Name = "side_panel";
            side_panel.Size = new Size(453, 403);
            side_panel.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.blue_wave;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(side_panel);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 670);
            panel1.TabIndex = 10;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(879, 427);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(124, 20);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget Password?";
            // 
            // login_btn
            // 
            login_btn.BorderRadius = 15;
            login_btn.CustomizableEdges = customizableEdges1;
            login_btn.DisabledState.BorderColor = Color.DarkGray;
            login_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            login_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            login_btn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            login_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            login_btn.FillColor = Color.Blue;
            login_btn.FillColor2 = Color.MidnightBlue;
            login_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            login_btn.ForeColor = Color.White;
            login_btn.HoverState.FillColor = Color.MidnightBlue;
            login_btn.HoverState.FillColor2 = Color.Blue;
            login_btn.Location = new Point(764, 483);
            login_btn.Name = "login_btn";
            login_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            login_btn.Size = new Size(146, 59);
            login_btn.TabIndex = 6;
            login_btn.Text = "Login";
            login_btn.MouseDown += login_btn_MouseDown;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.ForeColor = Color.Red;
            username_lbl.Location = new Point(692, 312);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(177, 20);
            username_lbl.TabIndex = 13;
            username_lbl.Text = "Username can't be empty";
            username_lbl.Visible = false;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.ForeColor = Color.Red;
            password_label.Location = new Point(692, 421);
            password_label.Name = "password_label";
            password_label.Size = new Size(172, 20);
            password_label.TabIndex = 14;
            password_label.Text = "Passwrod can't be empty";
            password_label.Visible = false;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1113, 662);
            Controls.Add(password_label);
            Controls.Add(username_lbl);
            Controls.Add(login_btn);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Controls.Add(exit_btn);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Form";
            Load += Login_Form_Load;
            KeyPress += Login_Form_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse login_elipse;
        private Guna.UI2.WinForms.Guna2TextBox username_txt;
        private Guna.UI2.WinForms.Guna2TextBox password_txt;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox exit_btn;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel side_panel;
        private Guna.UI2.WinForms.Guna2GradientButton login_btn;
        private LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Label password_label;
        private Label username_lbl;
    }
}