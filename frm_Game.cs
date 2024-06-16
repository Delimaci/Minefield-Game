using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectMinefield
{
    public partial class Form1 : Form
    {
        public static string Colour;
        public static string passingColour;

        Point mouseDownPoint = Point.Empty;
        int atCol = 10; //dv
        int atRow = 19;

        int atCol2 = 9; //saber
        int atRow2 = 0;

        int atCol3 = 9; //dvwithsb
        int atRow3 = 0;

        //level

        int count = 1;

        Timer t1 = new Timer();
        bool[,] bombs = new bool[20, 20];

        //using method in another form
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; //allows keyboard


        }
        //fade
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed

            else
                Opacity += 0.03;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_key.Text = frm_Controls.passingtext;
            lbl_user.Text = frm_AddUser.username;

            if (lbl_key.Text == "Keyboard") //if user clicked keyboard in settings form then allows also allows use of arrow keys:
            {
                frm_Controls frm = (frm_Controls)Application.OpenForms["frm_Controls"];
                frm.label1.BackColor = Color.Red;
            }

            //timer
            Opacity = 0;
            t1.Interval = 10;
            t1.Tick += new EventHandler(fadeIn);
            t1.Start();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Gab\Downloads\Bomb_Exploding-Sound_Explorer-68256487.wav");
            player.Play();

            //  this.Location = new Point(980, 283);
            button5.Visible = false;
            //atRow = 19;
            //atCol = 10;
            showSpriteAt(atCol, atRow);
            showSaberAt(atCol, atRow);
            plantBombs(10);
            KeyPreview = true;

            

        }


        //function to return Label at (atCol, atRowl)
        private Label getLabel(int atCol, int atRow)
        {

            int k = atRow * 20 + atCol + 1;
            string s = "label" + k.ToString();

            foreach (Control c in panel1.Controls)
            {
                if (c.GetType() == typeof(System.Windows.Forms.Label))
                {
                    if (c.Name == s)
                    {
                        return (Label)c;
                    }
                }
            }
            return null;
        }

        private void showSpriteAt(int atCol, int atRow)
        {
            Label lbl = getLabel(atCol, atRow);     //get label at (atCol,atRow)
            lbl.BackColor = Color.White;            //set its backcolour to white
            lbl.Image = Properties.Resources.DarthVader;     //set it to show an image 

        }

        private void DVSaber(int atCol, int atRow)
        {
            Label lbl = getLabel(atCol3, atRow3);     //get label at (atCol,atRow)
            lbl.BackColor = Color.White;            //set its backcolour to white
            lbl.Image = Properties.Resources.DVwithS;     //set it to show an image 

        }

        private void showSaberAt(int atCol, int atRow)
        {
            Label lbl = getLabel(atCol2, atRow2);     //get label at (atCol,atRow)
            lbl.BackColor = Color.White;            //set its backcolour to white
            lbl.Image = Properties.Resources.LightSaber_Small;
        }

        private void hideSpriteAt(int atCol, int atRow)
        {
            Label lbl = getLabel(atCol, atRow);
            lbl.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (atRow > 0)
            {
                hideSpriteAt(atCol, atRow);
                atRow--;
                showSpriteAt(atCol, atRow);
                amIDead(atCol, atRow);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (atRow < 19)
            {
                hideSpriteAt(atCol, atRow);
                atRow++;
                showSpriteAt(atCol, atRow);
                amIDead(atCol, atRow);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (atCol < 19)
            {
                hideSpriteAt(atCol, atRow);
                atCol++;
                showSpriteAt(atCol, atRow);
                amIDead(atCol, atRow);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (atCol < 19)
            {
                hideSpriteAt(atCol, atRow);
                atCol--;
                showSpriteAt(atCol, atRow);
                amIDead(atCol, atRow);
            }



        }
        private void plantBombs(int target)
        {

            Random r = new Random(); //create random num generator

            int tryCol, tryRow;
            int setSoFar = 0;

            Array.Clear(bombs, 0, bombs.Length);

            do
            {
                tryCol = r.Next(0, 20);
                tryRow = r.Next(0, 19);
                if (!bombs[tryCol, tryRow])
                {
                    bombs[tryCol, tryRow] = true;
                    setSoFar++;
                }
            } while (setSoFar < target);
        }

        private int bombCount(int atCol, int atRow)
        {
            int sofar = 0;



            if (atCol > 0)
            {
                if (bombs[atCol - 1, atRow])
                    sofar++;
            }
            if (atCol < 18)
            {
                if (bombs[atCol + 1, atRow])
                    sofar++;
            }
            if (atRow < 18)
            {
                if (bombs[atCol, atRow + 1])
                    sofar++;
            }
            return sofar;



        }

        private void showBombs() //shows the bombs if died
        {

            Label lbl;
            for (int atRow = 0; atRow < 20; atRow++)
            {
                for (int atCol = 0; atCol < 20; atCol++)
                {
                    lbl = getLabel(atCol, atRow);
                    if (bombs[atCol, atRow])
                    {
                        lbl.BackColor = Color.Red;
                    }
                    else
                    {
                        lbl.BackColor = Color.LightGray;
                    }
                }
            }


        }

        private void amIDead(int atCol, int atRow) //identifies if the user has touched a bomb, won or not
        {

            // died
            if (bombs[atCol, atRow])
            {
                this.BackColor = Color.Orange;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                lbl_key.Text = "Died!";
                showBombs();
                label401.Text = "Whoops! You died!";
                button5.BackColor = Color.Red;
                button5.Visible = true;
                button5.Text = "Try Again";
            }
            //won
            else if (atCol == 9 && atRow == 0)
            {
                count++;
                DVSaber(atCol3, atRow3);//dv with saber will appear at the column and row
                this.BackColor = Color.PeachPuff;
                button1.Enabled = false;//disallows any interactions to proceed to next level
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                lbl_key.Text = "Won!";
                showBombs();
                label401.Text = "Brilliant,You Live!";
                button5.BackColor = Color.Green;
                button5.Visible = true;

                label402.Text = "Level: " + count.ToString();
                label403.Text = "Level: " + count.ToString();
                button5.Text = "Level " + count.ToString();

              
          


            }
            //carry on
            else
            {
                label401.Text = "Danger Level: " + bombCount(atCol, atRow);
            }

        }
        
     


        private void button5_Click(object sender, EventArgs e)
        {
            

             
            hideSpriteAt(atCol, atRow);
           atRow = 19;
            atCol = 10;
            showSpriteAt(atCol, atRow);
            showSaberAt(atCol, atRow);
            plantBombs(10);
            label401.Text = "";
            this.BackColor = Color.WhiteSmoke;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Visible = false;
            lbl_key.Text = "Keyboard";
            hide();

            //colour gen
            Random NewRGBColor = new Random();
            label403.ForeColor = Color.FromArgb(NewRGBColor.Next(256), NewRGBColor.Next(256), NewRGBColor.Next(256));

            //levels
            if (label402.Text == "Level 1")
            {
                plantBombs(10);
            }


            if (label402.Text == "Level: 2")
            {
                plantBombs(20);
            }

            if (label402.Text == "Level: 3")
            {
                plantBombs(30);
            }

            if (label402.Text == "Level: 4")
            {
                plantBombs(40);
            }

            if (label402.Text == "Level: 5")
            {
                plantBombs(50);
            }

            if (label402.Text == "Level: 6")
            {
                plantBombs(60);
            }

            if (label402.Text == "Level: 7")
            {
                plantBombs(70);
            }

        }

        private void hide() //hides the bomb if tried again
        {
            Label lbl;
            for (int atRow = 0; atRow < 20; atRow++)
            {
                for (int atCol = 0; atCol < 20; atCol++)
                {
                    lbl = getLabel(atRow, atCol);
                    lbl.BackColor = Color.SkyBlue;

                }
            }
        }

        private void button6_Click(object sender, EventArgs e) //will be dropdown menu when settings is clicked
        {
            contextMenuStrip1.Show(button6.PointToScreen(new Point(0, button6.Height)));
        }

        private void controlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
               // frm_Controls frm = (frm_Controls)Application.OpenForms["frm_Controls"];
                //frm.label1.BackColor = Color.Red;
            lbl_key.BackColor = Color.Red;
          
            frm_Controls settingsForm = new frm_Controls();
            settingsForm.Show();
          this.Visible = false;
            

        }

        //keys

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownPoint.IsEmpty)
                return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mouseDownPoint.X), f.Location.Y + (e.Y - mouseDownPoint.Y));
        }

        //Keyboard






        ////diff
        public bool mProcessCmdEnabled;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (lbl_key.Text == "Keyboard")  //if keyboard is selected within control form then allows use, otherwise is not executed.
            {
                switch (keyData) //allows to change key to left, down, etc..
                {

                    //left
                    case Keys.Left:
                        if (atCol < 19)
                        {
                         
                            hideSpriteAt(atCol, atRow);
                            atCol--;
                            showSpriteAt(atCol, atRow);
                            amIDead(atCol, atRow);

                        }
                        return true;

                        //right
                      

                    case Keys.Right:
                        if (atCol < 19)
                        {
                            
                            hideSpriteAt(atCol, atRow);
                            atCol++;
                            showSpriteAt(atCol, atRow);
                            amIDead(atCol, atRow);
                        }
                        return true;
                    //up
                    case Keys.Up:


                        if (atCol < 19)
                        {
                          
                            hideSpriteAt(atCol, atRow);
                            atRow--;
                            showSpriteAt(atCol, atRow);
                            amIDead(atCol, atRow);
                        }
                        // etc.
                        return true;
                    //down
                    case Keys.Down:


                        if (atCol < 19)
                        {
                           
                            hideSpriteAt(atCol, atRow);
                            atRow++;
                            showSpriteAt(atCol, atRow);
                            amIDead(atCol, atRow);
                        }
                        return true;
                }
                
                // Disable/Enable keyboard
                if (keyData == Keys.Tab)
                {
                    this.SelectNextControl(this.ActiveControl, false, true, true, true);
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
       
private void button7_Click(object sender, EventArgs e)
        {
            frm_Controls frm2 = new frm_Controls();
            frm2.label1.Text = "Hello";
            mProcessCmdEnabled = !mProcessCmdEnabled;
        }

        private void setDifficultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Difficulty settingsForm = new frm_Difficulty();
            settingsForm.Show();
            this.Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            //write
            StreamWriter sw = new StreamWriter(@"C:\Users\Gab\Downloads\ProjectMinefield\Saves.txt", false);
            sw.WriteLine(label403.Text);

            sw.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Read a textfile
      
            StreamReader sr = new StreamReader(@"C:\Users\Gab\Downloads\ProjectMinefield\Saves.txt");
            label403.Text = sr.ReadToEnd();
            sr.Close();



        }
    } 
}
           
        
    

    

