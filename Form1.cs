namespace WinForms231231_grafikaGDI
{ 

    public partial class Form1 : Form
    {      

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {                      
            //stworzenie obiektu Graphics z e Paint
            Graphics gPaint = e.Graphics;

            //ustawienie t³a
            gPaint.Clear(Color.DarkGray);
            
            //stworzenie pêdzla
            Brush bBlue= new SolidBrush(Color.Red);

            //stworzenie pióra
            Pen penZielony10 = new Pen(Color.Green, 10);

            //przygotowuje punkty
            Point p1=new Point(10, 10);
            Point p2=new Point(50, 10);
            Point p3=new Point(100,10);
            Point p4=new Point(300,100);
            Point p5=new Point(500,100);
            //tablica punktów
            Point[] punkty1 = { p2, p5 }; 
            Point[] punkty2 = { p2, p3,p5,p4 };


            //rysuje odcinek
            gPaint.DrawLine(penZielony10, 10, 20, 100, 200);
            gPaint.DrawLine(penZielony10, p4, p5);

            //elipsa
            gPaint.DrawEllipse(penZielony10, 300,300, 200, 100 );

            //prostok¹t
            gPaint.DrawRectangle(penZielony10, 300, 500, 100, 50);

        }
    }
}