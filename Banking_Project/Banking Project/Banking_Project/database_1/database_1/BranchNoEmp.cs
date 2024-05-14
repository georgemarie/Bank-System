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
    public partial class BranchNoEmp : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public BranchNoEmp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");
            con.Open();
            sda = new SqlDataAdapter("Select Branch.Branch_Number as 'Branches with no Employees' from Branch where Branch.Branch_Number not in (select Employee.Branch_Number from Employee)", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void BranchNoEmp_Load(object sender, EventArgs e)
        {

        }
    }
}
