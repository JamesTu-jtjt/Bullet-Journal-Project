using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace team20
{
    public partial class Content : Form
    {
        public static int Y_index = 100, M_index = 1000, D_index = 10000, P_index = 0;
        public string account, password, name;
        public string[] birthday = new string[3];
        public DateTime date;
        bool relations; 

        public Content(string name) {
            this.account = name;
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection();
        DataSet tlrds = new DataSet();
        BindingSource source = new BindingSource();

        public void Edit(string sqlstr)
        {
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                    "Integrated Security=True";
            cn.Open();
            SqlCommand cmd = new SqlCommand(sqlstr, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void Content_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                    "Integrated Security=True";
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Acc_pass WHERE Account = '"
                + this.account + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            DataRow dr = dt.Rows[0];
            this.name = dr["Name"].ToString();
            this.password = dr["Password"].ToString();
            this.birthday[0] = dr["BirthY"].ToString();
            this.birthday[1] = dr["BirthM"].ToString();
            this.birthday[2] = dr["BirthD"].ToString();
            welcome.Text = "歡迎" + this.name;
            PageLab.Text = "Bullet Journal";
            YearlyLog.Visible = false;
            MonthlyLog.Visible = false;
            DailyLog.Visible = false;
            year_label.Visible = false;
            month_label.Visible = false;
            daily_label.Visible = false;
            AddYearly.Visible = false;
            AddMonthly.Visible = false;
            AddDaily.Visible = false;
            DelYearly.Visible = false;
            DelMonthly.Visible = false;
            DelDaily.Visible = false;
            AccLab.Visible = false;
            AccBox.Visible = false;
            NameLab.Visible = false;
            NameBox.Visible = false;
            BDLab.Visible = false;
            BDPicker1.Visible = false;
            PassLab.Visible = false;
            PassBox.Visible = false;
            UpdateBtn.Visible = false;;
            NameBox.Text = this.name;
            BDPicker1.Value = new DateTime(int.Parse(this.birthday[0]), int.Parse(this.birthday[1]), int.Parse(this.birthday[2]));
            PassBox.Text = this.password;
            ProjectLog.Visible = false;
            DelProjBtn.Visible = false;
            AddProjBtn.Visible = false;
            Refresh.Visible = false;
            projRefresh.Visible = false;
            ProjectList.Visible = false;
            ProjLogLab.Visible = false;
            ProjLab.Visible = false;
        }

        private void editInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageLab.Text = "Account Information";
            YearlyLog.Visible = false;
            MonthlyLog.Visible = false;
            DailyLog.Visible = false;
            year_label.Visible = false;
            month_label.Visible = false;
            daily_label.Visible = false;
            AddYearly.Visible = false;
            AddMonthly.Visible = false;
            AddDaily.Visible = false;
            DelYearly.Visible = false;
            DelMonthly.Visible = false;
            DelDaily.Visible = false;
            AccLab.Visible = true;
            AccBox.Visible = true;
            NameLab.Visible = true;
            NameBox.Visible = true;
            BDLab.Visible = true;
            BDPicker1.Visible = true;
            PassLab.Visible = true;
            PassBox.Visible = true;
            UpdateBtn.Visible = true;
            ProjectLog.Visible = false;
            DelProjBtn.Visible = false;
            AddProjBtn.Visible = false;
            Refresh.Visible = false;
            projRefresh.Visible = false;
            ProjectList.Visible = false;
            ProjLogLab.Visible = false;
            ProjLab.Visible = false;
            AccBox.Text = this.account;
            NameBox.Text = this.name;
            BDPicker1.Value = new DateTime(int.Parse(this.birthday[0]), int.Parse(this.birthday[1]), int.Parse(this.birthday[2]));
            PassBox.Text = this.password;
            this.password = PassBox.Text;
        }

        private void AddYearly_Click(object sender, EventArgs e)
        {
            AddLog addlog = new AddLog("Y", this.account);
            addlog.ShowDialog();
        }

        private void AddMonthly_Click(object sender, EventArgs e)
        {
            AddLog addlog = new AddLog("M", this.account);
            addlog.ShowDialog();
        }

        private void AddDaily_Click(object sender, EventArgs e)
        {
            AddLog addlog = new AddLog("D", this.account);
            addlog.ShowDialog();
        }

        private void AddProjBtn_Click(object sender, EventArgs e)
        {
            AddProj ap = new AddProj("", account);
            ap.ShowDialog();
        }

        private void DelYearly_Click(object sender, EventArgs e)
        {
            DelLog dellog = new DelLog("Y", this.account);
            dellog.ShowDialog();
        }

        private void DelMonthly_Click(object sender, EventArgs e)
        {
            DelLog dellog = new DelLog("M", this.account);
            dellog.ShowDialog();
        }

        private void DelDaily_Click(object sender, EventArgs e)
        {
            DelLog dellog = new DelLog("D", this.account);
            dellog.ShowDialog();
        }
        private void DelProjBtn_Click(object sender, EventArgs e)
        {
            DelLog dellog = new DelLog("P", this.account);
            dellog.ShowDialog();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (relations)
            {
                tlrds = new DataSet();
                YearlyLog.DataSource = null;
                YearlyLog.DataMember = null;
                MonthlyLog.DataSource = null;
                MonthlyLog.DataMember = null;
                DailyLog.DataSource = null;
                DailyLog.DataMember = null;
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                        "Integrated Security=True";
                cn.Open();
                SqlDataAdapter daY = new SqlDataAdapter("SELECT * FROM log_year_data" + account, cn);
                daY.Fill(tlrds, "Yearly");
                SqlDataAdapter daM = new SqlDataAdapter("SELECT * FROM log_month_data" + account, cn);
                daM.Fill(tlrds, "Monthly");
                SqlDataAdapter daD = new SqlDataAdapter("SELECT * FROM log_day_data" + account, cn);
                daD.Fill(tlrds, "Daily");
                cn.Close();
                DataColumn[] dcP = { tlrds.Tables["Monthly"].Columns["Year"], tlrds.Tables["Monthly"].Columns["Month"] };
                DataColumn[] dcC = { tlrds.Tables["Daily"].Columns["Year"], tlrds.Tables["Daily"].Columns["Month"] };
                DataRelation YtoM = new DataRelation(
                    "Yearly-Monthly",
                    tlrds.Tables["Yearly"].Columns["Year"],
                    tlrds.Tables["Monthly"].Columns["Year"],
                    false);
                DataRelation MtoD = new DataRelation("Monthly-Daily", dcP, dcC, false);
                tlrds.Relations.Add(YtoM);
                tlrds.Relations.Add(MtoD);
                source = new BindingSource();
                source.DataSource = tlrds;
                YearlyLog.DataSource = source;
                YearlyLog.DataMember = "Yearly";
                MonthlyLog.DataSource = source;
                MonthlyLog.DataMember = "Yearly.Yearly-Monthly";
                DailyLog.DataSource = source;
                DailyLog.DataMember = "Yearly.Yearly-Monthly.Monthly-Daily";
            }
            else
            {
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                    "Integrated Security=True";
                cn.Open();
                SqlDataAdapter daY = new SqlDataAdapter("SELECT * FROM log_year_data" + account, cn);
                DataTable dtY = new DataTable();
                daY.Fill(dtY);
                SqlDataAdapter daM = new SqlDataAdapter("SELECT * FROM log_month_data" + account, cn);
                DataTable dtM = new DataTable();
                daM.Fill(dtM);
                SqlDataAdapter daD = new SqlDataAdapter("SELECT * FROM log_day_data" + account, cn);
                DataTable dtD = new DataTable();
                daD.Fill(dtD);
                cn.Close();
                YearlyLog.DataSource = dtY;
                MonthlyLog.DataSource = dtM;
                DailyLog.DataSource = dtD;
            }
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relations = false;
            PageLab.Text = "My Logs";
            YearlyLog.Visible = true;
            MonthlyLog.Visible = true;
            DailyLog.Visible = true;
            year_label.Visible = true;
            month_label.Visible = true;
            daily_label.Visible = true;
            AddYearly.Visible = true;
            AddMonthly.Visible = true;
            AddDaily.Visible = true;
            DelYearly.Visible = true;
            DelMonthly.Visible = true;
            DelDaily.Visible = true;
            AccLab.Visible = false;
            AccBox.Visible = false;
            NameLab.Visible = false;
            NameBox.Visible = false;
            BDLab.Visible = false;
            BDPicker1.Visible = false;
            PassLab.Visible = false;
            PassBox.Visible = false;
            UpdateBtn.Visible = false;
            ProjectLog.Visible = false;
            DelProjBtn.Visible = false;
            AddProjBtn.Visible = false;
            Refresh.Visible = true;
            projRefresh.Visible = false;
            ProjectList.Visible = false;
            ProjLogLab.Visible = false;
            ProjLab.Visible = false;
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                    "Integrated Security=True";
            cn.Open();
            SqlDataAdapter daY = new SqlDataAdapter("SELECT * FROM log_year_data" + account, cn);
            DataTable dtY = new DataTable();
            daY.Fill(dtY);
            SqlDataAdapter daM = new SqlDataAdapter("SELECT * FROM log_month_data" + account, cn);
            DataTable dtM = new DataTable();
            daM.Fill(dtM);
            SqlDataAdapter daD = new SqlDataAdapter("SELECT * FROM log_day_data" + account, cn);
            DataTable dtD = new DataTable();
            daD.Fill(dtD);
            cn.Close();
            YearlyLog.DataSource = dtY;
            MonthlyLog.DataSource = dtM;
            DailyLog.DataSource = dtD;
        }

        private void relationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relations = true;
            PageLab.Text = "My Logs";
            YearlyLog.Visible = true;
            MonthlyLog.Visible = true;
            DailyLog.Visible = true;
            year_label.Visible = true;
            month_label.Visible = true;
            daily_label.Visible = true;
            AddYearly.Visible = true;
            AddMonthly.Visible = true;
            AddDaily.Visible = true;
            DelYearly.Visible = true;
            DelMonthly.Visible = true;
            DelDaily.Visible = true;
            AccLab.Visible = false;
            AccBox.Visible = false;
            NameLab.Visible = false;
            NameBox.Visible = false;
            BDLab.Visible = false;
            BDPicker1.Visible = false;
            PassLab.Visible = false;
            PassBox.Visible = false;
            UpdateBtn.Visible = false;
            ProjectLog.Visible = false;
            DelProjBtn.Visible = false;
            AddProjBtn.Visible = false;
            Refresh.Visible = true;
            projRefresh.Visible = false;
            ProjectList.Visible = false;
            ProjLogLab.Visible = false;
            ProjLab.Visible = false;
            tlrds = new DataSet();
            YearlyLog.DataSource = null;
            YearlyLog.DataMember = null;
            MonthlyLog.DataSource = null;
            MonthlyLog.DataMember = null;
            DailyLog.DataSource = null;
            DailyLog.DataMember = null;
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                    "Integrated Security=True";
            cn.Open();
            SqlDataAdapter daY = new SqlDataAdapter("SELECT * FROM log_year_data" + account, cn);
            daY.Fill(tlrds, "Yearly");
            SqlDataAdapter daM = new SqlDataAdapter("SELECT * FROM log_month_data" + account, cn);
            daM.Fill(tlrds, "Monthly");
            SqlDataAdapter daD = new SqlDataAdapter("SELECT * FROM log_day_data" + account, cn);
            daD.Fill(tlrds, "Daily");
            cn.Close();
            DataColumn[] dcP = { tlrds.Tables["Monthly"].Columns["Year"], tlrds.Tables["Monthly"].Columns["Month"] };
            DataColumn[] dcC = { tlrds.Tables["Daily"].Columns["Year"], tlrds.Tables["Daily"].Columns["Month"] };
            DataRelation YtoM = new DataRelation(
                "Yearly-Monthly",
                tlrds.Tables["Yearly"].Columns["Year"],
                tlrds.Tables["Monthly"].Columns["Year"],
                false);
            DataRelation MtoD = new DataRelation("Monthly-Daily", dcP, dcC, false);
            tlrds.Relations.Add(YtoM);
            tlrds.Relations.Add(MtoD);
            source = new BindingSource();
            source.DataSource = tlrds;
            YearlyLog.DataSource = source;
            YearlyLog.DataMember = "Yearly";
            MonthlyLog.DataSource = source;
            MonthlyLog.DataMember = "Yearly.Yearly-Monthly";
            DailyLog.DataSource = source;
            DailyLog.DataMember = "Yearly.Yearly-Monthly.Monthly-Daily";
        }

        private void drawChartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawChart drawchat = new DrawChart(this.account);
            drawchat.ShowDialog();
        }

        private void List_Click(object sender, EventArgs e)
        {
            relations = false;
            PageLab.Text = "My Projects Logs";
            YearlyLog.Visible = false;
            MonthlyLog.Visible = false;
            DailyLog.Visible = false;
            year_label.Visible = false;
            month_label.Visible = false;
            daily_label.Visible = false;
            AddYearly.Visible = false;
            AddMonthly.Visible = false;
            AddDaily.Visible = false;
            DelYearly.Visible = false;
            DelMonthly.Visible = false;
            DelDaily.Visible = false;
            AccLab.Visible = false;
            AccBox.Visible = false;
            NameLab.Visible = false;
            NameBox.Visible = false;
            BDLab.Visible = false;
            BDPicker1.Visible = false;
            PassLab.Visible = false;
            PassBox.Visible = false;
            UpdateBtn.Visible = false;
            Refresh.Visible = false;
            projRefresh.Visible = true;
            ProjectLog.Visible = true;
            DelProjBtn.Visible = true;
            AddProjBtn.Visible = true;
            ProjectList.Visible = true;
            ProjLogLab.Visible = true;
            ProjLab.Visible = true;
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                    "Integrated Security=True";
            cn.Open();
            SqlDataAdapter daP = new SqlDataAdapter("SELECT * FROM proj_data" + account, cn);
            DataTable dtP = new DataTable();
            daP.Fill(dtP);
            SqlDataAdapter daL = new SqlDataAdapter("SELECT * FROM proj_list" + account, cn);
            DataTable dtL = new DataTable();
            cn.Close();
            ProjectLog.DataSource = dtP;
            daL.Fill(dtL);
            ProjectList.DataSource = dtL;
        }

        private void R_Click(object sender, EventArgs e)
        {
            relations = true;
            PageLab.Text = "My Projects Logs";
            YearlyLog.Visible = false;
            MonthlyLog.Visible = false;
            DailyLog.Visible = false;
            year_label.Visible = false;
            month_label.Visible = false;
            daily_label.Visible = false;
            AddYearly.Visible = false;
            AddMonthly.Visible = false;
            AddDaily.Visible = false;
            DelYearly.Visible = false;
            DelMonthly.Visible = false;
            DelDaily.Visible = false;
            AccLab.Visible = false;
            AccBox.Visible = false;
            NameLab.Visible = false;
            NameBox.Visible = false;
            BDLab.Visible = false;
            BDPicker1.Visible = false;
            PassLab.Visible = false;
            PassBox.Visible = false;
            UpdateBtn.Visible = false;
            Refresh.Visible = false;
            projRefresh.Visible = true;
            ProjectLog.Visible = true;
            DelProjBtn.Visible = true;
            AddProjBtn.Visible = true;
            ProjectList.Visible = true;
            ProjLogLab.Visible = true;
            ProjLab.Visible = true;
            tlrds = new DataSet();
            ProjectLog.DataSource = null;
            ProjectLog.DataMember = null;
            ProjectList.DataSource = null;
            ProjectList.DataMember = null;
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                    "Integrated Security=True";
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM proj_data" + account, cn);
            DataTable dt = new DataTable();
            da.Fill(tlrds, "projD");
            ProjectLog.DataSource = dt;
            SqlDataAdapter daP = new SqlDataAdapter("SELECT * FROM proj_list" + account, cn);
            daP.Fill(tlrds, "projL");
            cn.Close();
            DataRelation LtoD = new DataRelation(
                "Project-Logs",
                tlrds.Tables["projL"].Columns["Tag"],
                tlrds.Tables["projD"].Columns["Tag"],
                false);
            tlrds.Relations.Add(LtoD);
            source = new BindingSource();
            source.DataSource = tlrds;
            ProjectList.DataSource = source;
            ProjectList.DataMember = "ProjL";
            ProjectLog.DataSource = source;
            ProjectLog.DataMember = "ProjL.Project-Logs";
            cn.Close();
        }

        private void projRefresh_Click(object sender, EventArgs e)
        {
            if (!relations)
            {
                SqlDataAdapter daP = new SqlDataAdapter("SELECT * FROM proj_data" + account, cn);
                DataTable dtP = new DataTable();
                daP.Fill(dtP);
                ProjectLog.DataSource = dtP;
                SqlDataAdapter daL = new SqlDataAdapter("SELECT * FROM proj_list" + account, cn);
                DataTable dtL = new DataTable();
                daL.Fill(dtL);
                ProjectList.DataSource = dtL;
            }
            else
            {
                tlrds = new DataSet();
                source.DataSource = null;
                ProjectLog.DataSource = null;
                ProjectLog.DataMember = null;
                ProjectList.DataSource = null;
                ProjectList.DataMember = null;
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                        "Integrated Security=True";
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM proj_data" + account, cn);
                DataTable dt = new DataTable();
                da.Fill(tlrds, "projD");
                ProjectLog.DataSource = dt;
                SqlDataAdapter daP = new SqlDataAdapter("SELECT * FROM proj_list" + account, cn);
                daP.Fill(tlrds, "projL");
                cn.Close();
                DataRelation LtoD = new DataRelation(
                    "Project-Logs",
                    tlrds.Tables["projL"].Columns["Tag"],
                    tlrds.Tables["projD"].Columns["Tag"],
                    false);
                tlrds.Relations.Add(LtoD);
                source = new BindingSource();
                source.DataSource = tlrds;
                ProjectList.DataSource = source;
                ProjectList.DataMember = "ProjL";
                ProjectLog.DataSource = source;
                ProjectLog.DataMember = "ProjL.Project-Logs";
            }
            cn.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (PassBox.Text == "" || NameBox.Text == "")
            {
                MessageBox.Show("Data can't be left blank. ");
            }
            else
            {
                try
                {
                    Edit("UPDATE Acc_pass SET Name = '" + NameBox.Text.Replace("'", "''") + "' WHERE Account = '" + this.account + "'");
                    Edit("UPDATE Acc_pass SET BirthY = " + BDPicker1.Value.Year.ToString() + "WHERE Account = '" + this.account + "'");
                    Edit("UPDATE Acc_pass SET BirthM = " + BDPicker1.Value.Month.ToString() + "WHERE Account = '" + this.account + "'");
                    Edit("UPDATE Acc_pass SET BirthD = " + BDPicker1.Value.Day.ToString() + "WHERE Account = '" + this.account + "'");
                    Edit("UPDATE Acc_pass SET Password = '" + PassBox.Text.Replace("'", "''") + "' WHERE Account = '" + this.account + "'");
                    this.name = NameBox.Text;
                    this.birthday[0] = BDPicker1.Value.Year.ToString();
                    this.birthday[1] = BDPicker1.Value.Month.ToString();
                    this.birthday[2] = BDPicker1.Value.Day.ToString();
                    this.password = PassBox.Text;
                }
                catch (Exception)
                {
                    cn.Close();
                    MessageBox.Show("Update Failed. ");
                }
                welcome.Text = "歡迎" + this.name;
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
