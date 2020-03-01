namespace Tao_OpenGL_Initialization_Test
{
    class MethodEulera : ICalcuteMethods
    {
        public float[,] calcute(int size, IFormula formula, float x0, float y0)
        {
            float x = x0, y = y0;
            int elements_count = 0;
            float[,] GrapValuesArray = new float[size, 2];
            GrapValuesArray[0, 0] = x;
            GrapValuesArray[0, 1] = y;
            
            for (float f = 0; f < (size/10 - 1); f += 0.1f)
            {
                x += 0.05f * formula.computingX(GrapValuesArray[elements_count, 0], GrapValuesArray[elements_count, 1], f);
                y += 0.05f * formula.computingY(GrapValuesArray[elements_count, 0], GrapValuesArray[elements_count, 1], f);
                elements_count++;
                GrapValuesArray[elements_count, 0] = x;
                GrapValuesArray[elements_count, 1] = y;
                
            }
            return GrapValuesArray;
        }
    }
}
