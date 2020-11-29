using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Math.Geometry;
namespace calculator
{
    public partial class Form5 : Form  
    {
        private double V;
        private double S1;
        private double S2;
        private double S3;
        public Form5()
        {
            InitializeComponent();
            
        }
        public class point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }


            public point(double x, double y, double z)
            {
                this.X = x;
                this.Y = y;
                this.Z = z;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            point A = new point(float.Parse(A_x.Text.ToString()), float.Parse(A_y.Text.ToString()), float.Parse(A_z.Text.ToString()));
            
            point B = new point(float.Parse(B_x.Text.ToString()), float.Parse(B_y.Text.ToString()), float.Parse(B_z.Text.ToString()));
            
            point D = new point(float.Parse(D_x.Text.ToString()), float.Parse(D_y.Text.ToString()), float.Parse(D_z.Text.ToString()));

            point M = new point(float.Parse(M_x.Text.ToString()), float.Parse(M_y.Text.ToString()), float.Parse(M_z.Text.ToString()));
            Vector3 AB = new Vector3(B.X-A.X, B.Y-A.Y, B.Z-A.Z);
            Vector3 AD= new Vector3(D.X-A.X, D.Y-A.Y, D.Z-A.Z);
            Vector3 AM = new Vector3(M.X-A.X, M.Y-A.Y, M.Z-A.Z);
            Vector3 result = Vector3.Cross(AB, AD);         
            V =Math.Abs( Vector3.Dot(result, AM));
            showResult.Text = "VABCDMNPQ = "+V.ToString();
            S1 = Math.Abs(Vector3.Dot(AB,AD));
            S2= Math.Abs(Vector3.Dot(AB, AM));
            S3 = Math.Abs(Vector3.Dot(AD, AM));
            showResult.Text += "\n SABCD = SMNPQ =" + S1.ToString();
            showResult.Text += "\n SAMNB = SDQPC =" + S2.ToString();
            showResult.Text += "\n SAMQD = SBNPC =" + S3.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
    }

