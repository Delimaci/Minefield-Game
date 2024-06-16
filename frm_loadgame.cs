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
    public partial class frm_loadgame : Form
    {
        Point mouseDownPoint = Point.Empty;
        public frm_loadgame()
        {
            InitializeComponent();
            this.Size = new Size(1420, 782);
            BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            Timer t1 = new Timer();
        }

        private void frm_Menu2_Load(object sender, EventArgs e)
        {
            //fade
         //   void fadeIn(object sender, EventArgs e)
         //   {
          //      if (Opacity >= 1)
                    //t1.Stop();   //this stops the timer if the form is completely displayed

        //        else
        //            Opacity += 0.03;
        //    }
            //timer
            Opacity = 0;
           // t1.Interval = 10;
           // t1.Tick += new EventHandler(fadeIn);
           // t1.Start();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Gab\Downloads\Bomb_Exploding-Sound_Explorer-68256487.wav");
            player.Play();

        }
       // void fadeIn(object sender, EventArgs e)
       // {
      ///      if (Opacity >= 1)
       //         t1.Stop();   //this stops the timer if the form is completely displayed

      //      else
       //         Opacity += 0.03;
       // }

        private void frm_Menu2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }

        private void frm_Menu2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }

        private void frm_Menu2_MouseMove(object sender, MouseEventArgs e)
        {
            {
                if (mouseDownPoint.IsEmpty)
                    return;
                Form f = sender as Form;
                f.Location = new Point(f.Location.X + (e.X - mouseDownPoint.X), f.Location.Y + (e.Y - mouseDownPoint.Y));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
 
