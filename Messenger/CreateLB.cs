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
using Messenger.Custom;

namespace Messenger
{
    public partial class CreateLB : Form
    {
        
        public String nameS = "";
        public int test;
        List<int> arr = new List<int>();//Array UserId

        public CreateLB()
        {
            InitializeComponent();
            string connStr = @"Data Source=BOS;Initial Catalog=Messenger;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            SqlCommand cmd = new SqlCommand("Select * From Users", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

              //  test = dr.GetInt32(0);
                //
                nameS = dr.GetString(1);
                Friend puc = new Friend(nameS);
                flowLayoutPanel1.Controls.Add(puc);
               // if (puc.check == true)//false
               //     arr.Add(test);

            }

        }
      
        private void customImageButton2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
        }

        private void customImageButton2_MouseEnter(object sender, EventArgs e)
        {
            customImageButton3.Visible = true;
        }

        private void customImageButton2_MouseLeave(object sender, EventArgs e)
        {
            customImageButton3.Visible = false;
        }

        bool max = true;
        private void AddFriend_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message n = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref n);

            if (e.Button == MouseButtons.Left)
            {
                WindowState = FormWindowState.Normal; max = true;
            }
        }

        private void AddFriend_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Focus();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            /*  foreach(int x in arr)
             {

             }*/

            try
            {
                string conStr = @"Data Source=BOS;Initial Catalog=Messenger;Integrated Security=True";
                SqlConnection coon = new SqlConnection(conStr);
                try
                {
                    coon.Open();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                SqlCommand cmd = new SqlCommand("Insert Into Lobby (Name) Values (@name)", coon);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = placeHolder2.Text;
                //cmd.Parameters.Add("@userId", SqlDbType.Int).Value = x;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                coon.Close();
                MessageBox.Show($"Группа <<{placeHolder2.Text}>> создана успешно!");
               
                this.Hide();

        }
            catch
            {
                MessageBox.Show("Такое имя уже существует");
            }



}

        

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            string connStr = @"Data Source=BOS;Initial Catalog=Messenger;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            SqlCommand cmd = new SqlCommand("Select * From Users", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                test = dr.GetInt32(0);

                Friend puc = new Friend();
                if (puc.lol == true)//false
                    arr.Add(test);

            }
        }
    }
}
