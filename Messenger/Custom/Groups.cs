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
    public partial class Groups : UserControl
    {
      

        public Groups()
        {
            InitializeComponent();
            
        }

        public Groups(String nameGroups)
        {
            InitializeComponent();
            button1.Text = nameGroups;
        

        }

       

        private void Groups_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            BigShaq1 bs = (BigShaq1)Application.OpenForms["BigShaq1"];
            bs.GoConection();    
        }
    }
}
