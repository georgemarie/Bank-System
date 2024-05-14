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
    public partial class Employee_home : Form
    {
        public Employee_home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCus form1 = new AddCus();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loan_Options loan = new Loan_Options();
            loan.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser();
            updateUser.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteCus form = new DeleteCus();
            form.Show();
        }
    }
}
