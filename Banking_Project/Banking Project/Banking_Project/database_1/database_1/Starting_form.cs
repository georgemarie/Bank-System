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
    public partial class Starting_form : Form
    {
        public Starting_form()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
