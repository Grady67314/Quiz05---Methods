using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Quiz05___Methods
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            
           
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Red);
            Thread.Sleep(100);
            Refresh();
            g.Clear(Color.Green);
            Thread.Sleep(100);
            Refresh();
            g.Clear(Color.Red);
            Thread.Sleep(100);
            Refresh();
            g.Clear(Color.Green);
            Thread.Sleep(100);
            Refresh();
            g.Clear(Color.Red);
            Thread.Sleep(100);
            Refresh();
            g.Clear(Color.Green);
            Thread.Sleep(100);
            Refresh();
            g.Clear(Color.Red);
            Thread.Sleep(100);
            Refresh();
            g.Clear(Color.Green);
            Thread.Sleep(100);
            Refresh();
            g.Clear(Color.Red);
            Thread.Sleep(100);
            Refresh();
            g.Clear(Color.Green);
            Refresh();
            PictureBox santaPic = new PictureBox();
        }
    }
}
