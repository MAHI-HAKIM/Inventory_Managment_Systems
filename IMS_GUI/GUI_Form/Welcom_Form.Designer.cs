namespace IMS_GUI.GUI_Form
{
    partial class Welcom_Form
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
            labelWelcome = new Label();
            lable_Firstname = new Label();
            label_lastname = new Label();
            userDataGridView = new DataGridView();
            back_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(189, 109);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(50, 20);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "label1";
            // 
            // lable_Firstname
            // 
            lable_Firstname.AutoSize = true;
            lable_Firstname.Location = new Point(294, 109);
            lable_Firstname.Name = "lable_Firstname";
            lable_Firstname.Size = new Size(50, 20);
            lable_Firstname.TabIndex = 1;
            lable_Firstname.Text = "label2";
            // 
            // label_lastname
            // 
            label_lastname.AutoSize = true;
            label_lastname.Location = new Point(399, 109);
            label_lastname.Name = "label_lastname";
            label_lastname.Size = new Size(50, 20);
            label_lastname.TabIndex = 2;
            label_lastname.Text = "label3";
            // 
            // userDataGridView
            // 
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(69, 177);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowHeadersWidth = 51;
            userDataGridView.RowTemplate.Height = 29;
            userDataGridView.Size = new Size(629, 249);
            userDataGridView.TabIndex = 3;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(567, 105);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(94, 29);
            back_btn.TabIndex = 4;
            back_btn.Text = "back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // Welcom_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(back_btn);
            Controls.Add(userDataGridView);
            Controls.Add(label_lastname);
            Controls.Add(lable_Firstname);
            Controls.Add(labelWelcome);
            Name = "Welcom_Form";
            Text = "Welcom_Form";
            Load += Welcom_Form_Load;
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Label lable_Firstname;
        private Label label_lastname;
        private DataGridView userDataGridView;
        private Button back_btn;
    }
}