
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIR.Domain
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public PessoaFisica(string nome, string cpf,  double salario, double impostoRenda)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
            ImpostoRenda = impostoRenda;
        }

        public PessoaFisica()
        {
          
        }

    }
}
