using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class PaintForm : Form
    {
        
        private Color ColorActual = Color.Black;
        
        private bool Dibujando = false;
       
        private List<Point> points = new List<Point>();
        public PaintForm()
        {
            InitializeComponent();
        }

       
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Dibujando = true;  
            points.Clear();    
            points.Add(e.Location); 
        }

        
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dibujando)
            {
                points.Add(e.Location); 
                panel1.Invalidate();    
            }
        }

      
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Dibujando = false; 
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (points.Count > 1)
            {
                using (Pen pen = new Pen(ColorActual, 2)) 
                {
                    e.Graphics.DrawLines(pen, points.ToArray()); 
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog()) 
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    ColorActual = colorDialog.Color; 
                }
            }
        }

        private void Change_background_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog()) 
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    panel1.BackColor = colorDialog.Color; 
                }
            }
        }
    }
}
