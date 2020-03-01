namespace Tao_OpenGL_Initialization_Test
{
    class MethodSelector
    {
        private ICalcuteMethods calcuteMethod;
        private IFormula formula;
        public MethodSelector() {
        }

        public MethodSelector(ICalcuteMethods calcuteMethod)
        {
            this.calcuteMethod = calcuteMethod;
        }
        public void setCalculateMethod(ICalcuteMethods calcuteMethod)
        {
            this.calcuteMethod = calcuteMethod;
        }
        public float[,] calculate(int size, float x0, float y0)
        {
            return this.calcuteMethod.calcute(size,formula,x0,y0);
        }
        public void setFormula(IFormula formula)
        {
            this.formula = formula;
        }
    }
}
    