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
using Messenger.ServiceChat;


namespace Messenger
{
    public partial class BigShaq1 : Form, IServiceChatCallback
    {
        private User user;
      

        public BigShaq1(User user)
        {
            InitializeComponent();
            this.user = user;
           
        }
        public BigShaq1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = user.FirstName;
            SpawnGroups();
        }

        public void SpawnGroups()
        {
            string nameGroups = "";
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
            SqlCommand cmd = new SqlCommand("Select * From Lobby", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                nameGroups = dr.GetString(1);
                Groups puc = new Groups(nameGroups);                
                flowLayoutPanel1.Controls.Add(puc);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message n = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref n);

            if (e.Button == MouseButtons.Left)
            {
                WindowState = FormWindowState.Normal; max = true;

            }

        }

        bool max = true;
        private bool clicked = false;

        private void userControl11_Click(object sender, EventArgs e)
        {
            if (max == true) { WindowState = FormWindowState.Maximized; max = false; }
            else
            { WindowState = FormWindowState.Normal; max = true; }

        }


        private void userControl11_MouseEnter(object sender, EventArgs e)
        {
            userControl11.BackColor = Color.FromArgb(211, 211, 211);
        }

        private void userControl11_MouseLeave(object sender, EventArgs e)
        {
            userControl11.BackColor = Color.WhiteSmoke;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox5.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox5.Focus();
        }

        private void customImageButton2_MouseEnter(object sender, EventArgs e)
        {
            customImageButton3.Visible = true;
        }

        private void customImageButton2_MouseLeave(object sender, EventArgs e)
        {
            customImageButton3.Visible = false;
        }


        private void customImageButton2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;//Свернуть окно
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(211, 211, 211);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.WhiteSmoke;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddFriend af = new AddFriend();
            // af.Show();
            af.StartPosition = FormStartPosition.CenterParent;        
            af.ShowDialog();
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateLB af = new CreateLB();
            // af.Show();
            af.StartPosition = FormStartPosition.CenterParent;
            af.ShowDialog();
        }
   

        private void pictureBox4_Click(object sender, EventArgs e)
        {
                          
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SpawnGroups();
        }

        ///
        bool isConnected = false;
        ServiceChatClient client;
        int ID;

        void ConnectUser()
        {
            if (!isConnected)
            {
                client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this));
                ID = client.Connect(label1.Text);
                isConnected = true;
            }
        }

        void DisconnectUser()
        {
            if (isConnected)
            {
                client.Disconnect(ID);
                client = null;
                isConnected = false;
            }

        }

  

        public  void GoConection()
        {
            if (isConnected)
            {
                DisconnectUser();
            }
            else
            {
                ConnectUser();
            }

        }

        public void MsgCallback(string msg)
        {
            listBox1.Items.Add(msg);         
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (client != null)
                {
                    client.SendMsg(textBox1.Text, ID);
                    textBox1.Text = string.Empty;
                }
            }
        }
    }
}
