using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using MathNet.Numerics;
namespace calculator
{
    public partial class Form4 : Form
    {
        private double sngCoEffA;
        private double sngCoEffB;
        private double sngCoEffC;
        private double sngCoEffD;
        public Form4()
        {
            InitializeComponent();
            
        }

        private void cal_Click(object sender, EventArgs e)
        {
            sngCoEffA = float.Parse(a.Text.ToString());
            sngCoEffB = float.Parse(b.Text.ToString());
            sngCoEffC = float.Parse(c.Text.ToString());
            sngCoEffD = float.Parse(d.Text.ToString());

            var roots = FindRoots.Cubic(sngCoEffD, sngCoEffC, sngCoEffB, sngCoEffA);
            Complex root1 = roots.Item1;
            Complex root2 = roots.Item2;
            Complex root3 = roots.Item3;
            if (root1 == root2 && root2 == root3)
            {
                showResult.Text = "Phương trình có duy nhất nghiệm:";
                showResult.Text += "\n x=" + (root1.Real.ToString() + "+(" + root1.Imaginary.ToString() + "i)");
            }
            else
            {
                showResult.Text = "Phương trình có 3 nghiệm phân biệt:";
                showResult.Text += "\n x1=" + (root1.Real.ToString() + "+(" + root1.Imaginary.ToString() + "i)");
                showResult.Text += "\n x2=" + (root2.Real.ToString() + "+(" + root2.Imaginary.ToString() + "i)");
                showResult.Text += "\n x3=" + (root3.Real.ToString() + "+(" + root3.Imaginary.ToString() + "i)");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
