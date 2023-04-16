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
    public partial class AddLog : Form
    {
        string type, account;
        public AddLog(string t, string acc)
        {
            this.type = t;
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

        public bool Check_id_exists(string sqlstr)
        {
            cn.Close();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                    "Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand(sqlstr, cn);
            int userCount = (int)cmd.ExecuteScalar();
            if (userCount > 0)
            {
                return true;
            }
            else
            {
                cn.Close();
                return false;
            }
        }

        private void LogEdit_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                    "Integrated Security=True";
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tag FROM proj_list" + this.account, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            TagBox.Items.Add("None");
            foreach (DataRow row in dt.Rows)
            {
                TagBox.Items.Add(row["Tag"].ToString());
            }
            switch (this.type)
            {
                case "Y":
                    Title.Text = "Add Yearly Log";
                    timeSel.Format = DateTimePickerFormat.Custom;
                    timeSel.CustomFormat = "yyyy";
                    timeSel.ShowUpDown = true;
                    break;
                case "M":
                    Title.Text = "Add Monthly Log";
                    timeSel.Format = DateTimePickerFormat.Custom;
                    timeSel.CustomFormat = "yyyy MM";
                    timeSel.ShowUpDown = true;
                    break;
                case "D":
                    Title.Text = "Add Daily Log";
                    break;
            }

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            switch (this.type)
            {
                case "Y":
                    if (LogNameBox.Text == "" || TagBox.Text == "")
                    {
                        MessageBox.Show("Please fill in Log Name and Tag");
                    }
                    else if(TagBox.Text == "None")
                    {
                        bool check = true;
                        do
                        {
                            if (Check_id_exists(" SELECT COUNT(*) FROM log_year_data" + this.account.Replace("'", "''") +
                                " where ID like " + Content.Y_index))
                                Content.Y_index++;
                            else
                                check = false;
                        } while (check);
                        Edit("INSERT INTO log_year_data" + this.account.Replace("'", "''") +
                            "(ID, Year, Logname, Description, Tag)VALUES(" + Content.Y_index + ",'" +
                            timeSel.Value.Year + "','" + LogNameBox.Text.Replace("'", "''") + "','" +
                            DesBox.Text.Replace("'", "''") + "','" + TagBox.Text.Replace("'", "''") + "')");
                        Edit("INSERT INTO proj_data" + this.account.Replace("'", "''") +
                            "(ID, Year, Logname, Description, Tag)VALUES(" + Content.Y_index + ",'" +
                            timeSel.Value.Year + "','" + LogNameBox.Text.Replace("'", "''") + "','" +
                            DesBox.Text.Replace("'", "''") + "','" + TagBox.Text.Replace("'", "''") + "')");
                        Content.Y_index++;
                        this.Close();
                    }
                    else {
                        cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                            "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                            "Integrated Security=True";
                        cn.Open();
                        SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM proj_list" + this.account.Replace("'", "''") +
                        " WHERE Tag='" + TagBox.Text.Replace("'", "''") + "'", cn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cn.Close();
                        if (dt.Rows[0][0].ToString() != "1" && TagBox.Text != "None")
                        {
                            AddProj ap = new AddProj(TagBox.Text, account);
                            ap.ShowDialog();
                            break;
                        }
                        cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                            "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                            "Integrated Security=True";
                        cn.Open();
                        SqlDataAdapter daC = new SqlDataAdapter("SELECT * FROM proj_list" + this.account.Replace("'", "''") +
                        " WHERE Tag='" + TagBox.Text.Replace("'", "''") + "'", cn);
                        DataTable dtC = new DataTable();
                        daC.Fill(dtC);
                        cn.Close();
                        if (int.Parse(dtC.Rows[0]["StartYear"].ToString()) > timeSel.Value.Year || int.Parse(dtC.Rows[0]["EndYear"].ToString()) < timeSel.Value.Year)
                        {
                            MessageBox.Show("Time out of range of project. ");
                            break;
                        }
                        bool check = true;
                        do
                        {
                            if (Check_id_exists(" SELECT COUNT(*) FROM log_year_data" + this.account.Replace("'", "''") +
                                " where ID like " + Content.Y_index))
                                Content.Y_index++;
                            else
                                check = false;
                        } while (check);
                        Edit("INSERT INTO log_year_data" + this.account.Replace("'", "''") +
                            "(ID, Year, Logname, Description, Tag)VALUES(" + Content.Y_index + ",'" +
                            timeSel.Value.Year + "','"  + LogNameBox.Text.Replace("'", "''") + "','" + 
                            DesBox.Text.Replace("'", "''") + "','" + TagBox.Text.Replace("'", "''") + "')");
                        Edit("INSERT INTO proj_data" + this.account.Replace("'", "''") +
                            "(ID, Year, Logname, Description, Tag)VALUES(" + Content.Y_index + ",'" +
                            timeSel.Value.Year + "','" + LogNameBox.Text.Replace("'", "''") + "','" +
                            DesBox.Text.Replace("'", "''") + "','" + TagBox.Text.Replace("'", "''") + "')");
                        Content.Y_index++;
                        this.Close();
                    }
                    break;
                case "M":
                    if (LogNameBox.Text == "" || TagBox.Text == "")
                    {
                        MessageBox.Show("Please fill in Log Name and Tag");
                    }
                    else if (TagBox.Text == "None")
                    {
                        bool check = true;
                        do
                        {
                            if (Check_id_exists(" SELECT COUNT(*) FROM log_month_data" + this.account.Replace("'", "''") +
                                " where ID like " + Content.M_index))
                                Content.M_index++;
                            else
                                check = false;
                        } while (check);
                        Edit("INSERT INTO log_month_data" + this.account.Replace("'", "''") +
                            "(ID, Year, Month, Logname, Description, Tag)VALUES(" + Content.M_index + ",'" +
                            timeSel.Value.Year + "','" +
                            timeSel.Value.Month + "', '" + LogNameBox.Text.Replace("'", "''") + "','"
                            + DesBox.Text.Replace("'", "''") + "','" + TagBox.Text.Replace("'", "''") + "')");
                        Edit("INSERT INTO proj_data" + this.account.Replace("'", "''") +
                            "(ID, Year, Month, Logname, Description, Tag)VALUES(" + Content.M_index + ",'" +
                            timeSel.Value.Year + "','" +
                            timeSel.Value.Month + "', '" + LogNameBox.Text.Replace("'", "''") + "','"
                            + DesBox.Text.Replace("'", "''") + "','" + TagBox.Text.Replace("'", "''") + "')");
                        Content.M_index++;
                        this.Close();
                    }
                    else
                    {
                        cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                            "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                            "Integrated Security=True";
                        cn.Open();
                        SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM proj_list" + this.account.Replace("'", "''") +
                        " WHERE Tag='" + TagBox.Text.Replace("'", "''") + "'", cn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cn.Close();
                        if (dt.Rows[0][0].ToString() != "1")
                        {
                            AddProj ap = new AddProj(TagBox.Text, account);
                            ap.ShowDialog();
                            break;
                        }
                        cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                            "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                            "Integrated Security=True";
                        cn.Open();
                        SqlDataAdapter daC = new SqlDataAdapter("SELECT * FROM proj_list" + this.account.Replace("'", "''") +
                        " WHERE Tag='" + TagBox.Text.Replace("'", "''") + "'", cn);
                        DataTable dtC = new DataTable();
                        daC.Fill(dtC);
                        cn.Close();
                        if (int.Parse(dtC.Rows[0]["StartYear"].ToString()) > timeSel.Value.Year || int.Parse(dtC.Rows[0]["EndYear"].ToString()) < timeSel.Value.Year)
                        {
                            MessageBox.Show("Time out of range of project. ");
                            break;
                        }
                        else if (int.Parse(dtC.Rows[0]["StartYear"].ToString()) == timeSel.Value.Year && int.Parse(dtC.Rows[0]["StartMonth"].ToString()) > timeSel.Value.Month)
                        {
                            MessageBox.Show("Time out of range of project. ");
                            break;
                        }
                        else if (int.Parse(dtC.Rows[0]["EndYear"].ToString()) == timeSel.Value.Year && int.Parse(dtC.Rows[0]["EndMonth"].ToString()) < timeSel.Value.Month)
                        {
                            MessageBox.Show("Time out of range of project. ");
                            break;
                        }
                        bool check = true;
                        do
                        {
                            if (Check_id_exists(" SELECT COUNT(*) FROM log_month_data" + this.account.Replace("'", "''") +
                                " where ID like " + Content.M_index))
                                Content.M_index++;
                            else
                                check = false;
                        } while (check);
                        Edit("INSERT INTO log_month_data" + this.account.Replace("'", "''") +
                            "(ID, Year, Month, Logname, Description, Tag)VALUES(" + Content.M_index + ",'" +
                            timeSel.Value.Year + "','" +
                            timeSel.Value.Month + "', '" + LogNameBox.Text.Replace("'", "''") + "','" 
                            + DesBox.Text.Replace("'", "''") + "','" + TagBox.Text.Replace("'", "''") + "')");
                        Edit("INSERT INTO proj_data" + this.account.Replace("'", "''") +
                            "(ID, Year, Month, Logname, Description, Tag)VALUES(" + Content.M_index + ",'" +
                            timeSel.Value.Year + "','" +
                            timeSel.Value.Month + "', '" + LogNameBox.Text.Replace("'", "''") + "','"
                            + DesBox.Text.Replace("'", "''") + "','" + TagBox.Text.Replace("'", "''") + "')");
                        Content.M_index++;
                        this.Close();
                    }
                    break;
                case "D":
                    if (LogNameBox.Text == "" || TagBox.Text == "")
                    {
                        MessageBox.Show("Please fill in Log Name and Tag");
                    }
                    else if (TagBox.Text == "None")
                    {
                        bool check = true;
                        do
                        {
                            if (Check_id_exists(" SELECT COUNT(*) FROM log_day_data" + this.account.Replace("'", "''") +
                                " where ID like " + Content.D_index))
                                Content.D_index++;
                            else
                                check = false;
                        } while (check);
                        Edit("INSERT INTO log_day_data" + this.account +
                            "(ID, Year, Month, Day, Logname, Description, Tag)VALUES(" + Content.D_index + ",'" +
                            timeSel.Value.Year + "','" +
                            timeSel.Value.Month + "','" + timeSel.Value.Day +
                            "', '" + LogNameBox.Text.Replace("'", "''") + "','" + DesBox.Text.Replace("'", "''") + "','" + TagBox.Text.Replace("'", "''") + "')");
                        Edit("INSERT INTO proj_data" + this.account +
                            "(ID, Year, Month, Day, Logname, Description, Tag)VALUES(" + Content.D_index + ",'" +
                            timeSel.Value.Year + "','" +
                            timeSel.Value.Month + "','" + timeSel.Value.Day +
                            "', '" + LogNameBox.Text.Replace("'", "''") + "','" + DesBox.Text.Replace("'", "''") + "','" + TagBox.Text.Replace("'", "''") + "')");
                        Content.D_index++;
                        this.Close();
                    }
                    else
                    {
                        cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                            "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                            "Integrated Security=True";
                        cn.Open();
                        SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM proj_list" + this.account.Replace("'", "''") +
                        " WHERE Tag='" + TagBox.Text.Replace("'", "''") + "'", cn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cn.Close();
                        if (dt.Rows[0][0].ToString() != "1")
                        {
                            AddProj ap = new AddProj(TagBox.Text, account);
                            ap.ShowDialog();
                            break;
                        }
                        cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                            "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                            "Integrated Security=True";
                        cn.Open();
                        SqlDataAdapter daC = new SqlDataAdapter("SELECT * FROM proj_list" + this.account.Replace("'", "''") +
                        " WHERE Tag='" + TagBox.Text.Replace("'", "''") + "'", cn);
                        DataTable dtC = new DataTable();
                        daC.Fill(dtC);
                        cn.Close();
                        if (int.Parse(dtC.Rows[0]["StartYear"].ToString()) > timeSel.Value.Year || int.Parse(dtC.Rows[0]["EndYear"].ToString()) < timeSel.Value.Year)
                        {
                            MessageBox.Show("Time out of range of project. ");
                            break;
                        }
                        else if (int.Parse(dtC.Rows[0]["StartYear"].ToString()) == timeSel.Value.Year && int.Parse(dtC.Rows[0]["StartMonth"].ToString()) > timeSel.Value.Month)
                        {
                            MessageBox.Show("Time out of range of project. ");
                            break;
                        }
                        else if (int.Parse(dtC.Rows[0]["EndYear"].ToString()) == timeSel.Value.Year && int.Parse(dtC.Rows[0]["EndMonth"].ToString()) < timeSel.Value.Month)
                        {
                            MessageBox.Show("Time out of range of project. ");
                            break;
                        }
                        bool check = true;
                        do
                        {
                            if (Check_id_exists(" SELECT COUNT(*) FROM log_day_data" + this.account.Replace("'", "''") +
                                " where ID like " + Content.D_index))
                                Content.D_index++;
                            else
                                check = false;
                        } while (check);
                        Edit("INSERT INTO log_day_data" + this.account +
                            "(ID, Year, Month, Day, Logname, Description, Tag)VALUES(" + Content.D_index + ",'" +
                            timeSel.Value.Year + "','" +
                            timeSel.Value.Month + "','" + timeSel.Value.Day + 
                            "', '" + LogNameBox.Text.Replace("'", "''") + "','" + DesBox.Text.Replace("'", "''") + "','" + TagBox.Text.Replace("'", "''") + "')");
                        Edit("INSERT INTO proj_data" + this.account +
                            "(ID, Year, Month, Day, Logname, Description, Tag)VALUES(" + Content.D_index + ",'" +
                            timeSel.Value.Year + "','" +
                            timeSel.Value.Month + "','" + timeSel.Value.Day +
                            "', '" + LogNameBox.Text.Replace("'", "''") + "','" + DesBox.Text.Replace("'", "''") + "','" + TagBox.Text.Replace("'", "''") + "')");
                        Content.D_index++;
                        this.Close();
                    }
                    break;
            }
        }
    }
}
