using System;
using System.Windows.Forms;

namespace Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "";
            if (Form1.win.ToString().Equals("1"))
            {
                panel2.BackgroundImage = Properties.Resources.cross;
            }
            else
                panel2.BackgroundImage = Properties.Resources.nought;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            this.Hide();
            h1.Show();
            this.Close();
        }


    }
}
