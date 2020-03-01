using Tao.OpenGl;


namespace Tao_OpenGL_Initialization_Test
{
   
    class Draw
    {
        
        private readonly float sizeOfSystem;
        public Draw(float sizeOfSystem)
        {
            this.sizeOfSystem = sizeOfSystem;
        }
       
        public void drawSystemOfCoordinates()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(0, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(sizeOfSystem, sizeOfSystem, 0);
            

            Gl.glBegin(Gl.GL_LINES);
            drawAxis();
            drawArrows();
            Gl.glEnd();

            drawNet();
            drawSigna();
            

        }
        private void drawSigna()
        {
            PrintText2D.PrintText(sizeOfSystem + 0.3f, 0, "x");
            PrintText2D.PrintText(0.3f, sizeOfSystem - 0.3f, "y");
        }
        private void drawAxis()
        {
            Gl.glVertex2d(0, -sizeOfSystem);
            Gl.glVertex2d(0, sizeOfSystem);

            Gl.glVertex2d(-sizeOfSystem, 0);
            Gl.glVertex2d(sizeOfSystem, 0);
        }
        private void drawArrows()
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
        private void drawNet()
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
