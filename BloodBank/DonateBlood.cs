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
//using System.Data;

namespace BloodBank
{
    public partial class DonateBlood : Form
    {
        public DonateBlood()
        {
            InitializeComponent();
            populate();
          
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PRACHI\Documents\BloodBankb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            String Query = "select * from DonarTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DonorDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void DonateBlood_Load(object sender, EventArgs e)
        {
            
        }

       
        int oldstock;
        private void GetStock(String Bgroup)
        {
            con.Open();
            string query = "select*from BloodTbl where BGroup'" + Bgroup + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                oldstock = Convert.ToInt32(dr["BStock"].ToString());

            }
           con.Close();
       }
        /*
        private void DonorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DNameTb.Text = DonorDGV.SelectedRows[0].Cells[1].Value.ToString();
            BGroupTb.Text = DonorDGV.SelectedRows[0].Cells[6].Value.ToString();
            GetStock(BGroupTb.Text);

        }*/
        int key = 0;
        private void Reset()
        {

         
            DNameTb.Text = "";
            BGroupTb.Text = "";
            key = 0;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(DNameTb.Text == "")
            {
                MessageBox.Show("Select a Donor");
            }
            else
            {
                try
                {
                    int stock = oldstock + 1;
                    string query = "Delete from DonarTbl where DNum =" + key + "";
                    //string query = "Update BloodTbl set BStock ='" + stock + "'Where BGroup ='"+BGroupTb.Text+"';";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Donation successfully");
                    con.Close();
                    Reset();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

       /* private void BloodStockDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DNameTb.Text = BloodStockDGV.SelectedRows[0].Cells[1].Value.ToString();
            BGroupTb.Text = BloodStockDGV.SelectedRows[0].Cells[6].Value.ToString();
        }*/

        private void label2_Click(object sender, EventArgs e)
        {
            Donor don = new Donor();
            don.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewDonors vd = new ViewDonors();
            vd.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            DonateBlood donb = new DonateBlood();
            donb.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patient Pat = new Patient();
            Pat.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewPatients VP = new ViewPatients();
            VP.Show();
            this.Hide();
        }

       

       /* private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfer bt = new BloodTransfer();
            bt.Show();
            this.Hide();
        }
       */
        private void label8_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void BloodStockDGV_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
           

 
        }

        

        private void DonorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_no = e.RowIndex;
            // MessageBox.Show(Convert.ToString( row_no));
            DNameTb.Text = Convert.ToString(DonorDGV[1, row_no].Value);
            BGroupTb.Text = Convert.ToString(DonorDGV[6, row_no].Value);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
