namespace IMS_GUI
{
    partial class User_Panel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Panel));
            user_shadowpanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            user_setting = new Guna.UI2.WinForms.Guna2CircleButton();
            userphoneno_lbl = new Label();
            user_img = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            fullName_lbl = new Label();
            btn_setting = new Guna.UI2.WinForms.Guna2CircleButton();
            user_setting_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            print_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            info_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            edit_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            delete_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            Setting_Transition = new Guna.UI2.WinForms.Guna2Transition();
            guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            user_shadowpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)user_img).BeginInit();
            user_setting_panel.SuspendLayout();
            SuspendLayout();
            // 
            // user_shadowpanel
            // 
            user_shadowpanel.BackColor = Color.Transparent;
            user_shadowpanel.Controls.Add(user_setting);
            user_shadowpanel.Controls.Add(userphoneno_lbl);
            user_shadowpanel.Controls.Add(user_img);
            user_shadowpanel.Controls.Add(fullName_lbl);
            user_shadowpanel.Controls.Add(btn_setting);
            guna2Transition1.SetDecoration(user_shadowpanel, Guna.UI2.AnimatorNS.DecorationType.None);
            Setting_Transition.SetDecoration(user_shadowpanel, Guna.UI2.AnimatorNS.DecorationType.None);
            user_shadowpanel.FillColor = Color.White;
            user_shadowpanel.Location = new Point(1, 3);
            user_shadowpanel.Name = "user_shadowpanel";
            user_shadowpanel.Radius = 5;
            user_shadowpanel.ShadowColor = Color.Gray;
            user_shadowpanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            user_shadowpanel.Size = new Size(370, 80);
            user_shadowpanel.TabIndex = 3;
            // 
            // user_setting
            // 
            user_setting.Anchor = AnchorStyles.None;
            guna2Transition1.SetDecoration(user_setting, Guna.UI2.AnimatorNS.DecorationType.None);
            Setting_Transition.SetDecoration(user_setting, Guna.UI2.AnimatorNS.DecorationType.None);
            user_setting.DisabledState.BorderColor = Color.DarkGray;
            user_setting.DisabledState.CustomBorderColor = Color.DarkGray;
            user_setting.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            user_setting.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            user_setting.FillColor = Color.Transparent;
            user_setting.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            user_setting.ForeColor = Color.White;
            user_setting.HoverState.FillColor = Color.Transparent;
            user_setting.HoverState.Image = (Image)resources.GetObject("resource.Image");
            user_setting.Image = (Image)resources.GetObject("user_setting.Image");
            user_setting.ImageSize = new Size(35, 35);
            user_setting.Location = new Point(337, 14);
            user_setting.Name = "user_setting";
            user_setting.ShadowDecoration.CustomizableEdges = customizableEdges1;
            user_setting.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            user_setting.Size = new Size(27, 44);
            user_setting.TabIndex = 10;
            user_setting.MouseDown += user_setting_MouseDown;
            // 
            // userphoneno_lbl
            // 
            userphoneno_lbl.Anchor = AnchorStyles.None;
            userphoneno_lbl.AutoSize = true;
            Setting_Transition.SetDecoration(userphoneno_lbl, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Transition1.SetDecoration(userphoneno_lbl, Guna.UI2.AnimatorNS.DecorationType.None);
            userphoneno_lbl.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            userphoneno_lbl.ForeColor = Color.Lime;
            userphoneno_lbl.Location = new Point(63, 37);
            userphoneno_lbl.Name = "userphoneno_lbl";
            userphoneno_lbl.Size = new Size(119, 23);
            userphoneno_lbl.TabIndex = 9;
            userphoneno_lbl.Text = "phonenumber";
            // 
            // user_img
            // 
            user_img.Anchor = AnchorStyles.None;
            guna2Transition1.SetDecoration(user_img, Guna.UI2.AnimatorNS.DecorationType.None);
            Setting_Transition.SetDecoration(user_img, Guna.UI2.AnimatorNS.DecorationType.None);
            user_img.Image = Properties.Resources.userblue;
            user_img.ImageRotate = 0F;
            user_img.Location = new Point(6, 13);
            user_img.Name = "user_img";
            user_img.ShadowDecoration.CustomizableEdges = customizableEdges2;
            user_img.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            user_img.Size = new Size(51, 40);
            user_img.SizeMode = PictureBoxSizeMode.Zoom;
            user_img.TabIndex = 3;
            user_img.TabStop = false;
            // 
            // fullName_lbl
            // 
            fullName_lbl.Anchor = AnchorStyles.None;
            fullName_lbl.AutoSize = true;
            Setting_Transition.SetDecoration(fullName_lbl, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Transition1.SetDecoration(fullName_lbl, Guna.UI2.AnimatorNS.DecorationType.None);
            fullName_lbl.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            fullName_lbl.ForeColor = SystemColors.HotTrack;
            fullName_lbl.Location = new Point(63, 8);
            fullName_lbl.Name = "fullName_lbl";
            fullName_lbl.Size = new Size(87, 23);
            fullName_lbl.TabIndex = 8;
            fullName_lbl.Text = "Fullname";
            // 
            // btn_setting
            // 
            btn_setting.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            guna2Transition1.SetDecoration(btn_setting, Guna.UI2.AnimatorNS.DecorationType.None);
            Setting_Transition.SetDecoration(btn_setting, Guna.UI2.AnimatorNS.DecorationType.None);
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
            btn_setting.Location = new Point(284, -222);
            btn_setting.Name = "btn_setting";
            btn_setting.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btn_setting.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btn_setting.Size = new Size(48, 30);
            btn_setting.TabIndex = 7;
            // 
            // user_setting_panel
            // 
            user_setting_panel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            user_setting_panel.BackColor = Color.Transparent;
            user_setting_panel.Controls.Add(print_btn);
            user_setting_panel.Controls.Add(info_btn);
            user_setting_panel.Controls.Add(edit_btn);
            user_setting_panel.Controls.Add(delete_btn);
            guna2Transition1.SetDecoration(user_setting_panel, Guna.UI2.AnimatorNS.DecorationType.None);
            Setting_Transition.SetDecoration(user_setting_panel, Guna.UI2.AnimatorNS.DecorationType.None);
            user_setting_panel.FillColor = Color.FromArgb(32, 31, 43);
            user_setting_panel.Location = new Point(131, 90);
            user_setting_panel.Name = "user_setting_panel";
            user_setting_panel.Radius = 10;
            user_setting_panel.ShadowColor = Color.Black;
            user_setting_panel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            user_setting_panel.Size = new Size(237, 67);
            user_setting_panel.TabIndex = 11;
            user_setting_panel.Visible = false;
            // 
            // print_btn
            // 
            print_btn.Anchor = AnchorStyles.Right;
            guna2Transition1.SetDecoration(print_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            Setting_Transition.SetDecoration(print_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            print_btn.DisabledState.BorderColor = Color.DarkGray;
            print_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            print_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            print_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            print_btn.FillColor = Color.Transparent;
            print_btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            print_btn.ForeColor = Color.White;
            print_btn.HoverState.FillColor = Color.Goldenrod;
            print_btn.Image = (Image)resources.GetObject("print_btn.Image");
            print_btn.Location = new Point(73, 7);
            print_btn.Name = "print_btn";
            print_btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            print_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            print_btn.Size = new Size(45, 45);
            print_btn.TabIndex = 11;
            // 
            // info_btn
            // 
            info_btn.Anchor = AnchorStyles.Right;
            guna2Transition1.SetDecoration(info_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            Setting_Transition.SetDecoration(info_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            info_btn.DisabledState.BorderColor = Color.DarkGray;
            info_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            info_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            info_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            info_btn.FillColor = Color.Empty;
            info_btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            info_btn.ForeColor = Color.White;
            info_btn.HoverState.FillColor = Color.LightBlue;
            info_btn.Image = (Image)resources.GetObject("info_btn.Image");
            info_btn.Location = new Point(175, 7);
            info_btn.Name = "info_btn";
            info_btn.ShadowDecoration.CustomizableEdges = customizableEdges5;
            info_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            info_btn.Size = new Size(45, 45);
            info_btn.TabIndex = 10;
            // 
            // edit_btn
            // 
            edit_btn.Anchor = AnchorStyles.Right;
            guna2Transition1.SetDecoration(edit_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            Setting_Transition.SetDecoration(edit_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            edit_btn.DisabledState.BorderColor = Color.DarkGray;
            edit_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            edit_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            edit_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            edit_btn.FillColor = Color.Transparent;
            edit_btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            edit_btn.ForeColor = Color.White;
            edit_btn.HoverState.FillColor = Color.FromArgb(128, 128, 255);
            edit_btn.Image = (Image)resources.GetObject("edit_btn.Image");
            edit_btn.Location = new Point(22, 7);
            edit_btn.Name = "edit_btn";
            edit_btn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            edit_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            edit_btn.Size = new Size(45, 45);
            edit_btn.TabIndex = 9;
            // 
            // delete_btn
            // 
            delete_btn.Anchor = AnchorStyles.Right;
            guna2Transition1.SetDecoration(delete_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            Setting_Transition.SetDecoration(delete_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            delete_btn.DisabledState.BorderColor = Color.DarkGray;
            delete_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            delete_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            delete_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            delete_btn.FillColor = Color.Transparent;
            delete_btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            delete_btn.ForeColor = Color.White;
            delete_btn.HoverState.FillColor = Color.OrangeRed;
            delete_btn.Image = (Image)resources.GetObject("delete_btn.Image");
            delete_btn.Location = new Point(124, 7);
            delete_btn.Name = "delete_btn";
            delete_btn.ShadowDecoration.CustomizableEdges = customizableEdges7;
            delete_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            delete_btn.Size = new Size(45, 45);
            delete_btn.TabIndex = 8;
            delete_btn.MouseDown += delete_btn_MouseDown;
            // 
            // Setting_Transition
            // 
            Setting_Transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.ScaleAndHorizSlide;
            Setting_Transition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = (PointF)resources.GetObject("animation2.BlindCoeff");
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = (PointF)resources.GetObject("animation2.MosaicCoeff");
            animation2.MosaicShift = (PointF)resources.GetObject("animation2.MosaicShift");
            animation2.MosaicSize = 0;
            animation2.Padding = new Padding(30, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = (PointF)resources.GetObject("animation2.ScaleCoeff");
            animation2.SlideCoeff = (PointF)resources.GetObject("animation2.SlideCoeff");
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            Setting_Transition.DefaultAnimation = animation2;
            // 
            // guna2Transition1
            // 
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            guna2Transition1.DefaultAnimation = animation1;
            // 
            // User_Panel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(user_setting_panel);
            Controls.Add(user_shadowpanel);
            Setting_Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            Name = "User_Panel";
            Size = new Size(372, 159);
            Load += User_Panel_Load;
            user_shadowpanel.ResumeLayout(false);
            user_shadowpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)user_img).EndInit();
            user_setting_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel user_shadowpanel;
        private Label userphoneno_lbl;
        private Label fullName_lbl;
        private Guna.UI2.WinForms.Guna2CircleButton btn_setting;
        private Guna.UI2.WinForms.Guna2CirclePictureBox user_img;
        private Guna.UI2.WinForms.Guna2CircleButton user_setting;
        private Guna.UI2.WinForms.Guna2ShadowPanel user_setting_panel;
        private Guna.UI2.WinForms.Guna2CircleButton print_btn;
        private Guna.UI2.WinForms.Guna2CircleButton info_btn;
        private Guna.UI2.WinForms.Guna2CircleButton delete_btn;
        private Guna.UI2.WinForms.Guna2CircleButton edit_btn;
        private Guna.UI2.WinForms.Guna2Transition Setting_Transition;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
    }
}
