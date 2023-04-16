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
    public partial class AddProj : Form
    {
        string account, proj;
        public AddProj(string proj, string acc)
        {
            this.proj = proj;
            this.account = acc;
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection();

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

        private void AddProj_Load(object sender, EventArgs e)
        {
            TagBox.Text = proj;
            if (proj != "")
            {
                TagBox.ReadOnly = true;
            }
            StartDate.Format = DateTimePickerFormat.Custom;
            StartDate.CustomFormat = "yyyy MM";
            StartDate.ShowUpDown = true;
            EndDate.Format = DateTimePickerFormat.Custom;
            EndDate.CustomFormat = "yyyy MM";
            EndDate.ShowUpDown = true;
        }

        private void AddProjBtn_Click(object sender, EventArgs e)
        {
            if (TagBox.Text == "")
            {
                MessageBox.Show("Please fill in Project Name. ");
            }
            else if (StartDate.Value.Date > EndDate.Value.Date)
            {
                MessageBox.Show("Invalid start and end dates. ");
            }
            else
            {
                try
                {
                    Edit("INSERT INTO proj_list" + this.account.Replace("'", "''") +
                    "(StartYear, StartMonth, EndYear, EndMonth, Tag, Description)VALUES('" + 
                    StartDate.Value.Year + "','" + StartDate.Value.Month + "','" + EndDate.Value.Year + "','" + EndDate.Value.Month + "','" +
                    TagBox.Text.Replace("'", "''") + "','" + DesBox.Text.Replace("'", "''") + "')");
                    Content.P_index++;
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Project already created, please use different Project Name. ");
                }
            }
        }
    }
}
