using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamicLable
{
    public partial class Form1 : Form
    {
        Point startClick = new Point(); 
        Point stopClick = new Point();
        int countObject = 0;

        public Form1()
        {
            InitializeComponent();
            //Label label = new Label();
            //label.Size = new Size(10, 20);
            //label.Location = new Point(10, 10);
            //label.Text = "1";
            //label.BorderStyle = BorderStyle.FixedSingle;

            //Controls.Add(label);
            Label label = new Label();
            label.Location = startClick;
            

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                startClick.X = e.X;
                startClick.Y = e.Y;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                stopClick.X = e.X;
                stopClick.Y = e.Y;
            }
            Label label = new Label
            {
                Location = new Point(Math.Abs(stopClick.X - startClick.X) / 2.0 +
                                    stopClick.X > startClick.X ? startClick.X : stopClick.X,
                           Math.Abs(stopClick.Y - startClick.Y) / 2.0 +
                           stopClick.Y > startClick.Y ? startClick.Y : stopClick.Y),

                Size = new Size(Math.Abs(stopClick.X - startClick.X),
                                Math.Abs(stopClick.Y - startClick.Y)),
                Text = (++countObject).ToString(),
                BorderStyle = BorderStyle.FixedSingle
            };
            Controls.Add(label);
        }
    }
}
