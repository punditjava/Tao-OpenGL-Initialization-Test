namespace Tao_OpenGL_Initialization_Test
{
    class MethodRungeKutta : ICalcuteMethods
    {
        private IFormula formula;
        private float x, y, t;
        private const float dt = 0.1f;

        private float k1, k2, k3, k4, m1, m2, m3, m4;
        public float[,] calcute(int size, IFormula formula, float x0, float y0)
        {
            float[,] GrapValuesArray = new float[size, 2];
            int elements_count = 1;
            this.formula = formula;
            this.x = x0;
            this.y = y0;
            GrapValuesArray[elements_count - 1, 0] = x;
            GrapValuesArray[elements_count - 1, 1] = y;

            for (float f = 0; f < (size/10 - 1); f += 0.1f)
            {
                this.t = f;
                calKoef();
                x += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                y += (m1 + 2 * m2 + 2 * m3 + m4) / 6;
                GrapValuesArray[elements_count, 0] = x;
                GrapValuesArray[elements_count, 1] = y;
                elements_count++;
            }

            return GrapValuesArray;
        }
        private void calKoef()
        {
            calK1();
            calM1();
            calK2();
            calM2();
            calK3();
            calM3();
            calK4();
            calM4();
        }
        private void calK1()
        {
            k1 = formula.computingX(x, y, t) * dt;
        }
        private void calM1()
        {
            m1 = formula.computingY(x, y, t) * dt;
        }
        private void calK2()
        {
            k2 = formula.computingX(x + k1 / 2, y + m1 / 2, t + dt / 2) * dt;
        }
        private void calM2()
        {
            m2 = formula.computingY(x + k1 / 2, y + m1 / 2, t + dt / 2) * dt;
        }
        private void calK3()
        {
            k3 = formula.computingX(x + k2 / 2, y + m2 / 2, t + dt / 2) * dt;
        }
        private void calM3()
        {
            m3 = formula.computingY(x + k2 / 2, y + m2 / 2, t + dt / 2) * dt;
        }
        private void calK4()
        {
            k4 = formula.computingX(x + k3, y + m3, t + dt) * dt;
        }
        private void calM4()
        {
            m4 = formula.computingY(x + k3, y + m3, t + dt) * dt;
        }
    }
}
