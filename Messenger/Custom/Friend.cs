using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger.Custom
{
    public partial class Friend : UserControl
    {
        private User user;
        public bool lol;


        public Friend()
        {
            InitializeComponent();

        }

        public Friend(String nameS)
        {
            InitializeComponent();
            button1.Text = nameS;
           // label1.Text = test.ToString();
            user = new User();
        }

        public Friend(int ar)
        {
            InitializeComponent();
            //if (pictureBox1.Visible == true)
            //    lol = true;
            //else
            //    lol = false;
        }

      

        private void Friend_Load(object sender, EventArgs e)
        {
           
        }

        private void Friend_Click(object sender, EventArgs e)
        {
           
        }

        public bool check = false;
        private void button1_Click(object sender, EventArgs e)
        {

            //if (check == false)
            //    pictureBox1.Visible = !check;
            //else
            //    pictureBox1.Visible = !check;

            //check = !check;
            
            if (check == false)
            { pictureBox1.Visible = true; check = true; lol = true; }
            else
            { pictureBox1.Visible = false;check = false; lol = false; }

        }
    }
}
