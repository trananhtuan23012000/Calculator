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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        Dictionary<string, double> variables = new Dictionary<string, double>()
        {
            { "x", 0 }
        };
        /// <summary>
        /// Print the name of pushed button to Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonToScreen(object sender, EventArgs e)
        {
            Screen.Text += ((Button)sender).Text;
        }


        // Modification


        // Edit

        /// <summary>
        /// remove the last component
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Backspace(object sender, EventArgs e)
        {
            var s = Screen.Text;
            if (s != "") Screen.Text = s.Remove(s.Length - 1);
        }

        // this should reset state, now with just screen, used for AC
        /*
        private void Clear(object sender, EventArgs e)
        {
            Screen.Clear();
            ResultScreen.Clear();
        }*/
        //Other
        #region Special Mode

        #endregion

        #region Navigate
        private void Navigate_CursorToLeft(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void PrintResult(object sender, EventArgs e)
        {
            try
            {
                Screen.Text = StringEvaluater.Eval(Screen.Text, variables).ToString();
            }
            catch (Exception)
            {
                Screen.Text = "MATH ERROR";
            }
        }
        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Screen.Clear();
        }

        
    }
}
