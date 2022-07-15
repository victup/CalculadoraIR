using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIR.Services
{
    public class TaxCalculator : ITaxCalculator
    {
        public double TaxCalculation(double salario)
        {
            double renda = salario * 12;

            double valorImpostoRenda;

            if (renda <= 22847.76)
            {

                valorImpostoRenda = 0;
                return valorImpostoRenda;

            }
            else if (renda > 22847.76 && renda <= 33919.80)
            {

                valorImpostoRenda = (renda * 0.075) - 1713.58;
                return valorImpostoRenda;
            }
            else if (renda > 33919.80 && renda <= 45012.60)
            {

                valorImpostoRenda = (renda * 0.150) - 4257.57;
                return valorImpostoRenda;
            }
            else if (renda > 45012.60 && renda <= 55976.16)
            {

                valorImpostoRenda = (renda * 0.225) - 7633.51;
                return valorImpostoRenda;
            }
            else
            {

                valorImpostoRenda = (renda * 0.275) - 10432.32;
                return valorImpostoRenda;
            }

            
        }
    }
}
