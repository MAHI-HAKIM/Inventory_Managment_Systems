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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            user_dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)user_dgv).BeginInit();
            SuspendLayout();
            // 
            // user_dgv
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            user_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            user_dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            user_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            user_dgv.ColumnHeadersHeight = 4;
            user_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            user_dgv.DefaultCellStyle = dataGridViewCellStyle6;
            user_dgv.GridColor = Color.FromArgb(231, 229, 255);
            user_dgv.Location = new Point(441, 267);
            user_dgv.Name = "user_dgv";
            user_dgv.RowHeadersVisible = false;
            user_dgv.RowHeadersWidth = 51;
            user_dgv.RowTemplate.Height = 29;
            user_dgv.Size = new Size(496, 334);
            user_dgv.TabIndex = 0;
            user_dgv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            user_dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            user_dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            user_dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            user_dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            user_dgv.ThemeStyle.BackColor = Color.White;
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
            // User_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            Controls.Add(user_dgv);
            Name = "User_Page";
            Size = new Size(984, 646);
            Load += User_Page_Load;
            ((System.ComponentModel.ISupportInitialize)user_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView user_dgv;
    }
}
