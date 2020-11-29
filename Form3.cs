using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace calculator
{
    public partial class Form3 : Form
    {
        private double sngCoEffA;
        private double sngCoEffB;
        private double sngCoEffC;
        private double sngCoEffD;
        private double sngCoEffG;
        private double sngCoEffF;
        public Form3()
        {
            InitializeComponent();
        }

        private void cal_Click(object sender, EventArgs e)
        {
            sngCoEffA = float.Parse(a.Text.ToString());
            sngCoEffB = float.Parse(b.Text.ToString());
            sngCoEffC = float.Parse(c.Text.ToString());
            sngCoEffD = float.Parse(d.Text.ToString());
            sngCoEffG = float.Parse(g.Text.ToString());
            sngCoEffF = float.Parse(f.Text.ToString());
            if ((sngCoEffC / sngCoEffA) == (sngCoEffD / sngCoEffB) && (sngCoEffC / sngCoEffA) == (sngCoEffF / sngCoEffG))
            {
                showResult.Text = "Phương trình có vô số nghiệm !";
            }
            else if ((sngCoEffC / sngCoEffA) == (sngCoEffD / sngCoEffB) && (sngCoEffC / sngCoEffA) != (sngCoEffF / sngCoEffG) && (sngCoEffD / sngCoEffB) != (sngCoEffF / sngCoEffG))
            {
                showResult.Text = "Phương trình vô nghiệm !";
            }
            else
            {
                var A = Matrix<double>.Build.DenseOfArray(new double[,]
    {
    {sngCoEffA, sngCoEffB},
    {sngCoEffC, sngCoEffD}
    });
                var k = Vector<double>.Build.Dense(new double[] { sngCoEffG, sngCoEffF });
                var x = A.Solve(k);
                showResult.Text = "Phương trình có 2 nghiệm phân biệt:";
                showResult.Text += "\n x1=" + x[0].ToString();
                showResult.Text += "\n x1=" + x[1].ToString();

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
