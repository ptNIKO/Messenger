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
using System.Runtime.InteropServices;


namespace Messenger
{
    public partial class Login : Form
    {

        private UserDAO userDAO;
        private User user;

        public Login()
        {
            InitializeComponent();
            userDAO = new UserDAO();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox3.Parent = pictureBox1;
            pictureBox4.Parent = pictureBox1;
            passwordText.ForeColor = Color.LightGray;
            NameText.ForeColor = Color.LightGray;
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message n = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref n);

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
            if (NameText.Text == "Login")
            {
                NameText.Text = "";
                NameText.ForeColor = Color.WhiteSmoke;
            }
        }

        private void NameText_Leave(object sender, EventArgs e)
        {
            if (NameText.Text == "")
            {
                NameText.Text = "Login";
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

        int adminMode = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox5.Focus();
            adminMode++;
            if (adminMode == 5)
            {
                label1.Visible = true;
            }
           

        }

        private void customImageButton2_MouseEnter(object sender, EventArgs e)
        {
            customImageButton3.Visible = true;
        }

        private void customImageButton2_MouseLeave(object sender, EventArgs e)
        {
            customImageButton3.Visible = false;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {

            if (clicked == true)
            {
                label2.Font = new Font("Microsoft Sans", 14, FontStyle.Underline);
            }
            else { label2.Font = new Font("Microsoft Sans", 14, FontStyle.Regular); }


        }

        private void label2_Click(object sender, EventArgs e)
        {
            SingUp singUp = new SingUp();
            singUp.Show();
            this.Hide();

            label2.Font = new Font(label2.Font.Name, label2.Font.SizeInPoints, FontStyle.Underline);
            clicked = true;

            if (WindowState == FormWindowState.Maximized)
                SingUp.ActiveForm.WindowState = FormWindowState.Maximized;

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            if (clicked == true)
            {
                label2.Font = new Font("Microsoft Sans", 11, FontStyle.Underline);
            }
            else { label2.Font = new Font("Microsoft Sans", 11); }
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


        public void Login_SizeChanged(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                user = userDAO.GetUser(NameText.Text, passwordText.Text);
                BigShaq1 BigShaq1 = new BigShaq1(user);
                BigShaq1.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Не правильный логин или пароль");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        #region Admin
        private void label1_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(Console);
        }
     
        private void Console()
        {
          
            if (AllocConsole())
            {           
                while (true)
                {
                    System.Console.WriteLine("Для выхода наберите exit.");
                    string output = System.Console.ReadLine();
                    if (output == "exit")
                        break;

              
                  

                }           
                FreeConsole();
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();
        #endregion
    }
}
