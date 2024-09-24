using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaCode
{
    public partial class instaCode : Form
    {
        private void centerX(Control c, int yPos)
        {
            int xCenter = (c.Parent.ClientSize.Width - c.Width) / 2;
            c.Location = new System.Drawing.Point(xCenter, yPos);           
        }

        public instaCode()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centerX(label1, 10);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void instaCode_Resize(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
