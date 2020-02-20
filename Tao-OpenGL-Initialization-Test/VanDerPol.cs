﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tao_OpenGL_Initialization_Test
{
    class VanDerPol
    {
        private float alfa, omega, beta;
        public VanDerPol(float alfa, float beta,float omega)
        {
            this.alfa = alfa;
            this.beta = beta;
            this.omega = omega;
        }
        public float computingVanDerPol(float x, float y, float t)
        {
            return (float)((-alfa * (x * x - 1) * y + beta * Math.Cos(omega * t)));
        }
    }
}