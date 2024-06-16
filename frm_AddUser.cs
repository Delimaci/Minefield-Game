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
    public partial class frm_AddUser : Form
    {
        Point mouseDownPoint = Point.Empty;
        public static string username;
        public frm_AddUser()
        {
          InitializeComponent();
            this.Size = new Size(1420, 782);
            BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            Timer t1 = new Timer();

        }

        private void frm_AddUser_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter a Username!");
            }
            else
            {
                username = textBox1.Text;
                Form1 settingsForm = new Form1();
                  settingsForm.Show();
                 this.Visible = false;
            }
           
        }
    }
}
