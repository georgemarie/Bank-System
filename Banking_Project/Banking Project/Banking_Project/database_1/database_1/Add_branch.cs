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
    public partial class Add_branch : Form
    {
        public Add_branch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                SqlConnection sqlConnection = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.CommandText = "INSERT INTO BRANCH VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Branch was successfully added");
            //}
            //catch (Exception ex)
            //{
                //MessageBox.Show(ex.Message);
            //}

        }

    }
}
