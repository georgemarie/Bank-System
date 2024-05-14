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
    public partial class AddCus : Form
    {
        SqlConnection cnct = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");
        public AddCus()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "insert into User_ values (@name , @Gender ,@password,@email , @country ,@phone) ";
                SqlCommand cmnd = new SqlCommand(sql1, cnct);
                cmnd.Parameters.AddWithValue("@SSN", text_ssn.Text);
                cmnd.Parameters.AddWithValue("@name", text_name.Text);
                cmnd.Parameters.AddWithValue("@phone", text_phone.Text);
                cmnd.Parameters.AddWithValue("@address", text_address.Text);
                cmnd.Parameters.AddWithValue("@password", text_password.Text);
                cmnd.Parameters.AddWithValue("@email", text_email.Text);
                cmnd.Parameters.AddWithValue("@Branch", text_branch.Text);
                cmnd.Parameters.AddWithValue("@Gender", text_gender.Text);
                cmnd.Parameters.AddWithValue("@country", text_country.Text);
                cnct.Open();
                cmnd.ExecuteNonQuery();
                string sql2 = "insert into Customer values (@SSN,@name,@phone,@address,@password,@email,@Branch)";
                cmnd = new SqlCommand(sql2, cnct);
                cmnd.Parameters.AddWithValue("@SSN", text_ssn.Text);
                cmnd.Parameters.AddWithValue("@name", text_name.Text);
                cmnd.Parameters.AddWithValue("@phone", text_phone.Text);
                cmnd.Parameters.AddWithValue("@address", text_address.Text);
                cmnd.Parameters.AddWithValue("@password", text_password.Text);
                cmnd.Parameters.AddWithValue("@email", text_email.Text);
                cmnd.Parameters.AddWithValue("@Branch", text_branch.Text);
                cmnd.Parameters.AddWithValue("@Gender", text_gender.Text);
                cmnd.Parameters.AddWithValue("@country", text_country.Text);
                cmnd.ExecuteNonQuery();
                //cnct.Open();

                MessageBox.Show("Customer Added successful!");
                cnct.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void text_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
