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
    public partial class UpdateEmp : Form
    {
        SqlConnection cnct = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");
        public UpdateEmp()
        {
            InitializeComponent();
        }

        private void UpdateEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankingDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bankingDataSet.Employee);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.bankingDataSet.Employee);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Update Employee set Name=@name,phone=@phone,Address=@address where id = @ID";
                SqlCommand cmnd = new SqlCommand(sql, cnct);
                cmnd.Parameters.AddWithValue("@ID", text_id_up.Text);
                cmnd.Parameters.AddWithValue("@name", text_name_up.Text);
                cmnd.Parameters.AddWithValue("@phone", text_phone_up.Text);
                cmnd.Parameters.AddWithValue("@address", text_address_up.Text);
                cnct.Open();
                cmnd.ExecuteNonQuery();
                cnct.Close();
                MessageBox.Show("Employee is updated successfuly!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
