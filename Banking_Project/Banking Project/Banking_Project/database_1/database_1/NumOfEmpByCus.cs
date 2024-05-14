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
    public partial class NumOfEmpByCus : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public NumOfEmpByCus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");
            con.Open();
            sda = new SqlDataAdapter("SELECT  Customer.Cus_SSN , Customer.cus_name,Customer.cus_phone,Customer.cus_address,Customer.email,Customer.password,Customer.Branch_Number,count(distinct Loan.Employee_id) As 'Number of employees Customer dealt with' from Loan right outer join Customer on Customer.Cus_SSN = Loan.Cus_SSN GROUP BY Customer.Cus_SSN,Customer.cus_name, Customer.cus_phone,Customer.cus_address,Customer.email,Customer.password,Customer.Branch_Number; ", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Selectst6_Load(object sender, EventArgs e)
        {

        }
    }
}
