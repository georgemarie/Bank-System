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
    public partial class UpdateCus : Form
    {
        SqlConnection cnct = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");
        public UpdateCus()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string sql = "Update Customer set cus_name=@name,cus_phone=@phone,cus_address=@address where Cus_SSN = @SSN";
            SqlCommand cmnd = new SqlCommand(sql, cnct);
            cmnd.Parameters.AddWithValue("@SSN", text_ssn_up.Text);
            cmnd.Parameters.AddWithValue("@name", text_name_up.Text);
            cmnd.Parameters.AddWithValue("@phone", text_phone_up.Text);
            cmnd.Parameters.AddWithValue("@address", text_address_up.Text);
            cmnd.Parameters.AddWithValue("@password", text_password_up.Text);
            cmnd.Parameters.AddWithValue("@email", text_email_up.Text);
            cnct.Open();
            cmnd.ExecuteNonQuery();
            cnct.Close();
            MessageBox.Show("Customer is updated successfuly!");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankingDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.bankingDataSet.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.bankingDataSet.Customer);
        }
    }
}
