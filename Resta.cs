﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Resta
    {
        double r1, r2, resultado;

        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public double R2
        {
            get { return r2; }
            set { r2 = value; }
        }

        public double R1
        {
            get { return r1; }
            set { r1 = value; }
        }

        public double calcular()
        {
            Resultado = R1 - R2;
            return Resultado;
        }
    }
}
