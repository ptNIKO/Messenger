using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyImageButton
{
    public partial class UserControl1 : PictureBox
    {
        public UserControl1()
        {
            InitializeComponent();
            //if (Messenger.Login.BS == true) { this.Image = NormalImage; qwe = true; }
        }
       public Image NormalImage;
       public Image hoverImage;

        public Image ImageNormal
        {
            get { return NormalImage; }
            set { NormalImage = value; }
        }

        public Image ImageHover
        {
            get { return hoverImage; }
            set { hoverImage = value; }
        }

        

        private void CustomImageButton_Click(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }


        bool qwe = true;
      


        private void UserControl1_Click(object sender, EventArgs e)
        {
            if(qwe == true)
            { this.Image = hoverImage; qwe = false; }
             else
            { this.Image = NormalImage; qwe = true; }
        }

    }

}
