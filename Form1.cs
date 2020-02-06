using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public static int win;
        int sec, count = 0;
        Boolean player1 = true;
        Boolean player2 = false;


        public Form1()
        {

            InitializeComponent();
            timer1.Start();
            timer.ForeColor = Color.LightGreen;

            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button2.FlatAppearance.BorderSize = 0;
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button3.FlatAppearance.BorderSize = 0;
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button4.FlatAppearance.BorderSize = 0;
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button5.FlatAppearance.BorderSize = 0;
            button5.BackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button6.FlatAppearance.BorderSize = 0;
            button6.BackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button7.FlatAppearance.BorderSize = 0;
            button7.BackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button8.FlatAppearance.BorderSize = 0;
            button8.BackColor = Color.Transparent;
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button8.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button9.FlatAppearance.BorderSize = 0;
            button9.BackColor = Color.Transparent;
            button9.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button9.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button10.FlatAppearance.BorderSize = 0;
            button10.BackColor = Color.Transparent;
            button10.FlatStyle = FlatStyle.Flat;
            button10.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button10.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button1.Text = "10";
            button2.Text = "11";
            button3.Text = "12";
            button4.Text = "13";
            button5.Text = "14";
            button6.Text = "15";
            button7.Text = "16";
            button8.Text = "17";
            button9.Text = "18";
            panel6.BackgroundImage = Properties.Resources.cross;

        }
        private void overText()
        {


            timer1.Stop();
            sec = 0;
            timer1.Start();

            if (player1)
            {

                panel6.BackgroundImage = Properties.Resources.cross;
                panel7.BackgroundImage = null;
            }
            else
            {
                panel6.BackgroundImage = null;

                panel7.BackgroundImage = Properties.Resources.nought;
                ;
            }
            timer.ForeColor = Color.LightGreen;

            check();
            count++;
        }
        public void soc()
        {
            win = count % 2 + 1;
            timer1.Stop();
            sec = 0;
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
        public void check()
        {
            if (count < 8)
            {
                if (button1.Text == button2.Text && button2.Text == button3.Text)
                {
                    soc();
                }
                else if (button4.Text == button5.Text && button4.Text == button6.Text)
                {
                    soc();
                }
                else if (button7.Text == button8.Text && button8.Text == button9.Text)
                {
                    soc();
                }
                else if (button1.Text == button6.Text && button6.Text == button7.Text)
                {
                    soc();
                }
                else if (button2.Text == button5.Text && button2.Text == button8.Text)
                {
                    soc();
                }
                else if (button3.Text == button4.Text && button3.Text == button9.Text)
                {
                    soc();
                }
                else if (button1.Text == button5.Text && button5.Text == button9.Text)
                {
                    soc();
                }
                else if (button3.Text == button5.Text && button5.Text == button7.Text)
                {
                    soc();
                }


            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Draw");
                sec = 0;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (player1 == true)
            {
                button1.BackgroundImage = Properties.Resources.cross;
                player1 = false;
                player2 = true;
                button1.Text = "1";

            }
            else
            {
                button1.BackgroundImage = Properties.Resources.nought;
                player1 = true;
                player2 = false;
                button1.Text = "2";
            }
            overText();
            button1.Enabled = false;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                button2.BackgroundImage = Properties.Resources.cross;
                player1 = false;
                player2 = true;
                button2.Text = "1";
            }
            else
            {
                button2.BackgroundImage = Properties.Resources.nought;
                player1 = true;
                player2 = false;
                button2.Text = "2";
            }
            overText();
            button2.Enabled = false;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                button3.BackgroundImage = Properties.Resources.cross;
                player1 = false;
                player2 = true;
                button3.Text = "1";
            }
            else
            {
                button3.BackgroundImage = Properties.Resources.nought;
                player1 = true;
                player2 = false;
                button3.Text = "2";
            }
            overText();
            button3.Enabled = false;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                button6.BackgroundImage = Properties.Resources.cross;
                player1 = false;
                player2 = true;
                button6.Text = "1";
            }
            else
            {
                button6.BackgroundImage = Properties.Resources.nought;
                player1 = true;
                player2 = false;
                button6.Text = "2";
            }
            overText();
            button6.Enabled = false;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                button5.BackgroundImage = Properties.Resources.cross;
                player1 = false;
                player2 = true;
                button5.Text = "1";
            }
            else
            {
                button5.BackgroundImage = Properties.Resources.nought;
                player1 = true;
                player2 = false;
                button5.Text = "2";
            }
            overText();
            button5.Enabled = false;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                button4.BackgroundImage = Properties.Resources.cross;
                player1 = false;
                player2 = true;
                button4.Text = "1";
            }
            else
            {
                button4.BackgroundImage = Properties.Resources.nought;
                player1 = true;
                player2 = false;
                button4.Text = "2";
            }
            overText();
            button4.Enabled = false;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                button7.BackgroundImage = Properties.Resources.cross;
                player1 = false;
                player2 = true;
                button7.Text = "1";
            }
            else
            {
                button7.BackgroundImage = Properties.Resources.nought;
                player1 = true;
                player2 = false;
                button7.Text = "2";
            }
            overText();
            button7.Enabled = false;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                button8.BackgroundImage = Properties.Resources.cross;
                player1 = false;
                player2 = true;
                button8.Text = "1";
            }
            else
            {
                button8.BackgroundImage = Properties.Resources.nought;
                player1 = true;
                player2 = false;
                button8.Text = "2";
            }
            overText();
            button8.Enabled = false;
            button8.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                button9.BackgroundImage = Properties.Resources.cross;
                player1 = false;
                player2 = true;
                button9.Text = "1";
            }
            else
            {
                button9.BackgroundImage = Properties.Resources.nought;
                player1 = true;
                player2 = false;
                button9.Text = "2";
            }
            overText();
            button9.Enabled = false;
            button9.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            timer1.Interval = 500;
            timer.Text = (30 - sec).ToString();
            if (30 - sec <= 10)
            {
                timer.ForeColor = System.Drawing.Color.Red;
            }
            if (sec.Equals(30))
            {
                timer1.Stop();
                if (player1)
                {
                    MessageBox.Show("Time is up!\n Player 2 Turn!", "Time up!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ;
                    player1 = false;
                    player2 = true;
                    panel6.BackgroundImage = null;
                    panel7.BackgroundImage = Properties.Resources.nought;

                }
                else
                {
                    MessageBox.Show("Time is up!\n Player 1 Turn!", "Time up!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    player2 = false;
                    player1 = true;
                    panel6.BackgroundImage = Properties.Resources.cross;
                    panel7.BackgroundImage = null;

                }
                sec = 0;
                timer1.Start();
                timer.ForeColor = System.Drawing.Color.LightGreen;
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1 = new Home();
            h1.Show();
            this.Close();
        }


    }
}

