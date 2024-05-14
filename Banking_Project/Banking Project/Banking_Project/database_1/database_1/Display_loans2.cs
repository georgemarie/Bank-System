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
using System.Configuration;


namespace database_1
{
    public partial class Display_loans2 : Form
    {
        public Display_loans2()
        {
            InitializeComponent();
        }

        private void Display_loans2_Load(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["database_1.Properties.Settings.BankingConnectionString"].ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(mainconn);
                string sqlquery = "select  Customer.cus_name as 'Customer_Name',Employee.Name as 'Employee_Name', Loan.loan_num, Loan.loan_amount,Loan.laon_type,Loan.Branch_Number from [dbo].[Loan] inner join [dbo].[Customer]";
                sqlquery += "on Loan.Cus_SSN=Customer.Cus_SSN inner join [dbo].[Employee] on Employee.id=Loan.Employee_id";
                SqlCommand sqlCommand = new SqlCommand(sqlquery, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter sdr = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
