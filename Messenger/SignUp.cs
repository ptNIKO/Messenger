using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Messenger
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();



        }



        private void Form1_Load(object sender, EventArgs e)
        {
         
            passwordText.ForeColor = Color.LightGray;
            NameText.ForeColor = Color.LightGray;
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


        private void NameText_Enter(object sender, EventArgs e)
        {
            if (NameText.Text == "SignUp")
            {
                NameText.Text = "";
                NameText.ForeColor = Color.WhiteSmoke;


            }
        }

        private void NameText_Leave(object sender, EventArgs e)
        {
            if (NameText.Text == "")
            {
                NameText.Text = "SignUp";
                NameText.ForeColor = Color.LightGray;
            }
        }

        private void passwordText_Enter(object sender, EventArgs e)
        {

            if (passwordText.Text == "Password")
            {
                passwordText.Text = "";
                passwordText.ForeColor = Color.WhiteSmoke;
                passwordText.PasswordChar = '●';
            }





        }

        private void passwordText_Leave(object sender, EventArgs e)
        {

            if (passwordText.Text == "")
            {
                passwordText.Text = "Password";
                passwordText.ForeColor = Color.LightGray;
                passwordText.PasswordChar = '\0';
            }

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

        private void Login_Move(object sender, EventArgs e)
        {

        }


    }
}
