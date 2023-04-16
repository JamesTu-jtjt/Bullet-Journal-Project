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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection();
        void Edit(string sqlstr)
        {
            SqlCommand cmd = new SqlCommand(sqlstr, cn);
            cmd.ExecuteNonQuery();
        }

        private void Createaccountbtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            password_textbox.PasswordChar = '*';
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                "Integrated Security=True";
            cn.Open();
            SqlDataAdapter sd = new SqlDataAdapter("SELECT COUNT(*) FROM Acc_pass WHERE Account = '" + account_textbox.Text + "' AND Password = '" + password_textbox.Text + "'", cn);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sd.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Content contentform = new Content(account_textbox.Text);
                account_textbox.Text = "";
                password_textbox.Text = "";
                contentform.Show();
            }
            else
            {
                MessageBox.Show("Invalid account or password.");
            }
            cn.Close();
        }
    }
}
