namespace team20
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Createaccountbtn = new System.Windows.Forms.Button();
            this.account_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Createaccountbtn
            // 
            this.Createaccountbtn.Location = new System.Drawing.Point(529, 263);
            this.Createaccountbtn.Name = "Createaccountbtn";
            this.Createaccountbtn.Size = new System.Drawing.Size(133, 23);
            this.Createaccountbtn.TabIndex = 0;
            this.Createaccountbtn.Text = "Create account";
            this.Createaccountbtn.UseVisualStyleBackColor = true;
            this.Createaccountbtn.Click += new System.EventHandler(this.Createaccountbtn_Click);
            // 
            // account_textbox
            // 
            this.account_textbox.Location = new System.Drawing.Point(492, 73);
            this.account_textbox.Name = "account_textbox";
            this.account_textbox.Size = new System.Drawing.Size(226, 22);
            this.account_textbox.TabIndex = 2;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(492, 144);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(226, 22);
            this.password_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Account :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password :";
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(529, 205);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(133, 23);
            this.loginbtn.TabIndex = 6;
            this.loginbtn.Text = "login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.account_textbox);
            this.Controls.Add(this.Createaccountbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Createaccountbtn;
        private System.Windows.Forms.TextBox account_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginbtn;
    }
}

