using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database_1
{
    public partial class Customer_home : Form
    {
        public Customer_home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Status_form status_form = new Status_form();
            status_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loan_req loan = new Loan_req();
            loan.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateAcc newAcc = new CreateAcc();
            newAcc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayAccs accs = new DisplayAccs();
            accs.Show();
        }
    }
}
