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
using System.ComponentModel.DataAnnotations;


namespace Messenger
{
    public partial class SingUp : Form
    {
         private User user;
         private UserDAO userDAO;

        public SingUp()
        {
            InitializeComponent();
            //this.userDAO = userDAO;
             userDAO = new UserDAO();
             user = new User();

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
            if (NameText.Text == "First Name")
            {
                NameText.Text = "";
                NameText.ForeColor = Color.WhiteSmoke;
            }
        }

        private void NameText_Leave(object sender, EventArgs e)
        {
            if (NameText.Text == "")
            {
                NameText.Text = "First Name";
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
                pictureBox4.BackColor = Color.Azure;
                pictureBox6.BackColor = Color.Azure;
                pictureBox7.BackColor = Color.Azure;
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
            Application.Exit();//Закрыть форму
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

            if (WindowState == FormWindowState.Maximized)
                Login.ActiveForm.WindowState = FormWindowState.Maximized;
        }


        /*SQL -----------*/
        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                user.FirstName = NameText.Text;
                user.Email = placeHolder1.Text;
                user.Password = passwordText.Text;
                userDAO.AddUser(user);
                MessageBox.Show("Регистрация прошла успешно!");
            }
            catch
            {
                MessageBox.Show("Такой Email уже существует");
            }
           

            //int logi = 0;
            //using (SqlConnection con = new SqlConnection(Properties.Settings.Default.Mess))//Подключение к БД
            //{
            //    con.Open();
            //    SqlCommand cmd = con.CreateCommand();
            //    cmd.CommandText = "SELECT Count(*) FROM Users WHERE Email='" + placeHolder1.Text + "'";//Проверка на наличие одинакого Email
            //    SqlDataReader read = cmd.ExecuteReader();
            //    while (read.Read())
            //    {
            //        logi = Convert.ToInt32(read[0]);

            //    }
            //    con.Close();
            //}

            //if (logi == 1)
            //{
            //    MessageBox.Show("Такой Email уже существует");
            //}


            //else if (NameText.Text != "First Name" && passwordText.Text != "Password" && placeHolder1.Text != "Email")
            //{
            //    using (SqlConnection con = new SqlConnection(Properties.Settings.Default.Mess))
            //    {
            //        con.Open();
            //        SqlCommand cmd = con.CreateCommand();
            //        cmd.CommandText = "INSERT INTO Users (FirstName, Email, Password) Values('" + NameText.Text + "', '" + placeHolder1.Text + "', '" + passwordText.Text + "')";
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //    }
            //    panel1.BackColor = Color.White;
            //    panel2.BackColor = Color.White;
            //    panel3.BackColor = Color.White;
            //    MessageBox.Show("Регистрация прошла успешно!");
            //}
            //else
            //{
            //    panel1.BackColor = Color.Red;
            //    panel2.BackColor = Color.Red;
            //    panel3.BackColor = Color.Red;
            //}

            /*--------------------------------------------------------------------------------------------------------------------------------
             -------------------------------------------------------------------------------------------------------------------------------- */

        }

        private void passwordText_TextChanged(object sender, EventArgs e)//Проверка пароля на сложнось(граф.)
        {
            if (passwordText.Text == "")
            {
                pictureBox4.BackColor = Color.Azure;
               
            }
           else if (passwordText.TextLength <= 3)//Лёгкий пароль
                pictureBox4.BackColor = Color.Red;

            if (passwordText.TextLength > 3)
            {
                pictureBox6.BackColor = Color.Orange;
                pictureBox4.BackColor = Color.Red;
            }
            else if (passwordText.TextLength <= 4)//Средний пароль
                pictureBox6.BackColor = Color.Azure; 

            if (passwordText.TextLength >= 6)//Сложный пароль
                pictureBox7.BackColor = Color.LimeGreen;
              else
                  pictureBox7.BackColor = Color.Azure;
           
            
           if (passwordText.TextLength > 1)
            {
                panel3.BackColor = Color.White;
            }

        }


        bool vis = true;
        private void pictureBox8_Click(object sender, EventArgs e)//Подсказка на пароль
        {
            if (vis == true)
            { label1.Visible = true; vis = false; }
            else
            { label1.Visible = false;vis = true; }

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
           
            if ( NameText.TextLength > 1)
            {
                panel1.BackColor = Color.White;
            }
           

        }

        private void placeHolder1_TextChanged(object sender, EventArgs e)
        {
            if  (placeHolder1.TextLength > 1)
            {
                panel2.BackColor = Color.White;
            }

            if (!new EmailAddressAttribute().IsValid(placeHolder1.Text))
            {
                panel2.BackColor = Color.Red;
              // менять цвет линии 
            }
            else
                panel2.BackColor = Color.White;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        bool test = false;
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            test = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (test == true)
            {
                pictureBox3.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox3.Refresh();
            }
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            test = false;
            
        }
    }
}
 