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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PRACHI\Documents\BloodBankb.mdf;Integrated Security=True;Connect Timeout=30");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from EmployeeTbl where EmpId='"+EmpIdTb.Text+"'  and EmpPass='"+EmpPassTb.Text+"'",con);
            SqlCommandBuilder cmdb = new SqlCommandBuilder(sda);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                BBMS bb = new BBMS();
                bb.Show();
                this.Hide();
                //Mainform Main = new Mainform();
                //Main.Show();
                //this.Hide();
                //con.Close();
            }
            else
            {
                MessageBox.Show("Wrong UserName or Password");
            }
            con.Close();

           

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AdminLogin Adm = new AdminLogin();
            Adm.Show();
            this.Hide();
        }
    }
}
