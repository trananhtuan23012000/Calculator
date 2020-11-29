using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form2 : Form
    {
        private double sngCoEffA;
        private double sngCoEffB;
        private double sngCoEffC;
        private double sngDiscriminant;
        private double sngRoot1;
        private double sngRoot2;
        public Form2()
        {
            InitializeComponent();
        }

        private void showClick_Click(object sender, EventArgs e)
        {
            sngCoEffA = float.Parse(a.Text.ToString());
            sngCoEffB = float.Parse(b.Text.ToString());
            sngCoEffC = float.Parse(c.Text.ToString());

            sngDiscriminant = (sngCoEffB * sngCoEffB) - (4 * sngCoEffA
               * sngCoEffC);

            if ((sngDiscriminant > 0))
            {

                sngRoot1 = (-sngCoEffB + Math.Sqrt(sngDiscriminant)) /
                   (2 * sngCoEffA);
                sngRoot2 = (-sngCoEffB - Math.Sqrt(sngDiscriminant)) /
                   (2 * sngCoEffA);
                showResult.Text="Phương trình có 2 nghiệm phân biệt:";
                showResult.Text+="\n x1 = "+ sngRoot1.ToString();
                showResult.Text+="\n x2 = "+ sngRoot2.ToString();
            }
            else if ((sngDiscriminant == 0))
            {

                sngRoot1 = (-sngCoEffB + Math.Sqrt(sngDiscriminant)) /
                   (2 * sngCoEffA);

                showResult.Text="Phương trình có nghiệm kép:";
                showResult.Text+="\n x = "+ sngRoot1.ToString();
                

            }
            else
            {      
                showResult.Text = "Phương trình có 2 nghiệm phức:";
                showResult.Text += "\n x1 = " + ((-sngCoEffB/ 2 * sngCoEffA)+"+"+ (Math.Sqrt(Math.Abs(sngDiscriminant))/ 2 * sngCoEffA)+"i").ToString();
                showResult.Text += "\n x2 = " + ((-sngCoEffB / 2 * sngCoEffA) + "-" + (Math.Sqrt(Math.Abs(sngDiscriminant)) / 2 * sngCoEffA) + "i").ToString();

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
