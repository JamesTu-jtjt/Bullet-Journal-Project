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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection();

        public void Edit(string sqlstr)
        {
            SqlCommand cmd = new SqlCommand(sqlstr, cn);
            cmd.ExecuteNonQuery();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                    "Integrated Security=True";
            cn.Open();
            password_textbox.PasswordChar = '*';
            confirm_textbox.PasswordChar = '*';
        }

        private void createaccbtn_Click(object sender, EventArgs e)
        {
            string s1 = "";
            if (password_textbox.Text != confirm_textbox.Text)
            {
                MessageBox.Show("Please key the correct password again");
                password_textbox.Text = "";
                confirm_textbox.Text = "";
                return;
            }
            if (password_textbox.Text == "" || confirm_textbox.Text == "" || account_textbox.Text == "")
            {
                if (password_textbox.Text == "")
                {
                    s1 += "\npassword";
                }
                if (confirm_textbox.Text == "")
                {
                    s1 += "\nconfirm password";
                }
                if (account_textbox.Text == "")
                {
                    s1 += "\naccount";
                }
                MessageBox.Show("Please key the " + s1 + " .");
                s1 = "";
            }
            else
            {
                try
                {
                    /*Edit("INSERT INTO Acc_pass(Account,Password)VALUES('" +
                        password_textbox.Text.Replace("'", "''") + "','" +
                        confirm_textbox.Text.Replace("'", "''")  +")");*/
                    Edit("INSERT INTO Acc_pass(Account,Name,BirthY,BirthM,BirthD,Password)VALUES('" +
                        account_textbox.Text.Replace("'", "''") + "','" +
                        name_textbox.Text.Replace("'", "''") + "','" +
                        dateTimePicker1.Value.Year + "','" + dateTimePicker1.Value.Month + "','" + dateTimePicker1.Value.Day + "','" +
                        password_textbox.Text.Replace("'", "''") + "')");
                    Edit("INSERT INTO person_index(Account,Table_type,Table_name)VALUES('" + account_textbox.Text.Replace("'", "''") + "','LYD','log_year_data" + account_textbox.Text.Replace("'", "''") + "')");
                    Edit("INSERT INTO person_index(Account,Table_type,Table_name)VALUES('" + account_textbox.Text.Replace("'", "''") + "','LMD','log_month_data" + account_textbox.Text.Replace("'", "''") + "')");
                    Edit("INSERT INTO person_index(Account,Table_type,Table_name)VALUES('" + account_textbox.Text.Replace("'", "''") + "','LDD','log_day_data" + account_textbox.Text.Replace("'", "''") + "')");
                    Edit("INSERT INTO person_index(Account,Table_type,Table_name)VALUES('" + account_textbox.Text.Replace("'", "''") + "','PL','proj_list" + account_textbox.Text.Replace("'", "''") + "')");
                    Edit("INSERT INTO person_index(Account,Table_type,Table_name)VALUES('" + account_textbox.Text.Replace("'", "''") + "','PD','proj_data" + account_textbox.Text.Replace("'", "''") + "')");
                    Edit("CREATE TABLE log_year_data" + account_textbox.Text.Replace("'", "''") + "(ID INT NOT NULL PRIMARY KEY, Year INT NOT NULL, Logname NVARCHAR(50) NOT NULL, Tag NVARCHAR(50) NOT NULL, Description NVARCHAR(MAX) ,)");
                    Edit("CREATE TABLE log_month_data" + account_textbox.Text.Replace("'", "''") + "(ID INT NOT NULL PRIMARY KEY, Year INT NOT NULL, Month INT NOT NULL, Logname NVARCHAR(50) NOT NULL, Tag NVARCHAR(50) NOT NULL, Description NVARCHAR(MAX),)");
                    Edit("CREATE TABLE log_day_data" + account_textbox.Text.Replace("'", "''") + "(ID INT NOT NULL PRIMARY KEY, Year INT NOT NULL, Month INT NOT NULL, Day INT NOT NULL, Logname NVARCHAR(50) NOT NULL, Tag NVARCHAR(50) NOT NULL, Description NVARCHAR(50),)");
                    Edit("CREATE TABLE proj_list" + account_textbox.Text.Replace("'", "''") + "(Tag NVARCHAR(50) NOT NULL PRIMARY KEY, StartYear INT NOT NULL, EndYear INT NOT NULL, StartMonth INT NOT NULL, EndMonth INT NOT NULL, Description NVARCHAR(MAX),)");
                    Edit("CREATE TABLE proj_data" + account_textbox.Text.Replace("'", "''") + "(ID INT NOT NULL PRIMARY KEY, Tag NVARCHAR(50) NOT NULL, Logname NVARCHAR(50) NOT NULL, Year INT NOT NULL, Month INT, Day INT, Description NVARCHAR(MAX),)");
                    MessageBox.Show("Account successfully created. ");
                    cn.Close();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Account is already taken." );
                }

            }
        }
    }
}
