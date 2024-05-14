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
    public partial class MaxLoansByCus : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public MaxLoansByCus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");
            con.Open();
            sda = new SqlDataAdapter("select Cus_SSN,count(*) as num_of_Loans from Loan group by Cus_SSN having count(*) = (select max(num_of_Loans) from(select Cus_SSN, count(*) as num_of_Loans from Loan group by Cus_SSN) Loan)", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void MaxLoansByCus_Load(object sender, EventArgs e)
        {

        }
    }
}
