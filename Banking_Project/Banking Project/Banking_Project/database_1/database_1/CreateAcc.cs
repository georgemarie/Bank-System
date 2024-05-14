using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database_1
{
    public partial class CreateAcc : Form
    {
        SqlConnection cnct = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");
        
        public CreateAcc()
        {
            InitializeComponent();
        }

        public void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "insert into Account (account_number, account_type, balance, Cus_SSN) values (@num , @type ,@balance, @ssn) ";
                SqlCommand cmnd = new SqlCommand(sql1, cnct);
                cmnd.Parameters.AddWithValue("@num", text_number.Text);
                cmnd.Parameters.AddWithValue("@balance", float.Parse(text_balance.Text));
                cmnd.Parameters.AddWithValue("@type", listBox1.SelectedItem?.ToString());
                cmnd.Parameters.AddWithValue("@ssn", text_ssn.Text);
                cnct.Open();
                cmnd.ExecuteNonQuery();

                MessageBox.Show("Account created successful!");


                cnct.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CreateAcc_Load(object sender, EventArgs e)
        {

        }

        private void type_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
