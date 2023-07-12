
namespace Inventory_Managment_System
{
    partial class Welcome_Form
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.label_lastname = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(181, 121);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(17, 26);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = ".";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.Color.Green;
            this.labelFirstName.Location = new System.Drawing.Point(298, 124);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(53, 20);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Name";
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastname.ForeColor = System.Drawing.Color.Green;
            this.label_lastname.Location = new System.Drawing.Point(435, 124);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(77, 20);
            this.label_lastname.TabIndex = 2;
            this.label_lastname.Text = "lastname";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(276, 303);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(211, 78);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "Go Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Welcome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label_lastname);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelWelcome);
            this.Name = "Welcome_Form";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.Button back_btn;
    }
}