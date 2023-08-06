namespace IMS_GUI.GUI_Form
{
    partial class Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            side_panel = new Panel();
            btn_setting = new Guna.UI2.WinForms.Guna2CircleButton();
            logout_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            btn_userpage = new Guna.UI2.WinForms.Guna2CircleButton();
            btn_homepage = new Guna.UI2.WinForms.Guna2CircleButton();
            logo = new PictureBox();
            Controlbox = new Panel();
            store = new Label();
            Dera = new Label();
            maximize = new Guna.UI2.WinForms.Guna2ControlBox();
            minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            menu_panel = new Panel();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(components);
            side_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            Controlbox.SuspendLayout();
            SuspendLayout();
            // 
            // Elipse
            // 
            Elipse.TargetControl = this;
            // 
            // side_panel
            // 
            side_panel.BackColor = Color.White;
            side_panel.Controls.Add(btn_setting);
            side_panel.Controls.Add(logout_btn);
            side_panel.Controls.Add(btn_userpage);
            side_panel.Controls.Add(btn_homepage);
            side_panel.Controls.Add(logo);
            side_panel.Dock = DockStyle.Left;
            side_panel.Location = new Point(0, 0);
            side_panel.Name = "side_panel";
            side_panel.Size = new Size(64, 712);
            side_panel.TabIndex = 1;
            // 
            // btn_setting
            // 
            btn_setting.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_setting.DisabledState.BorderColor = Color.DarkGray;
            btn_setting.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_setting.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_setting.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_setting.FillColor = Color.Transparent;
            btn_setting.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_setting.ForeColor = Color.White;
            btn_setting.HoverState.FillColor = Color.FromArgb(192, 192, 255);
            btn_setting.HoverState.Image = Properties.Resources.settings_1_;
            btn_setting.Image = Properties.Resources.settings;
            btn_setting.Location = new Point(8, 582);
            btn_setting.Name = "btn_setting";
            btn_setting.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btn_setting.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btn_setting.Size = new Size(48, 48);
            btn_setting.TabIndex = 6;
            btn_setting.Click += btn_setting_Click;
            // 
            // logout_btn
            // 
            logout_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logout_btn.DisabledState.BorderColor = Color.DarkGray;
            logout_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            logout_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            logout_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            logout_btn.FillColor = Color.Transparent;
            logout_btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            logout_btn.ForeColor = Color.White;
            logout_btn.HoverState.FillColor = Color.Transparent;
            logout_btn.HoverState.Image = (Image)resources.GetObject("resource.Image");
            logout_btn.Image = (Image)resources.GetObject("logout_btn.Image");
            logout_btn.Location = new Point(11, 648);
            logout_btn.Name = "logout_btn";
            logout_btn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            logout_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            logout_btn.Size = new Size(48, 48);
            logout_btn.TabIndex = 5;
            logout_btn.Click += logout_btn_Click_1;
            // 
            // btn_userpage
            // 
            btn_userpage.DisabledState.BorderColor = Color.DarkGray;
            btn_userpage.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_userpage.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_userpage.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_userpage.FillColor = Color.Transparent;
            btn_userpage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_userpage.ForeColor = Color.White;
            btn_userpage.HoverState.FillColor = Color.FromArgb(192, 192, 255);
            btn_userpage.HoverState.Image = Properties.Resources.group_2_;
            btn_userpage.Image = (Image)resources.GetObject("btn_userpage.Image");
            btn_userpage.ImageSize = new Size(23, 23);
            btn_userpage.Location = new Point(8, 254);
            btn_userpage.Name = "btn_userpage";
            btn_userpage.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btn_userpage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btn_userpage.Size = new Size(48, 48);
            btn_userpage.TabIndex = 4;
            btn_userpage.Click += user_page_Click;
            // 
            // btn_homepage
            // 
            btn_homepage.DisabledState.BorderColor = Color.DarkGray;
            btn_homepage.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_homepage.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_homepage.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_homepage.FillColor = Color.Transparent;
            btn_homepage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_homepage.ForeColor = Color.White;
            btn_homepage.HoverState.FillColor = Color.FromArgb(192, 192, 255);
            btn_homepage.HoverState.Image = (Image)resources.GetObject("resource.Image1");
            btn_homepage.Image = (Image)resources.GetObject("btn_homepage.Image");
            btn_homepage.Location = new Point(8, 181);
            btn_homepage.Name = "btn_homepage";
            btn_homepage.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btn_homepage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btn_homepage.Size = new Size(48, 48);
            btn_homepage.TabIndex = 3;
            btn_homepage.Click += home_page_Click;
            // 
            // logo
            // 
            logo.Image = Properties.Resources.shop;
            logo.Location = new Point(8, 6);
            logo.Name = "logo";
            logo.Size = new Size(48, 33);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 3;
            logo.TabStop = false;
            // 
            // Controlbox
            // 
            Controlbox.BackColor = Color.White;
            Controlbox.Controls.Add(store);
            Controlbox.Controls.Add(Dera);
            Controlbox.Controls.Add(maximize);
            Controlbox.Controls.Add(minimize);
            Controlbox.Controls.Add(guna2ControlBox1);
            Controlbox.Dock = DockStyle.Top;
            Controlbox.Location = new Point(64, 0);
            Controlbox.Name = "Controlbox";
            Controlbox.Size = new Size(1142, 42);
            Controlbox.TabIndex = 2;
            // 
            // store
            // 
            store.AutoSize = true;
            store.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            store.ForeColor = Color.FromArgb(255, 128, 0);
            store.Location = new Point(72, 11);
            store.Name = "store";
            store.Size = new Size(80, 26);
            store.TabIndex = 6;
            store.Text = "Store";
            // 
            // Dera
            // 
            Dera.AutoSize = true;
            Dera.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Dera.ForeColor = Color.Blue;
            Dera.Location = new Point(7, 11);
            Dera.Name = "Dera";
            Dera.Size = new Size(68, 26);
            Dera.TabIndex = 3;
            Dera.Text = "Dera";
            // 
            // maximize
            // 
            maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            maximize.CustomizableEdges = customizableEdges1;
            maximize.FillColor = Color.Transparent;
            maximize.HoverState.FillColor = Color.FromArgb(128, 128, 255);
            maximize.IconColor = Color.Black;
            maximize.Location = new Point(1030, -1);
            maximize.Name = "maximize";
            maximize.ShadowDecoration.CustomizableEdges = customizableEdges2;
            maximize.Size = new Size(56, 40);
            maximize.TabIndex = 5;
            // 
            // minimize
            // 
            minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            minimize.CustomizableEdges = customizableEdges3;
            minimize.FillColor = Color.Transparent;
            minimize.ForeColor = Color.Black;
            minimize.HoverState.FillColor = Color.FromArgb(192, 192, 255);
            minimize.IconColor = Color.Black;
            minimize.Location = new Point(972, -2);
            minimize.Name = "minimize";
            minimize.ShadowDecoration.CustomizableEdges = customizableEdges4;
            minimize.Size = new Size(56, 41);
            minimize.TabIndex = 4;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.BackColor = Color.Red;
            guna2ControlBox1.CustomizableEdges = customizableEdges5;
            guna2ControlBox1.FillColor = Color.Red;
            guna2ControlBox1.HoverState.FillColor = Color.FromArgb(192, 0, 0);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(1087, -2);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ControlBox1.Size = new Size(56, 41);
            guna2ControlBox1.TabIndex = 3;
            // 
            // menu_panel
            // 
            menu_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menu_panel.BackColor = Color.FromArgb(255, 255, 192);
            menu_panel.ForeColor = Color.Coral;
            menu_panel.Location = new Point(88, 66);
            menu_panel.Name = "menu_panel";
            menu_panel.Size = new Size(1092, 630);
            menu_panel.TabIndex = 3;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = Controlbox;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl2.TargetControl = logo;
            guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2DragControl3
            // 
            guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl3.TargetControl = Dera;
            guna2DragControl3.UseTransparentDrag = true;
            // 
            // guna2DragControl4
            // 
            guna2DragControl4.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl4.TargetControl = store;
            guna2DragControl4.UseTransparentDrag = true;
            // 
            // Admin_Form
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1206, 712);
            Controls.Add(menu_panel);
            Controls.Add(Controlbox);
            Controls.Add(side_panel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeraStore";
            Load += Admin_Form_Load;
            side_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            Controlbox.ResumeLayout(false);
            Controlbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Panel Controlbox;
        private Guna.UI2.WinForms.Guna2ControlBox maximize;
        private Guna.UI2.WinForms.Guna2ControlBox minimize;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Panel side_panel;
        private Label store;
        private Label Dera;
        private Guna.UI2.WinForms.Guna2CircleButton btn_homepage;
        private PictureBox logo;
        private Guna.UI2.WinForms.Guna2CircleButton logout_btn;
        private Guna.UI2.WinForms.Guna2CircleButton btn_userpage;
        private Panel menu_panel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl4;
        private Guna.UI2.WinForms.Guna2CircleButton btn_setting;
    }
}