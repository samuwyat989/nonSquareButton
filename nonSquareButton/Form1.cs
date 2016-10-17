using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nonSquareButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Initialize the user-defined button, 
            // including defining handler for Click message, 
            // location and size.
            myButtonObject myButton = new myButtonObject();
            EventHandler myHandler = new EventHandler(myButton_Click_1);
            myButton.Click += myHandler;
            myButton.Location = new System.Drawing.Point(20, 20);
            myButton.Size = new System.Drawing.Size(101, 101);
            this.Controls.Add(myButton);
        }
        public class myButtonObject : UserControl
        {
            // Draw the new button. 
            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics graphics = e.Graphics;
                Pen myPen = new Pen(Color.Green, 5);
                SolidBrush myBrush = new SolidBrush(Color.Black);
                // Draw the button in the form of a circle
                graphics.FillEllipse(myBrush, 0, 0, 100, 100);
                graphics.DrawEllipse(myPen, 0, 0, 100, 100);
                myPen.Dispose();
                myBrush.Dispose();
            }
        }

        private void myButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }
    }
}

