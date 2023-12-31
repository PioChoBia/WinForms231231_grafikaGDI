namespace WinForms231231_grafikaGDI
{
    using System.Drawing;
    using System.Drawing.Drawing2D;
    public partial class Form1 : Form
    {      

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {         
            //stworzenie obiektu Graphics samodzielnie
            Graphics gSamodzielnie = this.CreateGraphics();
            
            //stworzenie obiektu Graphics z e Paint
            Graphics gPaint = e.Graphics;

            //wyczyszczenie t³a
            gPaint.Clear(Color.Yellow);
            
            //stworzenie pêdzla
            Brush bBlue= new SolidBrush(Color.Blue);
            Brush bGray= new SolidBrush(Color.Gray);


            //stworzenie pióra
            Pen penRed = new Pen(Color.Red);
            Pen penZielonyGruby = new Pen(Color.Green, 10);

/*
            Rectangle rect = new Rectangle(50, 30, 100, 100);
            LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Red, Color.Yellow, LinearGradientMode.BackwardDiagonal);
            g.FillRectangle(lBrush, rect);
*/


        }
    }
}