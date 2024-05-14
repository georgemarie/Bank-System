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
    public partial class DisplayAccs : Form
    {
        SqlConnection cnct = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");

        public DisplayAccs()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView_num.GridLines = true;
            listView_num.View = View.Details;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView_num.Columns.Add("Account number", 100);
            listView_num.Columns.Add("Account type", 100);
            listView_num.Columns.Add("balance", 100);
            listView_num.View = View.Details;

            cnct.Open();
            string sql = "select * from Account ";
            SqlDataAdapter dataA = new SqlDataAdapter(sql, cnct);
            DataTable dataT = new DataTable();
            dataA.Fill(dataT);
            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                DataRow dr = dataT.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["account_number"].ToString());
                listitem.SubItems.Add(dr["account_type"].ToString());
                listitem.SubItems.Add(dr["balance"].ToString());
                listView_num.Items.Add(listitem);
            }
            cnct.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "server=DESKTOP-PDK1VSK\\SQLEXPRESS; database=Banking ; integrated security = true";
            string query = "DELETE FROM Account WHERE account_number = @RecordId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RecordId", int.Parse(textBox1.Text));
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                this.Close();
                MessageBox.Show("Account Deleted Successfully!");

            }
        }
    }
}
