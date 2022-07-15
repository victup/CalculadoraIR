using CalculadoraIR.Domain;
using CalculadoraIR.Services.Interfaces;
using CalculadoraIR.Services.Mensagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIR.Services
{
    public class PessoaFisicaService : IPessoaFisicaService, IPessoaService
    {

        public List<PessoaFisica> ListaPessoas { get; set; } = new List<PessoaFisica>();
  

      
        public void SalvarPessoaFisica(PessoaFisica pf)
        {
            ListaPessoas.Add(pf);
        }

        public void BuscarPessoaFisica(string cpf)
        {
            var contPessoaEncontrada = 0;

            foreach (PessoaFisica pessoaAnalisada in ListaPessoas)
            {
              if (pessoaAnalisada.Cpf.ToString() == cpf)
                {
                    Console.WriteLine(@$"{Mensagens.Mensagens.ApresentacaoImpostoDeRenda}");
                    Console.WriteLine(@$"{Mensagens.Labels.nomeLabel + pessoaAnalisada.Nome}");
                    Console.WriteLine(@$"{Mensagens.Labels.cpfLabel + pessoaAnalisada.Cpf}");
                    Console.WriteLine(@$"{Mensagens.Labels.salarioLabel + pessoaAnalisada.Salario}");
                    if(pessoaAnalisada.ImpostoRenda > 0)
                    {
                        Console.WriteLine(@$"{Mensagens.Labels.ImpostoDeRendaLabel + pessoaAnalisada.ImpostoRenda}");
                    }
                    else
                    {
                        Console.WriteLine(@$"{Mensagens.Labels.ImpostoDeRendaLabel}ISENTO");
                    }
                    
                    contPessoaEncontrada++;
                }
            }

            if (contPessoaEncontrada == 0)
            {
                Console.WriteLine(Mensagens.Mensagens.PessoaNaoEncontrada);
            }

            
        }

   
     
    }
}
