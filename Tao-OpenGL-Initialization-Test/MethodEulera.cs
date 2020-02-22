using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tao_OpenGL_Initialization_Test
{
    class MethodEulera : CalcuteMethods
    {
        public float[,] calcute(int size, Formula formula, float x0, float y0)
        {
            float x = x0, y = y0;
            int elements_count = 1;
            float[,] GrapValuesArray = new float[size, 2];
            GrapValuesArray[0, 0] = x;
            GrapValuesArray[0, 1] = y;
            
            for (float f = 0; f < (size/10 - 1); f += 0.1f)
            {
                y += 0.1f * formula.computingY(GrapValuesArray[elements_count - 1, 0], GrapValuesArray[elements_count - 1, 1], f);
                x += 0.1f * formula.computingX(GrapValuesArray[elements_count - 1, 0], GrapValuesArray[elements_count - 1, 1], f);
                GrapValuesArray[elements_count, 0] = x;
                GrapValuesArray[elements_count, 1] = y;
                elements_count++;
            }
            return GrapValuesArray;
        }
    }
}
