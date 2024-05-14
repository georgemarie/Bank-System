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
    public partial class SigninEmp : Form
    {
        SqlConnection cnct = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");
        public SigninEmp()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "insert into User_ values (@name , @Gender ,@password,@email , @country ,@phone) ";
                SqlCommand cmnd = new SqlCommand(sql1, cnct);
                cmnd.Parameters.AddWithValue("@ID", text_id.Text);
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
                string sql2 = "insert into Employee values (@ID, @address,@phone,@name,@password,@email,@Branch)";
                cmnd = new SqlCommand(sql2, cnct);

                cmnd.Parameters.AddWithValue("@ID", text_id.Text);
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

                MessageBox.Show("Employee is added successfuly!");
                cnct.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
