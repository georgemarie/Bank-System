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
using System.Net;
using System.Xml.Linq;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace database_1
{
    public partial class Status_form : Form
    {
        public Status_form()
        {
            InitializeComponent();
            button2.Visible = false;
        }

        public int TextBoxValue()
        {
            return int.Parse(txt_loanNum.Text);
        }
        private string loanStatus = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select loan_num, loan_amount, laon_type, Branch_Number, Status from Loan Where loan_num Like'%" + txt_loanNum.Text + "%'", con);

                SqlDataAdapter reader = new SqlDataAdapter();
                DataTable dt = new DataTable();
                reader.SelectCommand = cmd;
                dt.Clear();
                reader.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                button2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Load Number or LOAN REJECTED");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Status from Loan Where loan_num Like'%" + txt_loanNum.Text + "%'", con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    loanStatus = reader["Status"].ToString();
                }
            }
            if (loanStatus == "OK")
            {
                ChooseAcc chooseAcc = new ChooseAcc();
                chooseAcc.set_loanNum(TextBoxValue());
                chooseAcc.Show();
                SqlCommand updateLoanStatus = new SqlCommand("update Loan set Status = 'Closed'  Where loan_num Like'%" + txt_loanNum.Text + "%' ", con);
                updateLoanStatus.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Loan Type is not OK");
            }

        }
    }
}
