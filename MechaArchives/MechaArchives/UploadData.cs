using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechaArchives
{
    public partial class UploadData : Form
    {
        public UploadData()
        {
            InitializeComponent();
        }

        private void numberOnlyCheck(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //If the key pressed is a number or control (enter, backspace, etc)
            {
                e.Handled = true; //Allow it. If not, don't write it
            }
        }
    }
}
