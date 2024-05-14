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
    public partial class Loan_req : Form
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");
        public Loan_req()
        {
            InitializeComponent();
        }

        private void btn_submitReq_Click(object sender, EventArgs e)
        {
            string sql = "insert into Loan(loan_num, loan_amount,laon_type, Cus_SSN, Branch_Number, Status,Employee_id) values(@loan_num, @loan_amount,@laon_type, @Cus_SSN, @Branch_Number, @Status,NULL)";
           
            SqlCommand cmd = new SqlCommand(sql, con);
            
            cmd.Parameters.AddWithValue("@loan_amount", txt_loanAmount.Text);
            cmd.Parameters.AddWithValue("@Cus_SSN", txt_CustomerSSN.Text);
            cmd.Parameters.AddWithValue("@laon_type", listBox1.SelectedItem?.ToString());
            cmd.Parameters.AddWithValue("@Branch_Number", txt_branchNum.Text);
            cmd.Parameters.AddWithValue("@loan_num", txt_loanNum.Text);
            cmd.Parameters.AddWithValue("@Status", "pending");
            //cmd.Parameters.AddWithValue("@Employee_id", null) ;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your request is sent successfully!");
            Customer_home form1 = new Customer_home();
            form1.Show();
            this.Hide();
        }
    }
}
