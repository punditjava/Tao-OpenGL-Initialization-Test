using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace Tao_OpenGL_Initialization_Test
{
    public partial class Form1 : Form
    {
        double ScreenW, ScreenH;

        private float devX;
        private float devY;

        private float[,] GrapValuesArray;
        private int elements_count = 0;

        private bool not_calculate = true;
        private int pointPosition = 0;

        float lineX, lineY;
        float Mcoord_X = 0, Mcoord_Y = 0;
        PrintText2D printText = new PrintText2D();

        public Form1()
        {
            InitializeComponent();
            if (AnT != null)
            {
                AnT.InitializeContexts();
            }
        }

        private void functionCalculation()
        {
            float x = 0.01f, y = 0.01f;
            GrapValuesArray = new float[301, 2];
            GrapValuesArray[0, 0] = x;
            GrapValuesArray[0, 1] = y;
            elements_count = 1;

            for(float f = 0; f < 30; f += 0.1f)
            {
                y += func(x,y,f);
                x += func(x, y, f);
                GrapValuesArray[elements_count, 0] = x;
                GrapValuesArray[elements_count, 1] = y;
                elements_count++;
            }
            not_calculate = false;
        }
        private float func(float x, float y, float t)
        {
            float h = 0.1f, a = 8f, b = 3f, omega = 8f;

            return (float)(h*(-a * (x * x - 1) * y + b * Math.Cos(omega * t)));
        }
        private void DrawDiagram()
        {
            if (not_calculate)
            {
                functionCalculation();
            }

            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glVertex2d(GrapValuesArray[0, 0], GrapValuesArray[0, 1]);
            for (int ax = 1; ax < elements_count; ax += 2)
            {
                Gl.glVertex2d(GrapValuesArray[ax, 0], GrapValuesArray[ax, 1]);
            }
            Gl.glEnd();
            Gl.glPointSize(5);
            Gl.glColor3f(255, 0, 0);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2d(GrapValuesArray[pointPosition, 0], GrapValuesArray[pointPosition, 1]);
            Gl.glEnd();
            Gl.glPointSize(1);
        }

        private void simpleOpenGlControl1_MouseMove(object sender, MouseEventArgs e)
        {
            Mcoord_X = e.X;
            Mcoord_Y = e.Y;
            lineX = devX * e.X;
            lineY = (float)(ScreenH - devY * e.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pointPosition == elements_count - 1)
                pointPosition = 0;

            Draw();
            
            pointPosition++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            if ((float)AnT.Width <= (float)AnT.Height)
            {
                ScreenW = 10.0;
                ScreenH = 10.0 * (float)AnT.Height / (float)AnT.Width;
                Glu.gluOrtho2D(0.0, ScreenW, 0.0, ScreenH);
            }
            else
            {
                ScreenW = 10.0 * (float)AnT.Width / (float)AnT.Height;
                ScreenH = 10.0;
                Glu.gluOrtho2D(0.0, 10.0 * (float)AnT.Width / (float)AnT.Height, 0.0, 10.0);
            }
            devX = (float)ScreenW / (float)AnT.Width;
            devY = (float)ScreenH / (float)AnT.Height;
            Gl.glMatrixMode(Gl.GL_MODELVIEW);

            timer1.Start();
        }

        private void Draw()
        {
            Draw draw = new Draw(5);

            draw.DrawSystemOfCoordinates();
            DrawDiagram();

            Gl.glPopMatrix();

            printText.PrintText(devX * Mcoord_X + 0.2f, 
                (float)ScreenH - devY * Mcoord_Y + 0.4f, 
                "[ x: " + (devX * Mcoord_X - 5f).ToString() 
                + " ; y: " + ((float)ScreenH - devY * Mcoord_Y - 5f).ToString() + "]");

            AnT.Invalidate();
        }
    }
}
