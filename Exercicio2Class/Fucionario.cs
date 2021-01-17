﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Exercicio2Class
{
    class Fucionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
         
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentoSalario( double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);
        }
        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
