
namespace Inventory_Managment_System
{
    partial class SignUp_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lastname_txt = new System.Windows.Forms.TextBox();
            this.firstname_txt = new System.Windows.Forms.TextBox();
            this.phoneNo_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PhoneNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "FirstName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "LastName";
            // 
            // lastname_txt
            // 
            this.lastname_txt.Location = new System.Drawing.Point(224, 289);
            this.lastname_txt.Name = "lastname_txt";
            this.lastname_txt.Size = new System.Drawing.Size(194, 22);
            this.lastname_txt.TabIndex = 5;
            // 
            // firstname_txt
            // 
            this.firstname_txt.Location = new System.Drawing.Point(224, 228);
            this.firstname_txt.Name = "firstname_txt";
            this.firstname_txt.Size = new System.Drawing.Size(194, 22);
            this.firstname_txt.TabIndex = 6;
            // 
            // phoneNo_txt
            // 
            this.phoneNo_txt.Location = new System.Drawing.Point(224, 170);
            this.phoneNo_txt.Name = "phoneNo_txt";
            this.phoneNo_txt.Size = new System.Drawing.Size(194, 22);
            this.phoneNo_txt.TabIndex = 7;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(224, 112);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(194, 22);
            this.password_txt.TabIndex = 8;
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(224, 58);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(194, 22);
            this.username_txt.TabIndex = 9;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.cmbRole.Location = new System.Drawing.Point(570, 89);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(154, 24);
            this.cmbRole.TabIndex = 10;
            // 
            // signup_btn
            // 
            this.signup_btn.Location = new System.Drawing.Point(239, 347);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(159, 47);
            this.signup_btn.TabIndex = 11;
            this.signup_btn.Text = "Sign Up";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            this.signup_btn.Enter += new System.EventHandler(this.signup_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(553, 347);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(94, 43);
            this.exit_btn.TabIndex = 12;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(26, 347);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(159, 47);
            this.back_btn.TabIndex = 13;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // SignUp_Form
            // 
            this.AcceptButton = this.signup_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.phoneNo_txt);
            this.Controls.Add(this.firstname_txt);
            this.Controls.Add(this.lastname_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp_Form";
            this.Text = "SignUp_Form";
            this.Load += new System.EventHandler(this.SignUp_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastname_txt;
        private System.Windows.Forms.TextBox firstname_txt;
        private System.Windows.Forms.TextBox phoneNo_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button back_btn;
    }
}