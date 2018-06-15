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
    public partial class AddFriend : Form
    {
        public String nameS = "";
        public AddFriend()
        {
            InitializeComponent();
            string connStr = "Data Source=BOS;Initial Catalog=Messenger;Integrated Security=True";
          
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
                nameS = dr.GetString(1);
                Friend puc= new Friend(nameS);
                flowLayoutPanel1.Controls.Add(puc);
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
    }
}
