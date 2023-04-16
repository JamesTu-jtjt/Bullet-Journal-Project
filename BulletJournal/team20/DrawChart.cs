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
using System.Windows.Forms.DataVisualization.Charting;


namespace team20
{
    public partial class DrawChart : Form
    {
        string account;
        int type = 1;
        public DrawChart(string acc)
        {
            this.account = acc;
            InitializeComponent();
            chart1.Visible = false;
            //yearDataGrid.Visible = false;
        }
        SqlConnection cn = new SqlConnection();
        private void DrawChart_Load(object sender, EventArgs e)
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
        }
        public DataTable get_Dt()
        {
            DataTable dt = new DataTable();
            try
            {
                cn.Open();  // (select formatted to fit SO lines)
                /*SqlCommand cmd = new SqlCommand("SELECT Tag, Year, Month, Day FROM proj_data"
                     + this.account.Replace("'", "''") + " ORDER BY Year, Month, Day", cn);
                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);
                cmd = new SqlCommand("SELECT Tag, Year, Month, Day FROM proj_data"
                    + this.account.Replace("'", "''") + " WHERE Tag = '" + TagBox.Text.Replace("'", "''") + "'", cn);
                reader = cmd.ExecuteReader();
                dt.Load(reader); */
                SqlCommand cmd = new SqlCommand("SELECT Tag, Year, Month, Day FROM proj_data"
                    + this.account.Replace("'", "''") + " WHERE Tag = '" + TagBox.Text.Replace("'", "''") + "'", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return dt;
        }
        private void draw()
        {
            chart1.Visible = true;
            //yearDataGrid.Visible = false;
            DataSet dataSet = new DataSet();
            DataTable dt = get_Dt();
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("date", typeof(string));
            dt2.Columns.Add("count", typeof(int));
            bool canConvert = false;
            int temp_num = 0;


            switch (type)
            {
                case 1:
                    
                    var result = dt.AsEnumerable().GroupBy(r => r.Field<int>("year"))
                        .Select(r => new {
                            condi = r.Key,
                            Count = r.Count()
                        });
                    int temp = StartDate.Value.Year;
                    foreach (var item in result)
                    {
                        if (item.condi > EndDate.Value.Year || item.condi < StartDate.Value.Year)
                        {
                            continue;
                        }
                        if (temp< item.condi)
                        {
                            for(int i =temp ;i< item.condi;i++)
                            {
                                DataRow dr = dt2.NewRow();
                                dr["date"] = i;
                                dr["count"] = 0;
                                dt2.Rows.Add(dr);
                            }
                            temp = item.condi;
                        }
                        if(temp <= EndDate.Value.Year)
                        {
                            while (temp != item.condi)
                            {
                                DataRow dr = dt2.NewRow();
                                dr["date"] = temp;
                                dr["count"] = 0;
                                dt2.Rows.Add(dr);
                                temp = temp++;
                            }
                            DataRow dr_2 = dt2.NewRow();
                            dr_2["date"] = item.condi;
                            dr_2["count"] = item.Count;
                            dt2.Rows.Add(dr_2);
                            temp = item.condi + 1;
                        }
                    }
                    if(temp <= EndDate.Value.Year)
                     {
                        for (int i = temp; i <= EndDate.Value.Year; i++)
                        {
                            DataRow dr = dt2.NewRow();
                            dr["date"] = i;
                            dr["count"] = 0;
                            dt2.Rows.Add(dr);
                        }
                    }

                    break;
                case 2:
                    dt.Columns.Add("dateTime", typeof(int));
                    foreach (DataRow dr in dt.Rows)
                    {
                        canConvert = int.TryParse(dr["Month"].ToString(), out temp_num);
                        if (canConvert)
                        {
                            var result1 = Int32.Parse(dr["Year"].ToString()) * 100 + Int32.Parse(dr["Month"].ToString());
                            dr["dateTime"] = result1;//.ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            var result1 = 0;
                            dr["dateTime"] = result1;//.ToString("yyyy-MM-dd");
                        }
                    }
                    var result2 = dt.AsEnumerable().GroupBy(r => r.Field<int>("dateTime"))
                        .Select(r => new {
                            condi = r.Key,
                            Count = r.Count()
                        });
                    temp = StartDate.Value.Year * 100 + StartDate.Value.Month;
                    foreach (var item in result2)
                    {
                        if (item.condi > EndDate.Value.Year * 100 + EndDate.Value.Month  || item.condi < StartDate.Value.Year * 100 + StartDate.Value.Month || item.condi ==0)
                        {
                            continue;
                        }
                        if (temp < item.condi)
                        {
                            for (int i = temp; i < item.condi; i++)
                            {
                                DataRow dr = dt2.NewRow();
                                dr["date"] = i;
                                dr["count"] = 0;
                                dt2.Rows.Add(dr);
                                if (i % 100 == 12)
                                    i = i + 100 - 12;
                            }
                            temp = item.condi;
                        }
                        if (temp <= EndDate.Value.Year * 100 + EndDate.Value.Month)
                        {
                            while (temp != item.condi)
                            {
                                DataRow dr = dt2.NewRow();
                                dr["date"] = temp;
                                dr["count"] = 0;
                                dt2.Rows.Add(dr);
                                temp = temp++;
                                if (temp % 100 == 12)
                                    temp = temp + 100 - 12;
                            }
                            DataRow dr_2 = dt2.NewRow();
                            dr_2["date"] = item.condi;
                            dr_2["count"] = item.Count;
                            dt2.Rows.Add(dr_2);
                            temp = item.condi + 1;
                            if (temp % 100 == 12)
                                temp = temp + 100 - 12;
                        }
                    }
                    if (temp <= EndDate.Value.Year * 100 + EndDate.Value.Month)
                    {
                        for (int i = temp; i <= EndDate.Value.Year * 100 + EndDate.Value.Month; i++)
                        {
                            DataRow dr = dt2.NewRow();
                            dr["date"] = i;
                            dr["count"] = 0;
                            dt2.Rows.Add(dr);
                            if (i % 100 == 12)
                                i = i + 100 - 12;
                        }
                    }
                    break;
                case 3:
                    dt.Columns.Add("dateTime", typeof(DateTime));
                    foreach (DataRow dr in dt.Rows)
                    {
                        //canConvert = int.TryParse(dr["Month"].ToString(), out temp_num);
                        if (!int.TryParse(dr["Month"].ToString(), out temp_num) || !int.TryParse(dr["Day"].ToString(), out temp_num))
                        {
                            dr["dateTime"] = default(DateTime);//.ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            var result1 = new DateTime(Int32.Parse(dr["Year"].ToString()), Int32.Parse(dr["Month"].ToString()), Int32.Parse(dr["Day"].ToString()));
                            dr["dateTime"] = result1;//.ToString("yyyy-MM-dd");
                        }
                    }
                    var result3 = dt.AsEnumerable().GroupBy(r => r.Field<DateTime>("dateTime"))
                        .Select(r => new {
                            condi = r.Key,
                            Count = r.Count()
                        });
                    
                    DateTime tmp = StartDate.Value;
                    foreach (var item in result3)
                    {
                        if (DateTime.Compare(item.condi, EndDate.Value) > 0)
                        {
                            break;
                        }
                        else if (DateTime.Compare(item.condi.AddDays(1), StartDate.Value) < 0 || DateTime.Compare(item.condi, default(DateTime)) == 0)
                        {
                            continue;
                        }
                        else if (DateTime.Compare(tmp, item.condi) < 0)
                        {
                            while (DateTime.Compare(tmp, item.condi) < 0)
                            {
                                DataRow dr = dt2.NewRow();
                                dr["date"] = tmp.ToString("yyyy-MM-dd");
                                dr["count"] = 0;
                                dt2.Rows.Add(dr);
                                tmp = tmp.AddDays(1);
                            }
                            tmp = item.condi;
                        }

                        while (!Equals(tmp, item.condi) && !Equals(tmp, StartDate.Value))
                        {
                            DataRow dr = dt2.NewRow();
                            dr["date"] = tmp.ToString("yyyy-MM-dd");
                            dr["count"] = 0;
                            dt2.Rows.Add(dr);
                            tmp = tmp.AddDays(1);
                        }
                        DataRow dr_2 = dt2.NewRow();
                        dr_2["date"] = item.condi.ToString("yyyy-MM-dd");
                        dr_2["count"] = item.Count;
                        dt2.Rows.Add(dr_2);
                        tmp = item.condi.AddDays(1);
                    }
                    if (DateTime.Compare(tmp, EndDate.Value) <= 0)
                    {
                        while (DateTime.Compare(tmp, EndDate.Value) < 0)
                        {
                            DataRow dr = dt2.NewRow();
                            dr["date"] = tmp.ToString("yyyy-MM-dd");
                            dr["count"] = 0;
                            dt2.Rows.Add(dr);
                            tmp = tmp.AddDays(1);
                        }
                    }
                    break;
            }

            chart1.Visible = true;
            chart1.DataSource = dt2;
            chart1.Series["Series1"].XValueMember = "date";
            chart1.Series["Series1"].YValueMembers = "count";
            chart1.Series["Series1"].LegendText = TagBox.Text;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            chart1.DataBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!TagBox.Text.Equals("None"))
            {
                chart1.Visible = true;
                //yearDataGrid.Visible = false;
                //tabControl1.Visible = false;
                draw();
            }
        }

        private void radioY_CheckedChanged(object sender, EventArgs e)
        {
            radioM.Checked = false;
            radioD.Checked = false;
            type = 1;
        }

        private void radioM_CheckedChanged(object sender, EventArgs e)
        {
            radioY.Checked = false;
            radioD.Checked = false;
            type = 2;
        }

        private void radioD_CheckedChanged(object sender, EventArgs e)
        {
            radioY.Checked = false;
            radioM.Checked = false;
            type = 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            init_grid();
            
        }
        private void init_grid()
        {
            //
            
            int proj_num = 0;
            
            yearDataGrid.DataSource = null;
            yearDataGrid.Rows.Clear();
            yearDataGrid.ColumnCount = EndDate.Value.Year - StartDate.Value.Year + 2;

            yearDataGrid.Columns[0].Name = "projname";
            for (int i = 1;i < EndDate.Value.Year - StartDate.Value.Year + 2; i++)
            {
                yearDataGrid.Columns[i].Name = (StartDate.Value.Year + i - 1).ToString();
            }
            //Set the columns name
            monthDataGrid.DataSource = null;
            monthDataGrid.Rows.Clear();
            monthDataGrid.ColumnCount =( EndDate.Value.Year - StartDate.Value.Year) *12 +EndDate.Value.Month - StartDate.Value.Month + 2;

            monthDataGrid.Columns[0].Name = "projname";
            int temp = StartDate.Value.Year * 100 + StartDate.Value.Month;

            for (int i = 1; i < monthDataGrid.ColumnCount; i++)
            {
                monthDataGrid.Columns[i].Name = (temp).ToString();
                if (temp % 100 == 12)
                    temp = temp + 100 - 12;
                temp++;
            }
            dayDataGrid.DataSource = null;
            dayDataGrid.Rows.Clear();
            dayDataGrid.ColumnCount = DateTime.DaysInMonth(StartDate.Value.Year, StartDate.Value.Month) + 1;

            dayDataGrid.Columns[0].Name = "projname";

            for (int i = 1; i < dayDataGrid.ColumnCount; i++)
            {
                dayDataGrid.Columns[i].Name = (i).ToString();
            }


            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Account_password.mdf;" +
                    "Integrated Security=True";
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Tag FROM proj_list" + this.account, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            foreach (DataRow rows in dt.Rows)
            {
                DataTable dt2 = new DataTable();
                string[] row = new string[] { rows["Tag"].ToString().Replace("'", "''"),  };  // 定義一列的字串陣列
                yearDataGrid.Rows.Add(row);
                monthDataGrid.Rows.Add(row);
                dayDataGrid.Rows.Add(row);


                cn.Open();
                // SqlDataAdapter
                SqlCommand cmd = new SqlCommand("SELECT Tag, Year, Month, Day FROM proj_data"
                    + this.account.Replace("'", "''") + " WHERE Tag = '" + rows["Tag"].ToString().Replace("'", "''") + "'", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                dt2.Load(reader);
                //cmd.Fill(dt2);
                cn.Close();
                var result = dt2.AsEnumerable().GroupBy(r => r.Field<int>("year"))
                        .Select(r => new {
                            condi = r.Key,
                            Count = r.Count()
                        });
                foreach (var item in result)
                {
                    for (int j = 1; j < yearDataGrid.ColumnCount; j++)
                    {
                        if (Int32.Parse(yearDataGrid.Columns[j].Name) == item.condi)
                        {
                            yearDataGrid.Rows[proj_num].Cells[j].Style.BackColor = Color.Red;
                            break;
                        }
                    }
                }
                //////month
                dt2.Columns.Add("dateTime", typeof(int));
                int temp_num = 0;
                foreach (DataRow dr in dt2.Rows)
                {
                    bool canConvert = int.TryParse(dr["Month"].ToString(), out temp_num);
                    if (canConvert)
                    {
                        var result1 = Int32.Parse(dr["Year"].ToString()) * 100 + Int32.Parse(dr["Month"].ToString());
                        dr["dateTime"] = result1;//.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        var result1 = 0;
                        dr["dateTime"] = result1;//.ToString("yyyy-MM-dd");
                    }
                }
                var result_m = dt2.AsEnumerable().GroupBy(r => r.Field<int>("dateTime"))
                    .Select(r => new {
                        condi = r.Key,
                        Count = r.Count()
                    });

                foreach (var item in result_m)
                {
                    for (int j = 1; j < monthDataGrid.ColumnCount; j++)
                    {
                        if (Int32.Parse(monthDataGrid.Columns[j].Name) == item.condi)
                        {
                            monthDataGrid.Rows[proj_num].Cells[j].Style.BackColor = Color.Red;
                            break;
                        }
                    }
                }
                ////day
                dt2.Columns.Add("dateTime2", typeof(DateTime));
                foreach (DataRow dr in dt2.Rows)
                {
                    //canConvert = int.TryParse(dr["Month"].ToString(), out temp_num);
                    if (!int.TryParse(dr["Month"].ToString(), out temp_num) || !(int.TryParse(dr["Day"].ToString(), out temp_num)))
                    {
                        dr["dateTime2"] = default(DateTime);//.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        var result1 = new DateTime(Int32.Parse(dr["Year"].ToString()), Int32.Parse(dr["Month"].ToString()), Int32.Parse(dr["Day"].ToString()));
                        dr["dateTime2"] = result1;//.ToString("yyyy-MM-dd");
                    }
                }
                var result3 = dt2.AsEnumerable().GroupBy(r => r.Field<DateTime>("dateTime2"))
                    .Select(r => new {
                        condi = r.Key,
                        Count = r.Count()
                    });

                DateTime tmp = new DateTime(StartDate.Value.Year, StartDate.Value.Month,1);
                
                foreach (var item in result3)
                {
                    tmp = new DateTime(StartDate.Value.Year, StartDate.Value.Month, 1);
                    for (int j = 1; j < dayDataGrid.ColumnCount; j++)
                    {
                        if (Equals(tmp, item.condi))
                        {
                            dayDataGrid.Rows[proj_num].Cells[j].Style.BackColor = Color.Red;
                            break;
                        }
                        tmp = tmp.AddDays(1);
                    }
                }
                proj_num++;
            }

        }
    }
}
