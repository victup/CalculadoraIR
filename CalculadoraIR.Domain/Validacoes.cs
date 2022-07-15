using CalculadoraIR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIR.Domain
{
    public abstract class Validacoes: IValidacaoMenu, IValidacaoEntrada
    {
       public static int verificaOpcaoMenuInicial()
        {
            
            var op = ValidaEntradaNumerica();

            while(op != 1 && op != 2 && op !=3)
            {
                Console.WriteLine($"Opção inválida. Tente novamente: ");
                op = ValidaEntradaNumerica();

            }

            return op;
        }

        public static int ValidaEntradaNumerica()
        {
            var op = Console.ReadLine();
            
            while (!int.TryParse(op, out var entrada))
            {
                Console.WriteLine($"Opção inválida.{op} não é uma opção. Digite um número ");
                op = Console.ReadLine();

            }

            return int.Parse(op);

        }
      

      
    }
}
