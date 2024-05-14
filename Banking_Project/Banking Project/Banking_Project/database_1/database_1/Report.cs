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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BranchNoCus selectst1 = new BranchNoCus();
            selectst1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BranchNoEmp selectst2 = new BranchNoEmp();
            selectst2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MaxLoansByEmp selectst3 = new MaxLoansByEmp();
            selectst3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MaxLoansByCus selectst4 = new MaxLoansByCus();
            selectst4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CusNoLoans selectst5 = new CusNoLoans();
            selectst5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumOfEmpByCus selectst6 = new NumOfEmpByCus();
            selectst6.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
