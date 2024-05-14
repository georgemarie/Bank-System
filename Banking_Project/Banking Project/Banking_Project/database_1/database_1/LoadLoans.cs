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

namespace database_1
{
    public partial class LoadLoans : Form
    {
        SqlConnection cnct = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");
        public LoadLoans()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView_num.GridLines = true;
            listView_num.View = View.Details;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView_num.Columns.Add("Loan number",100);
            listView_num.Columns.Add("Loan amount", 100);
            listView_num.Columns.Add("Loan type", 100);
            listView_num.Columns.Add("Customer SSN", 100);
            listView_num.Columns.Add("Branch number", 100);
            listView_num.Columns.Add("Status", 100);
            listView_num.View = View.Details;

            cnct.Open();
            string sql = "select * from Loan ";
            SqlDataAdapter dataA = new SqlDataAdapter(sql, cnct);
            DataTable dataT = new DataTable();
            dataA.Fill(dataT);
            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                DataRow dr = dataT.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["loan_num"].ToString());
                listitem.SubItems.Add(dr["loan_amount"].ToString());
                listitem.SubItems.Add(dr["laon_type"].ToString());
                listitem.SubItems.Add(dr["Cus_SSN"].ToString());
                listitem.SubItems.Add(dr["Branch_Number"].ToString());
                listitem.SubItems.Add(dr["Status"].ToString());
                listView_num.Items.Add(listitem);
            }
            cnct.Close();
        }

    }
}
