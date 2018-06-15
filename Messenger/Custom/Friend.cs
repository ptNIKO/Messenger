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

        public Friend()
        {
            InitializeComponent();

        }

        public Friend(String nameS)
        {
            InitializeComponent();
            button1.Text = nameS;
            user = new User();
        }

        private void Friend_Load(object sender, EventArgs e)
        {
           
        }

        private void Friend_Click(object sender, EventArgs e)
        {
           
        }

        bool check = false;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (check == false)
                pictureBox1.Visible = !check;                           
            else           
                pictureBox1.Visible = !check;
            
                check = !check;
            
        }
    }
}
