namespace IMS_GUI
{
    partial class User_Page
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            user_dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            flowLayoutPanel = new FlowLayoutPanel();
            search_txt = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)user_dgv).BeginInit();
            SuspendLayout();
            // 
            // user_dgv
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            user_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            user_dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            user_dgv.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            user_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            user_dgv.ColumnHeadersHeight = 4;
            user_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            user_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            user_dgv.GridColor = Color.FromArgb(231, 229, 255);
            user_dgv.Location = new Point(480, 220);
            user_dgv.Name = "user_dgv";
            user_dgv.RowHeadersVisible = false;
            user_dgv.RowHeadersWidth = 51;
            user_dgv.RowTemplate.Height = 29;
            user_dgv.Size = new Size(609, 387);
            user_dgv.TabIndex = 0;
            user_dgv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            user_dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            user_dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            user_dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            user_dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            user_dgv.ThemeStyle.BackColor = SystemColors.ActiveCaption;
            user_dgv.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            user_dgv.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            user_dgv.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            user_dgv.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            user_dgv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            user_dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            user_dgv.ThemeStyle.HeaderStyle.Height = 4;
            user_dgv.ThemeStyle.ReadOnly = false;
            user_dgv.ThemeStyle.RowsStyle.BackColor = Color.White;
            user_dgv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            user_dgv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            user_dgv.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            user_dgv.ThemeStyle.RowsStyle.Height = 29;
            user_dgv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            user_dgv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel.BackColor = Color.WhiteSmoke;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(28, 220);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(401, 387);
            flowLayoutPanel.TabIndex = 1;
            // 
            // search_txt
            // 
            search_txt.BorderColor = Color.FromArgb(224, 224, 224);
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
            search_txt.Location = new Point(480, 150);
            search_txt.Name = "search_txt";
            search_txt.PasswordChar = '\0';
            search_txt.PlaceholderText = "Search";
            search_txt.SelectedText = "";
            search_txt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            search_txt.Size = new Size(271, 49);
            search_txt.TabIndex = 3;
            search_txt.TextOffset = new Point(5, 0);
            // 
            // User_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(search_txt);
            Controls.Add(flowLayoutPanel);
            Controls.Add(user_dgv);
            Name = "User_Page";
            Size = new Size(1092, 630);
            Load += User_Page_Load;
            ((System.ComponentModel.ISupportInitialize)user_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView user_dgv;
        private FlowLayoutPanel flowLayoutPanel;
        private Guna.UI2.WinForms.Guna2TextBox search_txt;
    }
}
