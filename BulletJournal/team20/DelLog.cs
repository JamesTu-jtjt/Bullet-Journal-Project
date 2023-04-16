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
    public partial class DelLog : Form
    {
        string type, account;
        public DelLog(string t, string acc)
        {
            this.type = t;
            this.account = acc;
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection();

        private void DelLog_Load(object sender, EventArgs e)
        {
            switch (this.type)
            {
                case "Y":
                    DelLogLab.Text = "Delete Yearly Log";
                    
                    break;
                case "M":
                    DelLogLab.Text = "Delete Monthly Log";
                    break;
                case "D":
                    DelLogLab.Text = "Delete Daily Log";
                    break;
                case "P":
                    IndexLab.Text = "Project Name";
                    DelLogLab.Text = "Delete Project";
                    break;
            }
        }

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


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            switch (this.type)
            {
                case "Y":
                    if (IndexBox.Text == "")
                    {
                        MessageBox.Show("Please fill in Log Name and Tag");
                    }
                    else
                    {
                        try
                        {
                            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                            "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                            "Integrated Security=True";
                            cn.Open();
                            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM proj_data" + this.account.Replace("'", "''") +
                            " WHERE ID='" + IndexBox.Text.Replace("'", "''") + "'", cn);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            cn.Close();
                            if (dt.Rows[0][0].ToString() != "1")
                            {
                                MessageBox.Show("Invalid ID");
                                break;
                            }
                            Edit("DELETE FROM log_year_data" + this.account.Replace("'", "''") +
                            " WHERE ID='" + IndexBox.Text.Replace("'", "''") + "'");
                            Edit("UPDATE log_year_data" + this.account.Replace("'", "''") +
                                " SET ID = ID - 1 WHERE ID > '" + IndexBox.Text.Replace("'", "''") + "'");
                            Edit("DELETE FROM proj_data" + this.account.Replace("'", "''") +
                            " WHERE ID='" + IndexBox.Text.Replace("'", "''") + "'");
                            Edit("UPDATE proj_data" + this.account.Replace("'", "''") +
                                " SET ID = ID - 1 WHERE ID > '" + IndexBox.Text.Replace("'", "''") + "' AND ID < 1000");
                            Content.Y_index--;
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("Invalid ID");
                        }
                        this.Close();
                    }
                    break;
                case "M":
                    if (IndexBox.Text == "")
                    {
                        MessageBox.Show("Please fill in Log Name and Tag");
                    }
                    else
                    {
                        try
                        {
                            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                            "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                            "Integrated Security=True";
                            cn.Open();
                            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM proj_data" + this.account.Replace("'", "''") +
                            " WHERE ID='" + IndexBox.Text.Replace("'", "''") + "'", cn);
                            DataTable dt = new DataTable(); 
                            da.Fill(dt);
                            cn.Close();
                            if (dt.Rows[0][0].ToString() != "1")
                            {
                                MessageBox.Show("Invalid ID");
                                break;
                            }
                            Edit("DELETE FROM log_month_data" + this.account.Replace("'", "''") +
                                " WHERE ID='" + IndexBox.Text.Replace("'", "''") + "'");
                            Edit("UPDATE log_month_data" + this.account.Replace("'", "''") +
                                " SET ID = ID - 1 WHERE ID > '" + IndexBox.Text.Replace("'", "''") + "'");
                            Edit("DELETE FROM proj_data" + this.account.Replace("'", "''") +
                            " WHERE ID='" + IndexBox.Text.Replace("'", "''") + "'");
                            Edit("UPDATE proj_data" + this.account.Replace("'", "''") +
                                " SET ID = ID - 1 WHERE ID > '" + IndexBox.Text.Replace("'", "''") + "' AND ID < 10000");
                            Content.M_index--;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Invalid ID");
                        }
                        this.Close();
                    }
                    break;
                case "D":
                    if (IndexBox.Text == "")
                    {
                        MessageBox.Show("Please fill in Log Name and Tag");
                    }
                    else
                    {
                        try
                        {
                            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                               "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                               "Integrated Security=True";
                            cn.Open();
                            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM proj_data" + this.account.Replace("'", "''") +
                             " WHERE ID='" + IndexBox.Text.Replace("'", "''") + "'", cn);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            cn.Close();
                            if (dt.Rows[0][0].ToString() != "1")
                            {
                                MessageBox.Show("Invalid ID");
                                break;
                            }
                            Edit("DELETE FROM log_day_data" + this.account.Replace("'", "''") +
                            " WHERE ID='" + IndexBox.Text.Replace("'", "''") + "'");
                            Edit("UPDATE log_day_data" + this.account.Replace("'", "''") +
                                " SET ID = ID - 1 WHERE ID > '" + IndexBox.Text.Replace("'", "''") + "'");
                            Edit("DELETE FROM proj_data" + this.account.Replace("'", "''") +
                            " WHERE ID='" + IndexBox.Text.Replace("'", "''") + "'");
                            Edit("UPDATE proj_data" + this.account.Replace("'", "''") +
                                " SET ID = ID - 1 WHERE ID > '" + IndexBox.Text.Replace("'", "''") + "'");
                            Content.D_index--;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Invalid ID");
                        }
                        this.Close();
                    }
                    break;
                case "P":
                    if (IndexBox.Text == "")
                    {
                        MessageBox.Show("Please fill in Project ID");
                    }
                    else
                    {
                        try
                        {
                            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                               "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                               "Integrated Security=True";
                            cn.Open();
                            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM proj_list" + this.account.Replace("'", "''") +
                             " WHERE Tag='" + IndexBox.Text.Replace("'", "''") + "'", cn);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            cn.Close();
                            if (dt.Rows[0][0].ToString() != "1")
                            {
                                MessageBox.Show("Invalid ID");
                                break;
                            }
                            else
                            {
                                DialogResult r;
                                r = MessageBox.Show("Are you sure you want to delete " + IndexBox.Text + " from Projects? /nAll logs with tag " + IndexBox.Text + " will be lost.", "", MessageBoxButtons.OKCancel);
                                if (r == DialogResult.Cancel)
                                {
                                    this.Close();
                                    break;
                                }

                            }
                            Edit("DELETE FROM proj_list" + this.account.Replace("'", "''") +
                            " WHERE Tag='" + IndexBox.Text.Replace("'", "''") + "'");
                            Edit("DELETE FROM proj_data" + this.account.Replace("'", "''") +
                            " WHERE Tag='" + IndexBox.Text.Replace("'", "''") + "'");
                            Edit("DELETE FROM log_year_data" + this.account.Replace("'", "''") +
                            " WHERE Tag='" + IndexBox.Text.Replace("'", "''") + "'");
                            Edit("DELETE FROM log_month_data" + this.account.Replace("'", "''") +
                            " WHERE Tag='" + IndexBox.Text.Replace("'", "''") + "'");
                            Edit("DELETE FROM log_day_data" + this.account.Replace("'", "''") +
                            " WHERE Tag='" + IndexBox.Text.Replace("'", "''") + "'");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Invalid ID");
                        }
                        this.Close();
                    }
                    break;
            }
        }
    }
}
