using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;


namespace Tao_OpenGL_Initialization_Test
{
   
    class Draw
    {
        
        private float sizeOfSystem;
        public Draw(float sizeOfSystem)
        {
            this.sizeOfSystem = sizeOfSystem;
        }
       
        public void DrawSystemOfCoordinates()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(0, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(5, 5, 0);
            

            Gl.glBegin(Gl.GL_LINES);
            DrawAxis();
            DrawArrows();
            Gl.glEnd();

            DrawNet();
            DrawSigna();
            

        }
        private void DrawSigna()
        {
            PrintText2D.PrintText(sizeOfSystem + 0.3f, 0, "x");
            PrintText2D.PrintText(0.3f, sizeOfSystem - 0.3f, "y");
        }
        private void DrawAxis()
        {
            Gl.glVertex2d(0, -sizeOfSystem);
            Gl.glVertex2d(0, sizeOfSystem);

            Gl.glVertex2d(-sizeOfSystem, 0);
            Gl.glVertex2d(sizeOfSystem, 0);
        }
        private void DrawArrows()
        {
            float v = sizeOfSystem - 0.3f;
            Gl.glVertex2d(0, sizeOfSystem);
            Gl.glVertex2d(0.1, v);
            Gl.glVertex2d(0, sizeOfSystem);
            Gl.glVertex2d(-0.1, v);

            Gl.glVertex2d(sizeOfSystem, 0);
            Gl.glVertex2d(v, 0.1);
            Gl.glVertex2d(sizeOfSystem, 0);
            Gl.glVertex2d(v, -0.1);
        }
        private void DrawNet()
        {
            Gl.glColor3f(0, 0, 255);
            Gl.glPointSize(3);
            Gl.glBegin(Gl.GL_POINTS);

            for(float ax = -sizeOfSystem; ax < sizeOfSystem; ax++)
            {
                for(float bx = -sizeOfSystem; bx < sizeOfSystem; bx++)
                {
                    Gl.glVertex2d(ax, bx);
                }
            }
            Gl.glColor3f(0, 0, 0);
            Gl.glEnd();
           
        }
    }

}
