using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tao_OpenGL_Initialization_Test
{
    class Method
    {
        private CalcuteMethods calcuteMethod;
        public Method() { }

        public Method(CalcuteMethods calcuteMethod)
        {
            this.calcuteMethod = calcuteMethod;
        }
        public void setCalculateMethod(CalcuteMethods calcuteMethod)
        {
            this.calcuteMethod = calcuteMethod;
        }
        public float[,] calculate(int size, VanDerPol vanDerPol, float x0, float y0, float step)
        {
            return this.calcuteMethod.calcute(size,vanDerPol,x0,y0,step);
        }
    }
}
