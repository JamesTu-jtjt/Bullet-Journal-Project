namespace team20
{
    partial class AddLog
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
            this.Title = new System.Windows.Forms.Label();
            this.TimeLab = new System.Windows.Forms.Label();
            this.LogNameLab = new System.Windows.Forms.Label();
            this.DesLab = new System.Windows.Forms.Label();
            this.timeSel = new System.Windows.Forms.DateTimePicker();
            this.TagLab = new System.Windows.Forms.Label();
            this.DesBox = new System.Windows.Forms.RichTextBox();
            this.LogNameBox = new System.Windows.Forms.TextBox();
            this.TagBox = new System.Windows.Forms.ComboBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(42, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(130, 32);
            this.Title.TabIndex = 0;
            this.Title.Text = "Add Log";
            // 
            // TimeLab
            // 
            this.TimeLab.AutoSize = true;
            this.TimeLab.Location = new System.Drawing.Point(46, 98);
            this.TimeLab.Name = "TimeLab";
            this.TimeLab.Size = new System.Drawing.Size(59, 12);
            this.TimeLab.TabIndex = 1;
            this.TimeLab.Text = "Select Time";
            // 
            // LogNameLab
            // 
            this.LogNameLab.AutoSize = true;
            this.LogNameLab.Location = new System.Drawing.Point(51, 141);
            this.LogNameLab.Name = "LogNameLab";
            this.LogNameLab.Size = new System.Drawing.Size(54, 12);
            this.LogNameLab.TabIndex = 2;
            this.LogNameLab.Text = "Log Name";
            // 
            // DesLab
            // 
            this.DesLab.AutoSize = true;
            this.DesLab.Location = new System.Drawing.Point(47, 182);
            this.DesLab.Name = "DesLab";
            this.DesLab.Size = new System.Drawing.Size(58, 12);
            this.DesLab.TabIndex = 3;
            this.DesLab.Text = "Description";
            // 
            // timeSel
            // 
            this.timeSel.Location = new System.Drawing.Point(139, 91);
            this.timeSel.Name = "timeSel";
            this.timeSel.Size = new System.Drawing.Size(200, 22);
            this.timeSel.TabIndex = 4;
            // 
            // TagLab
            // 
            this.TagLab.AutoSize = true;
            this.TagLab.Location = new System.Drawing.Point(82, 302);
            this.TagLab.Name = "TagLab";
            this.TagLab.Size = new System.Drawing.Size(23, 12);
            this.TagLab.TabIndex = 5;
            this.TagLab.Text = "Tag";
            // 
            // DesBox
            // 
            this.DesBox.Location = new System.Drawing.Point(139, 182);
            this.DesBox.Name = "DesBox";
            this.DesBox.Size = new System.Drawing.Size(200, 96);
            this.DesBox.TabIndex = 6;
            this.DesBox.Text = "";
            // 
            // LogNameBox
            // 
            this.LogNameBox.Location = new System.Drawing.Point(139, 141);
            this.LogNameBox.Name = "LogNameBox";
            this.LogNameBox.Size = new System.Drawing.Size(200, 22);
            this.LogNameBox.TabIndex = 7;
            // 
            // TagBox
            // 
            this.TagBox.FormattingEnabled = true;
            this.TagBox.Location = new System.Drawing.Point(139, 302);
            this.TagBox.Name = "TagBox";
            this.TagBox.Size = new System.Drawing.Size(200, 20);
            this.TagBox.TabIndex = 8;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(264, 374);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 9;
            this.Confirm.Text = "Add to Logs";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // AddLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.TagBox);
            this.Controls.Add(this.LogNameBox);
            this.Controls.Add(this.DesBox);
            this.Controls.Add(this.TagLab);
            this.Controls.Add(this.timeSel);
            this.Controls.Add(this.DesLab);
            this.Controls.Add(this.LogNameLab);
            this.Controls.Add(this.TimeLab);
            this.Controls.Add(this.Title);
            this.Name = "AddLog";
            this.Text = "LogEdit";
            this.Load += new System.EventHandler(this.LogEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label TimeLab;
        private System.Windows.Forms.Label LogNameLab;
        private System.Windows.Forms.Label DesLab;
        private System.Windows.Forms.DateTimePicker timeSel;
        private System.Windows.Forms.Label TagLab;
        private System.Windows.Forms.RichTextBox DesBox;
        private System.Windows.Forms.TextBox LogNameBox;
        private System.Windows.Forms.ComboBox TagBox;
        private System.Windows.Forms.Button Confirm;
    }
}