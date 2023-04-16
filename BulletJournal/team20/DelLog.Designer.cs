namespace team20
{
    partial class DelLog
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
            this.DelLogLab = new System.Windows.Forms.Label();
            this.IndexLab = new System.Windows.Forms.Label();
            this.IndexBox = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DelLogLab
            // 
            this.DelLogLab.AutoSize = true;
            this.DelLogLab.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DelLogLab.Location = new System.Drawing.Point(48, 30);
            this.DelLogLab.Name = "DelLogLab";
            this.DelLogLab.Size = new System.Drawing.Size(93, 32);
            this.DelLogLab.TabIndex = 0;
            this.DelLogLab.Text = "label1";
            // 
            // IndexLab
            // 
            this.IndexLab.AutoSize = true;
            this.IndexLab.Location = new System.Drawing.Point(52, 94);
            this.IndexLab.Name = "IndexLab";
            this.IndexLab.Size = new System.Drawing.Size(55, 12);
            this.IndexLab.TabIndex = 1;
            this.IndexLab.Text = "ID (Index)";
            // 
            // IndexBox
            // 
            this.IndexBox.Location = new System.Drawing.Point(143, 91);
            this.IndexBox.Name = "IndexBox";
            this.IndexBox.Size = new System.Drawing.Size(100, 22);
            this.IndexBox.TabIndex = 2;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(168, 159);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete Log";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // DelLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(350, 285);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.IndexBox);
            this.Controls.Add(this.IndexLab);
            this.Controls.Add(this.DelLogLab);
            this.Name = "DelLog";
            this.Text = "DelLog";
            this.Load += new System.EventHandler(this.DelLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DelLogLab;
        private System.Windows.Forms.Label IndexLab;
        private System.Windows.Forms.TextBox IndexBox;
        private System.Windows.Forms.Button DeleteBtn;
    }
}