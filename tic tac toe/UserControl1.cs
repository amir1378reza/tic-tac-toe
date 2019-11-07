using System;

using System.Drawing;

using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication12
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public int[] item = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        //public Point[] points = new Point[100];

        protected override void OnPaint(PaintEventArgs pe)
        {
            DrawFile(pe.Graphics);
            DrawPlayer(pe.Graphics);

        }

        private void DrawPlayer(Graphics graphics)
        {

            for (int i = 0; i < item.Length; i++)
            {
                    int x, y;
                Image image;
                if (item[i] == 1)
                {
                    image = Properties.Resources.o;
                }
                else if (item[i] == 2)
                {
                    image = Properties.Resources.x;
                }
                else
                    continue ;
                int xIndex = i % 3;
                int yIndex = i / 3;

                x = xIndex * (Width  / 3)+1;
                y = yIndex * (Height / 3)+1;
                graphics.DrawImage(image, x, y);
               
            }
        }

        private void DrawFile(Graphics g)
        {
            g.Clear(Color.White);
            Pen pn = new Pen(Color.Blue);
            Point pt1 = new Point(0, Height / 3);
            Point pt2 = new Point(Width, Height / 3);
            g.DrawLine(pn, pt1, pt2);

            Point pt3 = new Point(0, Height / 3 * 2);
            Point pt4 = new Point(Width, Height / 3 * 2);
            g.DrawLine(pn, pt3, pt4);

            Point pt5 = new Point(Width / 3, 0);
            Point pt6 = new Point(Width / 3, Height);
            g.DrawLine(pn, pt5, pt6);

            Point pt7 = new Point(Width / 3 * 2, 0);
            Point pt8 = new Point(Width / 3 * 2, Height);
            g.DrawLine(pn, pt7, pt8);
        }


        public bool checkwin()
        {
            if (item[0] == 1 && item[1] == 1 && item[2] == 1)
            {
                return true;
            }
            if (item[3] == 1 && item[4] == 1 && item[5] == 1)
            {
                return true;
            }
            if (item[6] == 1 && item[7] == 1 && item[8] == 1)
            {
                return true;
            }
            if (item[0] == 1 && item[3] == 1 && item[6] == 1)
            {
                return true;
            }
            if (item[1] == 1 && item[4] == 1 && item[7] == 1)
            {
                return true;
            }
            if (item[2] == 1 && item[5] == 1 && item[8] == 1)
            {
                return true;
            }
            if (item[0] == 1 && item[4] == 1 && item[8] == 1)
            {
                return true;
            }
            if (item[2] == 1 && item[4] == 1 && item[6] == 1)
            {
                return true;
            }
            if (item[0] == 2 && item[1] == 2 && item[2] == 2)
            {
                return true;
            }
            if (item[3] == 2 && item[4] == 2 && item[5] == 2)
            {
                return true;
            }
            if (item[6] == 2 && item[7] == 2 && item[8] == 2)
            {
                return true;
            }
            if (item[0] == 2 && item[3] == 2 && item[6] == 2)
            {
                return true;
            }
            if (item[1] == 2 && item[4] == 2 && item[7] == 2)
            {
                return true;
            }
            if (item[2] == 2 && item[5] == 2 && item[8] == 2)
            {
                return true;
            }
            if (item[0] == 2 && item[4] == 2 && item[8] == 2)
            {
                return true;
            }
            if (item[2] == 2 && item[4] == 2 && item[6] == 2)
            {
                return true;
            }

            else
            {
                return false;
            }


       
        }

        public void reset()
        {
            
          for(int i=0; i<9;i++)
            {
                item[i] = 0;
            }


            this.Invalidate();
        }
        void o(MouseEventArgs e)
        {

            if (e.X > 0 && e.X < Width / 3 && e.Y > 0 && e.Y < Height / 3)
            { 
                item[0] = 1;
            }
            else if (e.X > 0 && e.X < Width / 3 && e.Y > Height / 3 && e.Y < Height / 3 * 2)
            {

                item[3] = 1;
            }
            else if (e.X > 0 && e.X < Width / 3 && e.Y > Height / 3 * 2 && e.Y <= Height)
            {

                item[6] = 1;
            }
            else if (e.X > Width / 3 && e.X < Width / 3 * 2 && e.Y > 1 && e.Y < Height / 3)
            {

                item[1] = 1;
            }
            else if (e.X > Width / 3 && e.X < Width / 3 * 2 && e.Y > Height / 3 && e.Y < Height / 3 * 2)
            {
                item[4] = 1;
            }
            else if (e.X > Width / 3 && e.X < Width / 3 * 2 && e.Y > Height / 3 * 2 && e.Y < Height)
            {
                item[7] = 1;
            }
            else if (e.X > Width / 3 * 2 && e.X < Width && e.Y > 1 && e.Y < Height / 3)
            {

                item[2] = 1;
            }
            else if (e.X > Width / 3 * 2 && e.X < Width && e.Y > 1 && e.Y < Height / 3 * 2)
            {

                item[5] = 1;
            }
            else if (e.X > Width / 3 * 2 && e.X < Width && e.Y > Width / 3 * 2 && e.Y < Height)
            {
                item[8] = 1;
            }
            this.Invalidate();

        }

        void x(MouseEventArgs e)
        {
            if (e.X > 0 && e.X < Width / 3 && e.Y > 0 && e.Y < Height / 3)
            {
                item[0] = 2;
            }
            else if (e.X > 0 && e.X < Width / 3 && e.Y > Height / 3 && e.Y < Height / 3 * 2)
            {
                item[3] = 2;
            }
            else if (e.X > 0 && e.X < Width / 3 && e.Y > Height / 3 * 2 && e.Y <= Height)
            {
                item[6] = 2;
            }
            else if (e.X > Width / 3 && e.X < Width / 3 * 2 && e.Y > 1 && e.Y < Height / 3)
            {
                item[1] = 2;
            }
            else if (e.X > Width / 3 && e.X < Width / 3 * 2 && e.Y > Height / 3 && e.Y < Height / 3 * 2)
            {
                item[4] = 2;
            }
            else if (e.X > Width / 3 && e.X < Width / 3 * 2 && e.Y > Height / 3 * 2 && e.Y < Height)
            {
                item[7] = 2;
            }
            else if (e.X > Width / 3 * 2 && e.X < Width && e.Y > 1 && e.Y < Height / 3)
            {
                item[2] = 2;
            }
            else if (e.X > Width / 3 * 2 && e.X < Width && e.Y > 1 && e.Y < Height / 3 * 2)
            {
                item[5] = 2;
            }
            else if (e.X > Width / 3 * 2 && e.X < Width && e.Y > Width / 3 * 2 && e.Y < Height)
            {

                item[8] = 2;
            }
            this.Invalidate();
        }

        Boolean  win = false;
        Boolean pleyero = true, pleyerx = true;
        
        private void UserControl1_MouseClick(object sender, MouseEventArgs e)
        {

           


            if (pleyero)
            {
                o(e);
                
                    pleyero = false;
                    pleyerx = true;

                win = checkwin();
                if (win == true)
                {
                    MessageBox.Show("pleyer o win !!!");
                    reset();           
                }
            }
            else if (pleyerx)
            {
              
                x(e);
                
                    pleyero = true;
                    pleyerx = false;
                
                win = checkwin();
                if (win == true)
                {
                    MessageBox.Show("pleyer x  win !!!");
                    reset();
                    
                }
            }

            int m = 0;
            for(int i=0;i<9;i++)
            {
                if (item[i] == 1 || item[i] == 2)
                    ++m;
            }

            if(m==9)
            {
                MessageBox.Show("equal !!!");
                reset();
            }

        }
           

            //}
            //}
        }
    }


