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
    public partial class Display_customers : Form
    {
        public Display_customers()
        {
            InitializeComponent();
        }

        private void Display_customers_Load(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["database_1.Properties.Settings.BankingConnectionString"].ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(mainconn);
                string sqlquery = "select  cus_name as 'Customer_Name' ,Cus_SSN, cus_phone as 'Customer_Phone',cus_address, Branch_Number,email as 'Customer_Email' from [dbo].[Customer] ";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
