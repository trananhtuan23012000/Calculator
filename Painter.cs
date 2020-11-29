using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Painter : Form
    {
        public Painter()
        {
            InitializeComponent();
            InitializeStuffs();
        }

        private Point A, B, C, D, A_, B_, C_, D_; // We don't need to use these shits
        private List<Label> labelPoints;
        private List<Point> points;
        private int clickTimes;
        private int check;
        private bool hasDone;
        private bool needFixing;
        private double min = 10000;
        private double[] d = new double[4];
        private void buttonFinish_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void buttonChangepoint_Click(object sender, EventArgs e)
        {
            if (clickTimes!=4)
            {
                labelNotif.Text = "Please click enough 4 points to init !";
                
            }
            else
            {
                min = 10000;
                labelNotif.Text = "Please click anywhere near point that you need delete !";
                needFixing = true;
            }
        }
        private void newPoint(EventArgs e)
        {
                
                Point point = ((MouseEventArgs)e).Location;
                Graphics graphics = panel.CreateGraphics();
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Brush brush = new SolidBrush(Color.Red);
                graphics.FillRectangle(brush, point.X, point.Y, 4, 4);
                d[0] = Math.Sqrt(Math.Pow(point.X - A.X, 2) + Math.Pow(point.Y - A.Y, 2));
                d[1] = Math.Sqrt(Math.Pow(point.X - B.X, 2) + Math.Pow(point.Y - B.Y, 2));
                d[2] = Math.Sqrt(Math.Pow(point.X - D.X, 2) + Math.Pow(point.Y - D.Y, 2));
                d[3] = Math.Sqrt(Math.Pow(point.X - A_.X, 2) + Math.Pow(point.Y - A_.Y, 2));
                Console.WriteLine("d0={0}", d[0]);
                Console.WriteLine("d1={0}", d[1]);
                Console.WriteLine("d2={0}", d[2]);
                Console.WriteLine("d3={0}", d[3]);
                for (int i = 0; i < 4; i++)
                {
                    if (min >= d[i])
                    {
                        min = d[i];
                        check = i;
                    }
                }
                Console.WriteLine("check={0}", check);
                points[check] = point;
                labelPoints[check].Text
                        = $"({points[check].X}, {points[check].Y})";
                
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.CheckFileExists = false;
            save.CheckPathExists = true;
            save.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            save.InitialDirectory = @"D:\tuan\";

            DialogResult result = save.ShowDialog();
            if (result == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(703, 604);

                panel.DrawToBitmap(bmp, new Rectangle(0, 0, 703, 604));

                bmp.Save(save.FileName);
            }
        }

        private void InitializeStuffs()
        {
            labelPoints = new List<Label>() {
                labelPointA,
                labelPointB,
                labelPointD,
                labelPointA_
            };
            /*
            foreach (var label in labelPoints)
            {
                label.Click += (object sender, EventArgs e) => {
                    if (hasDone)
                    {
                        var index = labelPoints.IndexOf(label);
                        ChangeState(index);
                        clickTimes = index;
                        needFixing = true;
                    }
                };
            }
            */
            
            points = new List<Point>() {
                A, B, D, A_, C_, B_, D_, C
            };

            clickTimes = 0;
            hasDone = false;
            needFixing = false;
            panel.Click += panel_Click;
            panel.MouseMove += panel_MouseMove;
        }
        
        private void panel_Click(object sender, EventArgs e)
        {
            if (hasDone)
            {
                if (needFixing)
                {
                    //ChangePoint(e);
                    newPoint(e);
                    ChangeState(check);
                    panel.Refresh();
                    hasDone = true;
                }
                else return;
                
            };
            if (needFixing == false)
            {
                if (IsOK())
                {
                    ChangePoint(e);

                    // if all A, B, C, A' have been clicked, it has done.
                    if (++clickTimes == 4)
                    {
                        labelNotif.Text = "Done !";
                        hasDone = true;
                    }
                }
            }
        }
        private void ChangePoint(EventArgs e)
        {
            Point point = ((MouseEventArgs)e).Location;
            
            points[clickTimes] = point;
            Graphics graphics = panel.CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(Color.Red);
            graphics.FillRectangle(brush, point.X, point.Y, 4, 4);
            labelPoints[clickTimes].Text
                    = $"({points[clickTimes].X}, {points[clickTimes].Y})";
        }

        private void ChangeState(int index)
        {
            switch (index)
            {
                case 0:
                    labelNotif.Text = "Changed point A";
                    break;
                case 1:
                    labelNotif.Text = "Changed point B";
                    break;
                case 2:
                    labelNotif.Text = "Changed point D";
                    break;
                case 3:
                    labelNotif.Text = "Changed point A'";
                    break;
                default:
                    labelNotif.Text = "Done.";
                    break;
            }
        }
        

        private void panel_MouseMove(object sender, EventArgs e)
        {
            Point point = ((MouseEventArgs)e).Location;
            labelLocation.Text = $"({point.X}, {point.Y})";
            if (hasDone)
            {

                A = points[0];
                B = points[1];
                D = points[2];
                A_ = points[3];
                
                C = new Point(B.X + D.X - A.X, B.Y + D.Y - A.Y);
                B_ = new Point(A_.X + B.X - A.X, A_.Y + B.Y - A.Y);
                D_ = new Point(A_.X + D.X - A.X, A_.Y + D.Y - A.Y);
                C_ = new Point(B_.X + D_.X - A_.X, B_.Y + D_.Y - A_.Y);

                Graphics graphics = panel.CreateGraphics();
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Pen pen = new Pen(Color.Black, 4);
                pen.StartCap = pen.EndCap = LineCap.Round;
                graphics.DrawLine(pen, A, B);
                graphics.DrawLine(pen, A, D);
                graphics.DrawLine(pen, A, A_);
                graphics.DrawLine(pen, A_, B_);
                graphics.DrawLine(pen, A_, D_);
                graphics.DrawLine(pen, D, D_);
                graphics.DrawLine(pen, D, C);
                graphics.DrawLine(pen, B, B_);
                graphics.DrawLine(pen, B, C);
                graphics.DrawLine(pen, C, C_);
                graphics.DrawLine(pen, B_, C_);
                graphics.DrawLine(pen, D_, C_);
                
            }
            
        }

        private bool IsOK()
        {
            return true; // It needs fixing
        }

        private void Painter_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
