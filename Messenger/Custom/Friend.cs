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
            label1.Text = nameS;
            user = new User();
        }

        private void Friend_Load(object sender, EventArgs e)
        {

        }
    }
}
