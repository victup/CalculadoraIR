using CalculadoraIR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIR.Domain
{
    public abstract class Validacoes: IValidacaoMenu, ValidacaoEntrada
    {
       public static int verificaOpcaoMenuInicial()
        {
            
            var op = int.Parse(Console.ReadLine());

            while(op != 1 && op != 2 && op !=3)
            {
                Console.WriteLine("Opção inválida. Tente novamente: ");
                op = int.Parse(Console.ReadLine());
                
            }

            return op;
        }

      

      
    }
}
