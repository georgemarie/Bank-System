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
    public partial class Loan_Options : Form
    {
        SqlConnection cnct = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");
       
        private string empName = string.Empty;
        public Loan_Options()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loan_Options_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankingDataSet1.Loan' table. You can move, or remove it, as needed.
            this.loanTableAdapter1.Fill(this.bankingDataSet1.Loan);
            // TODO: This line of code loads data into the 'bankingDataSet.Loan' table. You can move, or remove it, as needed.
            //this.loanTableAdapter.Fill(this.bankingDataSet.Loan);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Loan SET Status = @status, Employee_id = @Employee_id, Employee_Name = @Employee_name WHERE loan_num = @loan_num";
            SqlCommand cmnd = new SqlCommand(sql, cnct);
            cmnd.Parameters.AddWithValue("@loan_num", textBox1.Text);
            cmnd.Parameters.AddWithValue("@status", listBox1.SelectedItem?.ToString());
            cmnd.Parameters.AddWithValue("@Employee_id", textBox3.Text);

            string sqlName = "SELECT Name FROM Employee WHERE id = @Employee_id";
            SqlCommand cmnd2 = new SqlCommand(sqlName, cnct);
            cmnd2.Parameters.AddWithValue("@Employee_id", textBox3.Text);

            cnct.Open();

            object result = cmnd2.ExecuteScalar();
            if (result != null)
            {
                string empName = result.ToString();
                cmnd.Parameters.AddWithValue("@Employee_name", empName);
            }

            int rowsAffected = cmnd.ExecuteNonQuery();

            cnct.Close();










            MessageBox.Show("Loan status is changed successfuly!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.loanTableAdapter1.Fill(this.bankingDataSet1.Loan);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
