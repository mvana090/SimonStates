using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace simongame
{
    public partial class Form1 : Form
    {
        public void Color()
        {
            rand = myHat.Next(0, 4);
            Array.Resize(ref box, box.Length + 1);
            box[box.Length - 1] = rand;
            t1.Enabled = true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
        }
        public int[] box = new int[0];
        public Random myHat = new Random();
        public int rand = new int();
        public int x = 0;
        public bool player = false;
        public void bstart_Click(object sender, EventArgs e)
        {
            Color();
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            pbClick.Visible = false;
            Thread.Sleep(400);
            if (x < box.Length)
            {
                if (box[x] == 0)
                {
                    pbClick.Parent = pbtl;
                }
                if (box[x] == 1)
                {
                    pbClick.Parent = pbtr;
                }
                if (box[x] == 2)
                {
                    pbClick.Parent = pbbl;
                }
                if (box[x] == 3)
                {
                    pbClick.Parent = pbbr;
                }

                pbClick.Left = 0;
                pbClick.Top = 0;
                //pbClick.Visible = true;
                t2.Enabled = true;
                x++;
            }
            else
            {
                x = 0;
                player = true;
                this.Text = ("Simon - Ready");
            }
            t1.Enabled = false;
        }

        private void pbtl_Click(object sender, EventArgs e)
        {
            if (player == true && box.Length > 0)
            {
                if (box[x] == 0)
                {
                    x++;
                    lclicks.Text = Convert.ToString(x);
                    if (x >= box.Length)
                    {
                        this.Text = ("Simon - Correct");
                        player = false;
                        x = 0;
                        Color();
                        lclicks.Text = Convert.ToString(x);
                    }
                }
                else
                {
                    MessageBox.Show("Game Over\nYou got to " + Convert.ToString(box.Length));
                    this.Text = ("Simon - Press Start");
                    Array.Resize(ref box, 0);
                    x = 0;
                }
            }
        }

        private void pbtr_Click(object sender, EventArgs e)
        {
            if (player == true && box.Length > 0)
            {
                if (box[x] == 1)
                {
                    x++;
                    lclicks.Text = Convert.ToString(x);
                    if (x >= box.Length)
                    {
                        this.Text = ("Simon - Correct");
                        player = false;
                        x = 0;
                        Color();
                        lclicks.Text = Convert.ToString(x);
                    }
                }
                else
                {
                    MessageBox.Show("Game Over\nYou got to " + Convert.ToString(box.Length));
                    this.Text = ("Simon - Press Start");
                    Array.Resize(ref box, 0);
                    x = 0;
                }
            }
        }

        private void pbbl_Click(object sender, EventArgs e)
        {
            if (player == true && box.Length > 0)
            {
                if (box[x] == 2)
                {
                    x++;
                    lclicks.Text = Convert.ToString(x);
                    if (x >= box.Length)
                    {
                        this.Text = ("Simon - Correct");
                        player = false;
                        x = 0;
                        Color();
                        lclicks.Text = Convert.ToString(x);
                    }
                }
                else
                {
                    MessageBox.Show("Game Over\nYou got to " + Convert.ToString(box.Length));
                    this.Text = ("Simon - Press Start");
                    Array.Resize(ref box, 0);
                    x = 0;
                }
            }
        }

        private void pbbr_Click(object sender, EventArgs e)
        {
            if (player == true && box.Length > 0)
            {
                if (box[x] == 3)
                {
                    x++;
                    lclicks.Text = Convert.ToString(x);
                    if (x >= box.Length)
                    {
                        this.Text = ("Simon - Correct");
                        player = false;
                        x = 0;
                        Color();
                        lclicks.Text = Convert.ToString(x);
                    }
                }
                else
                {
                    MessageBox.Show("Game Over\nYou got to " + Convert.ToString(box.Length));
                    this.Text = ("Simon - Press Start");
                    Array.Resize(ref box, 0);
                    x = 0;
                }
            }
        }

        private void t2_Tick(object sender, EventArgs e)
        {
            pbClick.Visible = true;
            t2.Enabled = false;
            t1.Enabled = true;
        }
    }
}
