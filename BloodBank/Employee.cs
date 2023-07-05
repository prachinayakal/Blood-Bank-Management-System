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

namespace BloodBank
{
    public partial class Employee : Form
    {
        //private object con;

        public Employee()
        {
            InitializeComponent();
            populate();
        }

         SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PRACHI\Documents\BloodBankb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        private void Reset()
        {
            EmpNameTb.Text = "";
            EmpPassTb.Text = "";
            key = 0;
        }
        private void populate()
        {
            con.Open();
            String Query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpPassTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String query = "Insert into EmployeeTbl values('" + EmpNameTb.Text + "'," + EmpPassTb.Text + ")";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee saved successfully");
                    con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key;

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_no = e.RowIndex;
            EmpNameTb.Text = Convert.ToString(EmpDGV[1, row_no].Value);
            EmpPassTb.Text = Convert.ToString(EmpDGV[2, row_no].Value);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (key == 0)
            {
                MessageBox.Show("Select the Employee to Delete");
            }
            else
            {
                try
                {
                    string query = "Delete from EmployeeTb where EmpNum =" + key + ";";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted successfully");
                    con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpPassTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "Update EmployeeTbl set EmpName =" + EmpNameTb.Text + " = " + EmpPassTb.Text + ";";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Edited successfully");
                    con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
