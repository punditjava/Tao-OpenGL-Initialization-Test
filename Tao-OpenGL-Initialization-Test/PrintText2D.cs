using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace Tao_OpenGL_Initialization_Test
{
    class PrintText2D
    {
        public void PrintText(float x, float y, string text)
        {
            Gl.glRasterPos2f(x, y);
            foreach (char char_for_graw in text)
            {
                Glut.glutBitmapCharacter(Glut.GLUT_BITMAP_9_BY_15, char_for_graw);
            }
        }
    }
}
