using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMinefield
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            {

                switch (e.KeyCode)
                {
                    case Keys.Right:
                        label388.Left += 1;
                        break;
                    case Keys.Left:
                        label388.Left -= 1;
                        break;
                }
            }
        }
    }
}
