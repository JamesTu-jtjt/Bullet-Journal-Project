namespace team20
{
    partial class AddProj
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
            this.TagLab = new System.Windows.Forms.Label();
            this.StartLab = new System.Windows.Forms.Label();
            this.EndLab = new System.Windows.Forms.Label();
            this.DesLab = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.DesBox = new System.Windows.Forms.RichTextBox();
            this.TagBox = new System.Windows.Forms.TextBox();
            this.AddProjBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Title.Location = new System.Drawing.Point(104, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(239, 32);
            this.Title.TabIndex = 0;
            this.Title.Text = "Add New Project";
            // 
            // TagLab
            // 
            this.TagLab.AutoSize = true;
            this.TagLab.Location = new System.Drawing.Point(49, 85);
            this.TagLab.Name = "TagLab";
            this.TagLab.Size = new System.Drawing.Size(88, 12);
            this.TagLab.TabIndex = 1;
            this.TagLab.Text = "Project Tag Name";
            // 
            // StartLab
            // 
            this.StartLab.AutoSize = true;
            this.StartLab.Location = new System.Drawing.Point(49, 144);
            this.StartLab.Name = "StartLab";
            this.StartLab.Size = new System.Drawing.Size(50, 12);
            this.StartLab.TabIndex = 3;
            this.StartLab.Text = "Start Date";
            // 
            // EndLab
            // 
            this.EndLab.AutoSize = true;
            this.EndLab.Location = new System.Drawing.Point(49, 201);
            this.EndLab.Name = "EndLab";
            this.EndLab.Size = new System.Drawing.Size(48, 12);
            this.EndLab.TabIndex = 4;
            this.EndLab.Text = "End Date";
            // 
            // DesLab
            // 
            this.DesLab.AutoSize = true;
            this.DesLab.Location = new System.Drawing.Point(49, 261);
            this.DesLab.Name = "DesLab";
            this.DesLab.Size = new System.Drawing.Size(93, 12);
            this.DesLab.TabIndex = 5;
            this.DesLab.Text = "Project Description";
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(173, 137);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 22);
            this.StartDate.TabIndex = 6;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(173, 194);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(200, 22);
            this.EndDate.TabIndex = 7;
            // 
            // DesBox
            // 
            this.DesBox.Location = new System.Drawing.Point(173, 249);
            this.DesBox.Name = "DesBox";
            this.DesBox.Size = new System.Drawing.Size(200, 137);
            this.DesBox.TabIndex = 8;
            this.DesBox.Text = "";
            // 
            // TagBox
            // 
            this.TagBox.Location = new System.Drawing.Point(173, 82);
            this.TagBox.Name = "TagBox";
            this.TagBox.Size = new System.Drawing.Size(200, 22);
            this.TagBox.TabIndex = 2;
            // 
            // AddProjBtn
            // 
            this.AddProjBtn.Location = new System.Drawing.Point(313, 415);
            this.AddProjBtn.Name = "AddProjBtn";
            this.AddProjBtn.Size = new System.Drawing.Size(75, 23);
            this.AddProjBtn.TabIndex = 9;
            this.AddProjBtn.Text = "Add Project";
            this.AddProjBtn.UseVisualStyleBackColor = true;
            this.AddProjBtn.Click += new System.EventHandler(this.AddProjBtn_Click);
            // 
            // AddProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.AddProjBtn);
            this.Controls.Add(this.DesBox);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.DesLab);
            this.Controls.Add(this.EndLab);
            this.Controls.Add(this.StartLab);
            this.Controls.Add(this.TagBox);
            this.Controls.Add(this.TagLab);
            this.Controls.Add(this.Title);
            this.Name = "AddProj";
            this.Text = "AddProj";
            this.Load += new System.EventHandler(this.AddProj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label TagLab;
        private System.Windows.Forms.Label StartLab;
        private System.Windows.Forms.Label EndLab;
        private System.Windows.Forms.Label DesLab;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.RichTextBox DesBox;
        private System.Windows.Forms.TextBox TagBox;
        private System.Windows.Forms.Button AddProjBtn;
    }
}