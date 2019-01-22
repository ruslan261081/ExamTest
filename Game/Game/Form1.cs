using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int sum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = $"{r.Next(250)}";
            label2.Text = $"{r.Next(250)}";
            label3.Text = $"{r.Next(250)}";
            label4.Text = $"{r.Next(250)}";
            label5.Text = $"{r.Next(250)}";
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = $"{r.Next(250)}";
            label2.Text = $"{r.Next(250)}";
            label3.Text = $"{r.Next(250)}";
            label4.Text = $"{r.Next(250)}";
            label5.Text = $"{r.Next(250)}";

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

            listBox1.Items.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do ytou want to Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtBox1.Text = "";
            txtBox2.Text = "";
            txtBox3.Text = "";
            txtBox4.Text = "";
            txtBox5.Text = "";

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
           
            if(sum == 5)
            {
                MessageBox.Show($"You Lost!", "loser", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show($"You Won", "Won", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            listBox1.Items.Add($"{sum}");
        }
    }
}
