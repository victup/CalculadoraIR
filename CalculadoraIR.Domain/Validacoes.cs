using CalculadoraIR.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculadoraIR.Domain
{
    public abstract class Validacoes : IValidacaoMenu, IValidacaoEntrada
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

        public static string ValidaCpf(string cpf)
        {
            var cpfAnalisado = cpf;
            Regex rxCpf = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");

            while(!rxCpf.IsMatch(cpfAnalisado))
            {
                Console.WriteLine("CPF Inválido. Digite no formato 012.345.678-90: ");
                cpfAnalisado = Console.ReadLine();
            }

            return cpfAnalisado;
            
        }

        public static double ValidaSalario(string salario)
        {
            var salarioAnalisado = salario;

            Regex rxSalario = new Regex(@"(\d{1,3}(\.\d{3})*|\d+)(\,\d{2})?$");

            while (!rxSalario.IsMatch(salarioAnalisado))
            {
                Console.WriteLine("Salário não está no formato correto de moeda. Exemplo: 1200,00");
                salarioAnalisado = Console.ReadLine();
            }

            return Convert.ToDouble(salarioAnalisado);
        }


    }
}
