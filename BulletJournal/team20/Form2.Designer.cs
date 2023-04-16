namespace team20
{
    partial class Form2
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
            this.account_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.createaccbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.confirm_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // account_textbox
            // 
            this.account_textbox.Location = new System.Drawing.Point(130, 48);
            this.account_textbox.Name = "account_textbox";
            this.account_textbox.Size = new System.Drawing.Size(205, 22);
            this.account_textbox.TabIndex = 2;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(130, 203);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(205, 22);
            this.password_textbox.TabIndex = 3;
            // 
            // createaccbtn
            // 
            this.createaccbtn.Location = new System.Drawing.Point(130, 295);
            this.createaccbtn.Name = "createaccbtn";
            this.createaccbtn.Size = new System.Drawing.Size(101, 23);
            this.createaccbtn.TabIndex = 4;
            this.createaccbtn.Text = "Create";
            this.createaccbtn.UseVisualStyleBackColor = true;
            this.createaccbtn.Click += new System.EventHandler(this.createaccbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm password :";
            // 
            // confirm_textbox
            // 
            this.confirm_textbox.Location = new System.Drawing.Point(130, 251);
            this.confirm_textbox.Name = "confirm_textbox";
            this.confirm_textbox.Size = new System.Drawing.Size(205, 22);
            this.confirm_textbox.TabIndex = 6;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(130, 97);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(205, 22);
            this.name_textbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birthday :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 343);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.confirm_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createaccbtn);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.account_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox account_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button createaccbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirm_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}