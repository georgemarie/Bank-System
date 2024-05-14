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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if((text_email.Text=="admin@gmail.com") && (text_password.Text == "123"))
            {
                Admin_home admin_Home = new Admin_home();
                admin_Home.Show();
            } else {
                using (SqlConnection connection = new SqlConnection(@"server=DESKTOP-PDK1VSK\SQLEXPRESS; database=Banking ; integrated security = true"))
                {
                    connection.Open();

                    string query = "SELECT * FROM User_ WHERE email = @Email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", text_email.Text);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read(); // Read the first row

                        string storedPassword = reader["Password"].ToString();

                        if (text_password.Text == storedPassword)
                        {
                            reader.Close();
                            MessageBox.Show("Login successful");
                            string empQuery = "SELECT * FROM Employee WHERE email = @empEmail";
                            SqlCommand empCommand = new SqlCommand(empQuery, connection);
                            empCommand.Parameters.AddWithValue("@empEmail", text_email.Text);
                            SqlDataReader empReader = empCommand.ExecuteReader();
                            if (empReader.HasRows)
                            {
                                if (empReader.Read())  // Call Read() to advance to the first row
                                {
                                    string storedMail = empReader["email"].ToString();
                                    Employee_home employee_Home = new Employee_home();
                                    employee_Home.Show();
                                }
                                else
                                {
                                    Customer_home customer_Home = new Customer_home();
                                    customer_Home.Show();
                                }
                            }
                            else
                            {
                                Customer_home customer_Home = new Customer_home();
                                customer_Home.Show();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found");
                    }


                    reader.Close();
                }
            }


        }
    }
}
