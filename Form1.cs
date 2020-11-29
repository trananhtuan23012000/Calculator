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
using AForge.Math.Metrics;
using AForge.Math.Random;
namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double m;
        double n;
        bool check = false;
        bool check3 = true;
        bool check4 = false;
        bool sqrtn = false;
        
        private void ChangeText(Button b)
        { if (textBox1.Text != "0" && check == true&& check2 == false)
            {
                textBox1.Text += b.Text;
           
            }

            else
            {
                textBox1.Text = b.Text;
                check2 = false;
                check = true;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void buttonclick(object sender, EventArgs e)
        {
            Button b = (Button)(sender);
            ChangeText(b);
        }
        bool check2 = false;
        bool sub = false;
        bool add = false;
        bool mul = false;
        bool div = false;
        
        private void compute(ref bool b)
        { try
            { m = Convert.ToDouble(textBox1.Text); }
        catch(Exception)
            { MessageBox.Show("Enter again !","Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
         check = true;
         check2 = true;
         check3 = true;
         sub = false;
         
         sqrtn = false;
         mul = false;
         div = false;
         add = false;
         b = true;
            
        }
        private void compute2(ref bool b)
        {
            
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1,1); 
            compute(ref b);
            textBox1.Clear();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            compute(ref add);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            compute(ref sub);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            compute(ref mul);
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            compute(ref div);
            
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result();
            
        }

        private void result()
        {
            try
            { n = Convert.ToDouble(textBox1.Text); }
            catch (Exception)
            {
                MessageBox.Show("Enter again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (add == true || sub == true || mul == true || div == true || sqrtn == true)
            {
                if (add == true)
                {
                    m = m + n;
                    add = false;
                }
                if (sub == true)
                {
                    m = m - n;
                    sub = false;
                }
                if (mul == true)
                {
                    m = m * n;
                    mul = false;
                }
                if (div == true)
                {
                    if (n != 0) m = m / n;
                    else
                        MessageBox.Show("Can not divide by 0 !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    div = false;
                }
                if (sqrtn == true)
                {
                    if (m != 0)
                    {
                        m = Math.Pow(n, 1 / m);


                    }
                    else
                        MessageBox.Show("Math Error ! , Enter n first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sqrtn = false;
                }
                check2 = true;
                
                textBox1.Text = Convert.ToString(m);
            }

        }


        private void button15_Click(object sender, EventArgs e)
        {
            if ( check3 == true)
            {
                textBox1.Text += button15.Text;
                check3 = false;
            }

            
        }

        private void button17_Click(object sender, EventArgs e)
        {   
            int k = textBox1.Text.Length;
            if (k >= 1)
                textBox1.Text = textBox1.Text.Substring(0, k - 1);
            else
                textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double s = Convert.ToDouble(textBox1.Text);
            s = -s;
            textBox1.Text = Convert.ToString(s);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            m = 0;
            n = 0;
            sub = false;
            add = false;
            mul = false;
            div = false;
            check3 = true;
            check = false;
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            compute(ref sqrtn);
            

        }

        private void button20_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (add == false&& mul == false && div == false && sub == false&& sqrtn == false)
                {
                    m = Convert.ToDouble(textBox1.Text);
                    m = Math.Sqrt(m);
                    textBox1.Text = Convert.ToString(m);
                }
                else
                {
                    n = Convert.ToDouble(textBox1.Text);
                    n = Math.Sqrt(n);
                    textBox1.Text = Convert.ToString(n);
                }
            }
            catch (Exception)
            { MessageBox.Show("Enter again !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }
        double a=0;
        private void button25_Click(object sender, EventArgs e)
        {
            a = a - m;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            a = a + m;
        }
        
        private void button22_Click(object sender, EventArgs e)
        {
            a = 0;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(a);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

   

        private void quadraticEquationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void cubicEquationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }

        private void linearEquationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        private void volumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }

        private void drawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Painter f = new Painter();
            f.Show();
            this.Hide();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
            /*
            Panel panel = new Panel();
            SaveFileDialog save = new SaveFileDialog();
            save.CheckFileExists = false;
            save.CheckPathExists = true;
            save.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            save.InitialDirectory = @"D:\tuan\";

            DialogResult result = save.ShowDialog();
            if (result == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(panel.Width, panel.Height);

                //panel.DrawToBitmap(bmp, new Rectangle(0, 0, panel.Width, panel.Height));

                bmp.Save(save.FileName);

            }
            */
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.Hide();
        }
    }
}
