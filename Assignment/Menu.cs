using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDisplayEmployees_Click(object sender, EventArgs e)
        {
            DisplayRec newform = new DisplayRec();
            this.Hide();
            newform.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox1.Visible = true;
            }
        }
    }
}
