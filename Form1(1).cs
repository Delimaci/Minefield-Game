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
    public partial class Form1 : Form
    {
        int atCol = 10;
        int atRow = 19;

        bool[,] bombs = new bool[20, 20];

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(980, 283);
            button5.Visible = false;
            //atRow = 19;
            //atCol = 10;
            showSpriteAt(atCol, atRow);
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
            lbl.Image = Properties.Resources.Minefield;     //set it to show an image 

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

        private void showBombs()
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

        private void amIDead(int atCol, int atRow)
        {

            // died
            if (bombs[atCol, atRow])
            {
                this.BackColor = Color.Orange;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                showBombs();
                label401.Text = "Whoops! You died!";
                button5.BackColor = Color.Red;
                button5.Visible = true;
                button5.Text = "Try Again";
            }
            //won
            else if (atCol == 9 && atRow == 0)
            {
                this.BackColor = Color.PeachPuff;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                showBombs();
                label401.Text = "Brilliant,You Live!";
                button5.BackColor = Color.Green;
                button5.Visible = true;
                button5.Text = "Level 2";
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
            plantBombs(40);
            label401.Text = "";
            this.BackColor = Color.WhiteSmoke;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Visible = false;
            hide();




        }

        private void hide()
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

        private void label118_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button6.PointToScreen(new Point(0, button6.Height)));
        }

        private void controlsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm_Controls settingsForm = new frm_Controls();
            settingsForm.Show();
            this.Visible = false;
        }

    
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    if (atCol < 19)
                    {
                        hideSpriteAt(atCol, atRow);
                        atCol--;
                        showSpriteAt(atCol, atRow);
                        amIDead(atCol, atRow);
                    }
                    return true;

                case Keys.Right:
                    if (atCol < 19)
                    {
                        hideSpriteAt(atCol, atRow);
                        atCol++;
                        showSpriteAt(atCol, atRow);
                        amIDead(atCol, atRow);
                    }
                    return true;

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
          
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}

    

