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
    public partial class BranchNoCus : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public BranchNoCus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                SqlConnection con = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");
                con.Open();
                sda = new SqlDataAdapter("Select Branch.Branch_Number as 'Branches with no Customers' from Branch where Branch.Branch_Number not in (select Customer.Branch_Number from Customer)", con);
                dt = new DataTable();    
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            //}
            //catch(Exception ex)
            //{
                //MessageBox.Show(ex.Message);
            //}
        }

        private void BranchNoCus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankingDataSet1.Branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.bankingDataSet1.Branch);

        }
    }
}
