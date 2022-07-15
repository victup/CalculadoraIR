using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIR.Domain.Interfaces
{
    public interface IValidacaoEntrada
    {
        public static int ValidaEntradaNumerica()
        {
            return 0;
        }

        public static string ValidaCpf()
        {
            return "";
        }

        public static double ValidaSalario()
        {
            return 0;
        }

    }
}
