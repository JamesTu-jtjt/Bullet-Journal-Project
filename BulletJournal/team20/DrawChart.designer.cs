namespace team20
{
    partial class DrawChart
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.StartLab = new System.Windows.Forms.Label();
            this.EndLab = new System.Windows.Forms.Label();
            this.TagBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.radioY = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.radioD = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.yearDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.monthDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dayDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearDataGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthDataGrid)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(120, 49);
            this.StartDate.Margin = new System.Windows.Forms.Padding(4);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(141, 25);
            this.StartDate.TabIndex = 0;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(372, 49);
            this.EndDate.Margin = new System.Windows.Forms.Padding(4);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(140, 25);
            this.EndDate.TabIndex = 1;
            // 
            // StartLab
            // 
            this.StartLab.AutoSize = true;
            this.StartLab.Location = new System.Drawing.Point(45, 58);
            this.StartLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartLab.Name = "StartLab";
            this.StartLab.Size = new System.Drawing.Size(64, 15);
            this.StartLab.TabIndex = 2;
            this.StartLab.Text = "Start Date";
            // 
            // EndLab
            // 
            this.EndLab.AutoSize = true;
            this.EndLab.Location = new System.Drawing.Point(289, 56);
            this.EndLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndLab.Name = "EndLab";
            this.EndLab.Size = new System.Drawing.Size(56, 15);
            this.EndLab.TabIndex = 3;
            this.EndLab.Text = "EndDate";
            // 
            // TagBox
            // 
            this.TagBox.FormattingEnabled = true;
            this.TagBox.Location = new System.Drawing.Point(615, 49);
            this.TagBox.Margin = new System.Windows.Forms.Padding(4);
            this.TagBox.Name = "TagBox";
            this.TagBox.Size = new System.Drawing.Size(160, 23);
            this.TagBox.TabIndex = 4;
            this.TagBox.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "TagLab";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(885, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioY
            // 
            this.radioY.AutoSize = true;
            this.radioY.Checked = true;
            this.radioY.Location = new System.Drawing.Point(48, 96);
            this.radioY.Margin = new System.Windows.Forms.Padding(4);
            this.radioY.Name = "radioY";
            this.radioY.Size = new System.Drawing.Size(52, 19);
            this.radioY.TabIndex = 8;
            this.radioY.TabStop = true;
            this.radioY.Text = "Year";
            this.radioY.UseVisualStyleBackColor = true;
            this.radioY.CheckedChanged += new System.EventHandler(this.radioY_CheckedChanged);
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(292, 96);
            this.radioM.Margin = new System.Windows.Forms.Padding(4);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(63, 19);
            this.radioM.TabIndex = 9;
            this.radioM.Text = "Month";
            this.radioM.UseVisualStyleBackColor = true;
            this.radioM.CheckedChanged += new System.EventHandler(this.radioM_CheckedChanged);
            // 
            // radioD
            // 
            this.radioD.AutoSize = true;
            this.radioD.Location = new System.Drawing.Point(555, 95);
            this.radioD.Margin = new System.Windows.Forms.Padding(4);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(48, 19);
            this.radioD.TabIndex = 10;
            this.radioD.Text = "Day";
            this.radioD.UseVisualStyleBackColor = true;
            this.radioD.CheckedChanged += new System.EventHandler(this.radioD_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(885, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 38);
            this.button3.TabIndex = 14;
            this.button3.Text = "grid";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-4, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(882, 347);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(74, 152);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(892, 379);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(884, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "chart";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.yearDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(884, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "year grid";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // yearDataGrid
            // 
            this.yearDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yearDataGrid.Location = new System.Drawing.Point(3, 0);
            this.yearDataGrid.Name = "yearDataGrid";
            this.yearDataGrid.RowTemplate.Height = 27;
            this.yearDataGrid.Size = new System.Drawing.Size(878, 347);
            this.yearDataGrid.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.monthDataGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(884, 350);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "month grid";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // monthDataGrid
            // 
            this.monthDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthDataGrid.Location = new System.Drawing.Point(3, 0);
            this.monthDataGrid.Name = "monthDataGrid";
            this.monthDataGrid.RowTemplate.Height = 27;
            this.monthDataGrid.Size = new System.Drawing.Size(878, 347);
            this.monthDataGrid.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dayDataGrid);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(884, 350);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "day grid";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dayDataGrid
            // 
            this.dayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayDataGrid.Location = new System.Drawing.Point(0, 0);
            this.dayDataGrid.Name = "dayDataGrid";
            this.dayDataGrid.RowTemplate.Height = 27;
            this.dayDataGrid.Size = new System.Drawing.Size(884, 347);
            this.dayDataGrid.TabIndex = 0;
            // 
            // DrawChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.radioD);
            this.Controls.Add(this.radioM);
            this.Controls.Add(this.radioY);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TagBox);
            this.Controls.Add(this.EndLab);
            this.Controls.Add(this.StartLab);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DrawChart";
            this.Text = "DrawChart";
            this.Load += new System.EventHandler(this.DrawChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yearDataGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthDataGrid)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dayDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label StartLab;
        private System.Windows.Forms.Label EndLab;
        private System.Windows.Forms.ComboBox TagBox;
        private System.Windows.Forms.Label label1;
       // private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioY;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView yearDataGrid;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView monthDataGrid;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dayDataGrid;
    }
}