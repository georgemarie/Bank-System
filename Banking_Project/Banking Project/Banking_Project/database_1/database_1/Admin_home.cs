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
    public partial class Admin_home : Form
    {
        public Admin_home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_bank add_bank = new Add_bank();
            add_bank.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_branch add_branch = new Add_branch();
            add_branch.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadLoans form2 = new LoadLoans();
            form2.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display_customers display_customers = new Display_customers();
            display_customers.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display_loans2 display_loans2 = new Display_loans2();
            display_loans2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SigninEmp signinEmp = new SigninEmp();
            signinEmp.Show();
        }
    }
}
