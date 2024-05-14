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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace database_1
{
    public partial class ChooseAcc : Form
    {
        SqlConnection cnct = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true");
    
        public ChooseAcc()
        {
            InitializeComponent();
        }
        private int loanNum;
        public void set_loanNum(int input)
        {
            loanNum = input;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            // Retrieve the current balance from the Account entity
            string getBalanceQuery = "SELECT Balance FROM Account WHERE account_number = @accountID";
            SqlCommand getBalanceCommand = new SqlCommand(getBalanceQuery, cnct);
            cnct.Open();
            getBalanceCommand.Parameters.AddWithValue("@accountID", int.Parse(txt_AccNum.Text));
            float currentBalance = Convert.ToSingle(getBalanceCommand.ExecuteScalar());

            // Retrieve the loan amount from the Loan entity
            string getLoanAmountQuery = "SELECT loan_amount FROM Loan WHERE loan_num = @loanID";
            SqlCommand getLoanAmountCommand = new SqlCommand(getLoanAmountQuery, cnct);
            getLoanAmountCommand.Parameters.AddWithValue("@loanID", loanNum);
            float loanAmount = Convert.ToSingle(getLoanAmountCommand.ExecuteScalar());

            // Perform the calculation
            float updatedBalance = currentBalance + loanAmount;

            // Update the balance attribute in the Account entity
            string updateBalanceQuery = "UPDATE Account SET Balance = @updatedBalance WHERE account_number = @accountID";
            SqlCommand updateBalanceCommand = new SqlCommand(updateBalanceQuery, cnct);
            updateBalanceCommand.Parameters.AddWithValue("@updatedBalance", updatedBalance);
            updateBalanceCommand.Parameters.AddWithValue("@accountID", int.Parse(txt_AccNum.Text));
            updateBalanceCommand.ExecuteNonQuery();
            MessageBox.Show("Amount Recieved successful");
            cnct.Close();
            this.Close();

        }

        
    }
}
