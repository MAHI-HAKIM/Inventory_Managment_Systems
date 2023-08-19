namespace IMS_GUI
{
    partial class Home_Page
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            search_txt = new Guna.UI2.WinForms.Guna2TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel = new FlowLayoutPanel();
            top_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            update_btn = new Guna.UI2.WinForms.Guna2GradientTileButton();
            add_btn = new Guna.UI2.WinForms.Guna2GradientTileButton();
            Activity_btn = new Guna.UI2.WinForms.Guna2GradientTileButton();
            main_shadowpanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            tableLayoutPanel1.SuspendLayout();
            top_panel.SuspendLayout();
            SuspendLayout();
            // 
            // search_txt
            // 
            search_txt.BorderColor = Color.FromArgb(255, 255, 128);
            search_txt.BorderRadius = 10;
            search_txt.CustomizableEdges = customizableEdges1;
            search_txt.DefaultText = "";
            search_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            search_txt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            search_txt.ForeColor = Color.Gray;
            search_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            search_txt.IconLeft = Properties.Resources.magnifying_glass;
            search_txt.Location = new Point(323, 3);
            search_txt.Name = "search_txt";
            search_txt.PasswordChar = '\0';
            search_txt.PlaceholderText = "Search";
            search_txt.SelectedText = "";
            search_txt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            search_txt.Size = new Size(174, 10);
            search_txt.TabIndex = 6;
            search_txt.TextOffset = new Point(5, 0);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(top_panel, 1, 0);
            tableLayoutPanel1.Controls.Add(main_shadowpanel, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.766764F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.23324F));
            tableLayoutPanel1.Size = new Size(1032, 686);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel.BackColor = Color.WhiteSmoke;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(3, 70);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(311, 613);
            flowLayoutPanel.TabIndex = 2;
            // 
            // top_panel
            // 
            top_panel.BackColor = Color.Transparent;
            top_panel.Controls.Add(update_btn);
            top_panel.Controls.Add(add_btn);
            top_panel.Controls.Add(Activity_btn);
            top_panel.Dock = DockStyle.Fill;
            top_panel.FillColor = Color.White;
            top_panel.Location = new Point(320, 3);
            top_panel.Name = "top_panel";
            top_panel.Radius = 5;
            top_panel.ShadowColor = Color.Black;
            top_panel.ShadowDepth = 50;
            top_panel.ShadowShift = 0;
            top_panel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            top_panel.Size = new Size(709, 61);
            top_panel.TabIndex = 8;
            // 
            // update_btn
            // 
            update_btn.CheckedState.CustomBorderColor = Color.Blue;
            update_btn.CheckedState.FillColor = Color.Transparent;
            update_btn.CheckedState.FillColor2 = Color.Transparent;
            update_btn.CustomBorderThickness = new Padding(0, 0, 0, 2);
            update_btn.CustomizableEdges = customizableEdges3;
            update_btn.DisabledState.BorderColor = Color.DarkGray;
            update_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            update_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            update_btn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            update_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            update_btn.Dock = DockStyle.Left;
            update_btn.FillColor = Color.Empty;
            update_btn.FillColor2 = Color.Empty;
            update_btn.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            update_btn.ForeColor = Color.Gray;
            update_btn.HoverState.CustomBorderColor = Color.MediumBlue;
            update_btn.HoverState.FillColor = Color.Transparent;
            update_btn.HoverState.FillColor2 = Color.Transparent;
            update_btn.Location = new Point(290, 0);
            update_btn.Name = "update_btn";
            update_btn.PressedColor = Color.Transparent;
            update_btn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            update_btn.Size = new Size(132, 61);
            update_btn.TabIndex = 17;
            update_btn.Text = "Update";
            // 
            // add_btn
            // 
            add_btn.CheckedState.CustomBorderColor = Color.Blue;
            add_btn.CheckedState.FillColor = Color.Transparent;
            add_btn.CheckedState.FillColor2 = Color.Transparent;
            add_btn.CustomBorderThickness = new Padding(0, 0, 0, 2);
            add_btn.CustomizableEdges = customizableEdges5;
            add_btn.DisabledState.BorderColor = Color.DarkGray;
            add_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            add_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            add_btn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            add_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            add_btn.Dock = DockStyle.Left;
            add_btn.FillColor = Color.Empty;
            add_btn.FillColor2 = Color.Empty;
            add_btn.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            add_btn.ForeColor = Color.Gray;
            add_btn.HoverState.CustomBorderColor = Color.MediumBlue;
            add_btn.HoverState.FillColor = Color.Transparent;
            add_btn.HoverState.FillColor2 = Color.Transparent;
            add_btn.Location = new Point(148, 0);
            add_btn.Name = "add_btn";
            add_btn.PressedColor = Color.Transparent;
            add_btn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            add_btn.Size = new Size(142, 61);
            add_btn.TabIndex = 19;
            add_btn.Text = "Add";
            // 
            // Activity_btn
            // 
            Activity_btn.CheckedState.CustomBorderColor = Color.Blue;
            Activity_btn.CheckedState.FillColor = Color.Transparent;
            Activity_btn.CheckedState.FillColor2 = Color.Transparent;
            Activity_btn.CustomBorderThickness = new Padding(0, 0, 0, 2);
            Activity_btn.CustomizableEdges = customizableEdges7;
            Activity_btn.DisabledState.BorderColor = Color.DarkGray;
            Activity_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Activity_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Activity_btn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Activity_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Activity_btn.Dock = DockStyle.Left;
            Activity_btn.FillColor = Color.Empty;
            Activity_btn.FillColor2 = Color.Empty;
            Activity_btn.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Activity_btn.ForeColor = Color.Gray;
            Activity_btn.HoverState.CustomBorderColor = Color.MediumBlue;
            Activity_btn.HoverState.FillColor = Color.Transparent;
            Activity_btn.HoverState.FillColor2 = Color.Transparent;
            Activity_btn.Location = new Point(0, 0);
            Activity_btn.Name = "Activity_btn";
            Activity_btn.PressedColor = Color.Transparent;
            Activity_btn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Activity_btn.Size = new Size(148, 61);
            Activity_btn.TabIndex = 20;
            Activity_btn.Text = "Activity";
            // 
            // main_shadowpanel
            // 
            main_shadowpanel.BackColor = Color.Transparent;
            main_shadowpanel.Dock = DockStyle.Fill;
            main_shadowpanel.FillColor = Color.White;
            main_shadowpanel.Location = new Point(320, 70);
            main_shadowpanel.Name = "main_shadowpanel";
            main_shadowpanel.Radius = 3;
            main_shadowpanel.ShadowColor = Color.Black;
            main_shadowpanel.ShadowShift = 0;
            main_shadowpanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            main_shadowpanel.Size = new Size(709, 613);
            main_shadowpanel.TabIndex = 9;
            // 
            // Home_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            Controls.Add(tableLayoutPanel1);
            Name = "Home_Page";
            Size = new Size(1032, 686);
            tableLayoutPanel1.ResumeLayout(false);
            top_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox search_txt;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel;
        private Guna.UI2.WinForms.Guna2ShadowPanel top_panel;
        private Guna.UI2.WinForms.Guna2GradientTileButton update_btn;
        private Guna.UI2.WinForms.Guna2ShadowPanel main_shadowpanel;
        private Guna.UI2.WinForms.Guna2GradientTileButton add_btn;
        private Guna.UI2.WinForms.Guna2GradientTileButton Activity_btn;
    }
}
