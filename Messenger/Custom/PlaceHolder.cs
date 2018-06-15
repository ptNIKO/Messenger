using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger
{
    public partial class PlaceHolder : TextBox
    {
        public PlaceHolder()
        {
            InitializeComponent();
            BorderStyle = BorderStyle.None;
             
            BackColor = Color.DodgerBlue;
            Font = new Font("Microsoft Sans", 11);
            Size = new Size(205,20);
            Multiline = true;
            TabStop = false;
            Anchor = (AnchorStyles.None);
        }
       

        public string PlaceText;
        public Color colorText;

        public string TextPalace
        {
            get { return PlaceText; }
            set { PlaceText = value; }
        }

        public Color ColorText
        {
            get { return colorText; }
            set { colorText = value; }
        }

        private void PlaceHolder_Enter(object sender, EventArgs e)
        {
            if (Text == PlaceText)
            {
                Text = "";               
                ForeColor = colorText;
            }
        }

        private void PlaceHolder_Leave(object sender, EventArgs e)
        {
            if (Text == "")
            {
                Text = PlaceText;
                ForeColor = Color.Gray;
                
            }
        }
    }
}
