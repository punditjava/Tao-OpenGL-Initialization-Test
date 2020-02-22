using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tao_OpenGL_Initialization_Test
{
    interface Formula
    {
        float computingX(float x, float y, float t);
        float computingY(float x, float y, float t);
    }
}
