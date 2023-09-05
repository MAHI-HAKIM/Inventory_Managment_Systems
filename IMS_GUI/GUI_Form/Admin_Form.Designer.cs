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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
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
            maximize_btn = new Guna.UI2.WinForms.Guna2ControlBox();
            minimize_btn = new Guna.UI2.WinForms.Guna2ControlBox();
            exit_btn = new Guna.UI2.WinForms.Guna2ControlBox();
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
            side_panel.Size = new Size(65, 734);
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
            btn_setting.Location = new Point(8, 604);
            btn_setting.Name = "btn_setting";
            btn_setting.ShadowDecoration.CustomizableEdges = customizableEdges11;
            btn_setting.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btn_setting.Size = new Size(48, 48);
            btn_setting.TabIndex = 6;
            btn_setting.MouseDown += btn_setting_MouseDown;
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
            logout_btn.Location = new Point(11, 670);
            logout_btn.Name = "logout_btn";
            logout_btn.ShadowDecoration.CustomizableEdges = customizableEdges12;
            logout_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            logout_btn.Size = new Size(48, 48);
            logout_btn.TabIndex = 5;
            logout_btn.MouseDown += logout_btn_MouseDown;
            // 
            // btn_userpage
            // 
            btn_userpage.Anchor = AnchorStyles.Top;
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
            btn_userpage.Location = new Point(9, 199);
            btn_userpage.Name = "btn_userpage";
            btn_userpage.ShadowDecoration.CustomizableEdges = customizableEdges13;
            btn_userpage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btn_userpage.Size = new Size(48, 48);
            btn_userpage.TabIndex = 4;
            btn_userpage.MouseDown += btn_userpage_MouseDown;
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
            btn_homepage.Location = new Point(9, 112);
            btn_homepage.Name = "btn_homepage";
            btn_homepage.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btn_homepage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btn_homepage.Size = new Size(48, 48);
            btn_homepage.TabIndex = 3;
            btn_homepage.MouseDown += btn_homepage_MouseDown;
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
            Controlbox.Controls.Add(maximize_btn);
            Controlbox.Controls.Add(minimize_btn);
            Controlbox.Controls.Add(exit_btn);
            Controlbox.Dock = DockStyle.Top;
            Controlbox.Location = new Point(65, 0);
            Controlbox.Name = "Controlbox";
            Controlbox.Size = new Size(1194, 42);
            Controlbox.TabIndex = 2;
            // 
            // store
            // 
            store.AutoSize = true;
            store.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            store.ForeColor = Color.FromArgb(255, 128, 0);
            store.Location = new Point(67, 9);
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
            Dera.Location = new Point(2, 9);
            Dera.Name = "Dera";
            Dera.Size = new Size(68, 26);
            Dera.TabIndex = 3;
            Dera.Text = "Dera";
            // 
            // maximize_btn
            // 
            maximize_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximize_btn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            maximize_btn.CustomizableEdges = customizableEdges15;
            maximize_btn.FillColor = Color.Transparent;
            maximize_btn.HoverState.FillColor = Color.FromArgb(128, 128, 255);
            maximize_btn.IconColor = Color.Black;
            maximize_btn.Location = new Point(1083, -1);
            maximize_btn.Name = "maximize_btn";
            maximize_btn.ShadowDecoration.CustomizableEdges = customizableEdges16;
            maximize_btn.Size = new Size(56, 40);
            maximize_btn.TabIndex = 5;
            // 
            // minimize_btn
            // 
            minimize_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimize_btn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            minimize_btn.CustomizableEdges = customizableEdges17;
            minimize_btn.FillColor = Color.Transparent;
            minimize_btn.ForeColor = Color.Black;
            minimize_btn.HoverState.FillColor = Color.FromArgb(192, 192, 255);
            minimize_btn.IconColor = Color.Black;
            minimize_btn.Location = new Point(1023, -2);
            minimize_btn.Name = "minimize_btn";
            minimize_btn.ShadowDecoration.CustomizableEdges = customizableEdges18;
            minimize_btn.Size = new Size(56, 41);
            minimize_btn.TabIndex = 4;
            // 
            // exit_btn
            // 
            exit_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exit_btn.BackColor = Color.Red;
            exit_btn.CustomizableEdges = customizableEdges19;
            exit_btn.FillColor = Color.Red;
            exit_btn.HoverState.FillColor = Color.FromArgb(192, 0, 0);
            exit_btn.IconColor = Color.White;
            exit_btn.Location = new Point(1139, -2);
            exit_btn.Name = "exit_btn";
            exit_btn.ShadowDecoration.CustomizableEdges = customizableEdges20;
            exit_btn.Size = new Size(56, 41);
            exit_btn.TabIndex = 3;
            // 
            // menu_panel
            // 
            menu_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menu_panel.BackColor = Color.White;
            menu_panel.ForeColor = Color.Coral;
            menu_panel.Location = new Point(70, 48);
            menu_panel.Name = "menu_panel";
            menu_panel.Size = new Size(1177, 674);
            menu_panel.TabIndex = 3;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.DragStartTransparencyValue = 1D;
            guna2DragControl1.TargetControl = Controlbox;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl2.DragStartTransparencyValue = 1D;
            guna2DragControl2.TargetControl = logo;
            guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2DragControl3
            // 
            guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl3.DragStartTransparencyValue = 1D;
            guna2DragControl3.TargetControl = Dera;
            guna2DragControl3.UseTransparentDrag = true;
            // 
            // guna2DragControl4
            // 
            guna2DragControl4.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl4.DragStartTransparencyValue = 1D;
            guna2DragControl4.TargetControl = store;
            guna2DragControl4.UseTransparentDrag = true;
            // 
            // Admin_Form
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1259, 734);
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
        private Guna.UI2.WinForms.Guna2ControlBox maximize_btn;
        private Guna.UI2.WinForms.Guna2ControlBox minimize_btn;
        private Guna.UI2.WinForms.Guna2ControlBox exit_btn;
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