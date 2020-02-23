using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tao_OpenGL_Initialization_Test
{
    class MethodSelector
    {
        private CalcuteMethods calcuteMethod;
        private Formula formula;
        public MethodSelector() {
        }

        public MethodSelector(CalcuteMethods calcuteMethod)
        {
            this.calcuteMethod = calcuteMethod;
        }
        public void setCalculateMethod(CalcuteMethods calcuteMethod)
        {
            this.calcuteMethod = calcuteMethod;
        }
        public float[,] calculate(int size, float x0, float y0)
        {
            return this.calcuteMethod.calcute(size,formula,x0,y0);
        }
        public void setFormula(Formula formula)
        {
            this.formula = formula;
        }
    }
}
