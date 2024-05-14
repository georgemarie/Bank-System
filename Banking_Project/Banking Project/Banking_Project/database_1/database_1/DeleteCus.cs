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
    public partial class DeleteCus : Form
    {
        public DeleteCus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=DESKTOP-PDK1VSK\\SQLEXPRESS; database=Banking ; integrated security = true";
            string query = "DELETE FROM Customer WHERE Cus_SSN = @RecordId";
            string query2 = "DELETE FROM User_ WHERE email = @email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command2 = new SqlCommand(query2, connection);
                command2.Parameters.AddWithValue("@email", txt_email.Text);
                connection.Open();
                int rowsAffected2 = command2.ExecuteNonQuery();
                connection.Close();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RecordId", int.Parse(txt_CusNum.Text));
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer Deleted Successfully!");
                


                

            }
        }
    }
    
}
