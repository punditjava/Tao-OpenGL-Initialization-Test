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

        private float alfa = 2.5f, beta = 21f, omega = 5f;

        private float[,] GrapValuesArray;

        private bool notCalculate = true;
        private int pointPosition = 0;

        float Mcoord_X = 0, Mcoord_Y = 0;

        private MethodSelector method = new MethodSelector();

        int countOfMas = 300;
        float x0 = 0.5f, y0 = 0.5f;

        private float zoom = 10f;

        public Form1()
        {
            InitializeComponent();
            if (AnT != null)
            {
                AnT.InitializeContexts();
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            alfa = (float)trackBar1.Value / 100;
            notCalculate = true;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            beta = (float)trackBar2.Value / 100;
            notCalculate = true;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            omega = (float)trackBar3.Value / 100;
            notCalculate = true;
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
                ScreenW = zoom;
                ScreenH = zoom * (float)AnT.Height / (float)AnT.Width;
                Glu.gluOrtho2D(0.0, ScreenW, 0.0, ScreenH);
            }
            else
            {
                ScreenW = zoom * (float)AnT.Width / (float)AnT.Height;
                ScreenH = zoom;
                Glu.gluOrtho2D(0.0, zoom * (float)AnT.Width / (float)AnT.Height, 0.0, zoom);
            }
            devX = (float)ScreenW / (float)AnT.Width;
            devY = (float)ScreenH / (float)AnT.Height;
            Gl.glMatrixMode(Gl.GL_MODELVIEW);

            listBox1.SetSelected(1, true);
            textBoxX0.Text = x0.ToString();
            textBoxY0.Text = y0.ToString();
            timer1.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 1)
                method.setCalculateMethod(new MethodRungeKutta());
            else method.setCalculateMethod(new MethodEulera());
            notCalculate = true;
        }

        private void textBoxX0_TextChanged(object sender, EventArgs e)
        {
            try
            {
                x0 = float.Parse(textBoxX0.Text);
                notCalculate = true;
            }
            catch(FormatException)
            {
                notCalculate = false;
            }
        }

        private void textBoxY0_TextChanged(object sender, EventArgs e)
        {
            try
            {
                y0 = float.Parse(textBoxY0.Text);
                notCalculate = true;
            }
            catch (FormatException)
            {
                notCalculate = false;
            }
        }

        private void DrawDiagram()
        {
            method.setFormula(new VanDerPol(alfa, beta, omega));

            if (notCalculate)
            {
                GrapValuesArray = method.calculate(countOfMas, x0, y0);
                
                notCalculate = false;
            }

            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glVertex2d(GrapValuesArray[0, 0], GrapValuesArray[0, 1]);
            for (int ax = 1; ax < countOfMas; ax += 2)
            {
                Gl.glVertex2d(GrapValuesArray[ax, 0], GrapValuesArray[ax, 1]);
            }
            Gl.glEnd();
            Gl.glPointSize(zoom / 2);
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
        }

        private void Timer1Tick(object sender, EventArgs e)
        {

            if (pointPosition == countOfMas - 1)
                pointPosition = 0;
            Draw();
            
            pointPosition++;
        }

        private void Draw()
        {
            Draw draw = new Draw(zoom / 2);

            draw.DrawSystemOfCoordinates();
            outputLabes();
            DrawDiagram();

            Gl.glPopMatrix();

            PrintText2D.PrintText(devX * Mcoord_X + 0.2f, 
                (float)ScreenH - devY * Mcoord_Y + 0.4f, 
                "[ x: " + (devX * Mcoord_X - zoom/2f).ToString() 
                + " ; y: " + ((float)ScreenH - devY * Mcoord_Y - (zoom / 2)).ToString() + "]");

            AnT.Invalidate();
        }
        private void outputLabes()
        {
            printAlfaLabel.Text = alfa.ToString();
            printBetaLabel.Text = beta.ToString();
            printOmegaLabel.Text = omega.ToString();
        }
    }
}
