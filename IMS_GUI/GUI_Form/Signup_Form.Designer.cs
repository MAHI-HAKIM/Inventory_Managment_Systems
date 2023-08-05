namespace IMS_GUI.GUI_Form
{
    partial class Signup_Form
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
            username_txt = new TextBox();
            phoneNo_txt = new TextBox();
            address_txt = new TextBox();
            lastname_txt = new TextBox();
            firstname_txt = new TextBox();
            password_txt = new TextBox();
            deleteUser_txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            signup_btn = new Button();
            delete_btn = new Button();
            back_btn = new Button();
            exit_btn = new Button();
            superad_rd = new Guna.UI2.WinForms.Guna2RadioButton();
            admin_rd = new Guna.UI2.WinForms.Guna2RadioButton();
            employee_rd = new Guna.UI2.WinForms.Guna2RadioButton();
            SuspendLayout();
            // 
            // username_txt
            // 
            username_txt.Location = new Point(266, 81);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(180, 27);
            username_txt.TabIndex = 0;
            // 
            // phoneNo_txt
            // 
            phoneNo_txt.Location = new Point(266, 187);
            phoneNo_txt.Name = "phoneNo_txt";
            phoneNo_txt.Size = new Size(180, 27);
            phoneNo_txt.TabIndex = 1;
            // 
            // address_txt
            // 
            address_txt.Location = new Point(266, 356);
            address_txt.Name = "address_txt";
            address_txt.Size = new Size(180, 27);
            address_txt.TabIndex = 2;
            // 
            // lastname_txt
            // 
            lastname_txt.Location = new Point(266, 306);
            lastname_txt.Name = "lastname_txt";
            lastname_txt.Size = new Size(180, 27);
            lastname_txt.TabIndex = 3;
            // 
            // firstname_txt
            // 
            firstname_txt.Location = new Point(266, 251);
            firstname_txt.Name = "firstname_txt";
            firstname_txt.Size = new Size(180, 27);
            firstname_txt.TabIndex = 4;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(266, 131);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(180, 27);
            password_txt.TabIndex = 5;
            // 
            // deleteUser_txt
            // 
            deleteUser_txt.Location = new Point(602, 98);
            deleteUser_txt.Name = "deleteUser_txt";
            deleteUser_txt.Size = new Size(125, 27);
            deleteUser_txt.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 88);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 7;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 147);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 8;
            label2.Text = "password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 194);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 9;
            label3.Text = "phoneNo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 258);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 10;
            label4.Text = "FirstName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 313);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 11;
            label5.Text = "LastName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(141, 363);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 12;
            label6.Text = "Adress";
            // 
            // signup_btn
            // 
            signup_btn.Location = new Point(266, 406);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(180, 39);
            signup_btn.TabIndex = 13;
            signup_btn.Text = "signup";
            signup_btn.UseVisualStyleBackColor = true;
            signup_btn.Click += signup_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(602, 147);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(125, 29);
            delete_btn.TabIndex = 14;
            delete_btn.Text = "delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(12, 438);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(94, 29);
            back_btn.TabIndex = 15;
            back_btn.Text = "back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.Location = new Point(734, 438);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(94, 29);
            exit_btn.TabIndex = 16;
            exit_btn.Text = "Exit";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // superad_rd
            // 
            superad_rd.AutoSize = true;
            superad_rd.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            superad_rd.CheckedState.BorderThickness = 0;
            superad_rd.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            superad_rd.CheckedState.InnerColor = Color.White;
            superad_rd.CheckedState.InnerOffset = -4;
            superad_rd.Location = new Point(590, 215);
            superad_rd.Name = "superad_rd";
            superad_rd.Size = new Size(112, 24);
            superad_rd.TabIndex = 17;
            superad_rd.Text = "SuperAdmin";
            superad_rd.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            superad_rd.UncheckedState.BorderThickness = 2;
            superad_rd.UncheckedState.FillColor = Color.Transparent;
            superad_rd.UncheckedState.InnerColor = Color.Transparent;
            // 
            // admin_rd
            // 
            admin_rd.AutoSize = true;
            admin_rd.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            admin_rd.CheckedState.BorderThickness = 0;
            admin_rd.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            admin_rd.CheckedState.InnerColor = Color.White;
            admin_rd.CheckedState.InnerOffset = -4;
            admin_rd.Location = new Point(590, 258);
            admin_rd.Name = "admin_rd";
            admin_rd.Size = new Size(74, 24);
            admin_rd.TabIndex = 18;
            admin_rd.Text = "Admin";
            admin_rd.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            admin_rd.UncheckedState.BorderThickness = 2;
            admin_rd.UncheckedState.FillColor = Color.Transparent;
            admin_rd.UncheckedState.InnerColor = Color.Transparent;
            // 
            // employee_rd
            // 
            employee_rd.AutoSize = true;
            employee_rd.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            employee_rd.CheckedState.BorderThickness = 0;
            employee_rd.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            employee_rd.CheckedState.InnerColor = Color.White;
            employee_rd.CheckedState.InnerOffset = -4;
            employee_rd.Location = new Point(590, 306);
            employee_rd.Name = "employee_rd";
            employee_rd.Size = new Size(96, 24);
            employee_rd.TabIndex = 19;
            employee_rd.Text = "Employee";
            employee_rd.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            employee_rd.UncheckedState.BorderThickness = 2;
            employee_rd.UncheckedState.FillColor = Color.Transparent;
            employee_rd.UncheckedState.InnerColor = Color.Transparent;
            // 
            // Signup_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 479);
            Controls.Add(employee_rd);
            Controls.Add(admin_rd);
            Controls.Add(superad_rd);
            Controls.Add(exit_btn);
            Controls.Add(back_btn);
            Controls.Add(delete_btn);
            Controls.Add(signup_btn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deleteUser_txt);
            Controls.Add(password_txt);
            Controls.Add(firstname_txt);
            Controls.Add(lastname_txt);
            Controls.Add(address_txt);
            Controls.Add(phoneNo_txt);
            Controls.Add(username_txt);
            Name = "Signup_Form";
            Text = "Signup_Form";
            Load += Signup_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username_txt;
        private TextBox phoneNo_txt;
        private TextBox address_txt;
        private TextBox lastname_txt;
        private TextBox firstname_txt;
        private TextBox password_txt;
        private TextBox deleteUser_txt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button signup_btn;
        private Button delete_btn;
        private Button back_btn;
        private Button exit_btn;
        private Guna.UI2.WinForms.Guna2RadioButton superad_rd;
        private Guna.UI2.WinForms.Guna2RadioButton admin_rd;
        private Guna.UI2.WinForms.Guna2RadioButton employee_rd;
    }
}