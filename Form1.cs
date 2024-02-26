namespace Bouncing_DVD
{
    public partial class Form1 : Form
    {
        int yspeed = 5;
        int xspeed = 5;
        Rectangle dvd = new Rectangle(0,0,0,0);
        Brush b = new SolidBrush(Color.Red);
        int w = 0;
        int h = 0;

        public Form1()
        {
            InitializeComponent();
            w = ClientSize.Width;
            h = ClientSize.Height;
           
            dvd.Width = 50;
            dvd.Height = 50;
            dvd.X = w/2;
            dvd.Y = h/2;
            timer1.Start();

        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(b, dvd);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Interval = 1;
            
            dvd.X += xspeed;
            dvd.Y += yspeed;

            if (dvd.Right == w|| dvd.Left == 0)
            {
                xspeed = -xspeed;
            }

            if (dvd.Top == 0 || dvd.Bottom == h)
            {
                yspeed = -yspeed;
            }

            this.Refresh();
        }
    }
}
