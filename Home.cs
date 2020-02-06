using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace Game
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            panel1.BackColor= Color.FromArgb(75, Color.Transparent);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Text = "";
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(3);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
