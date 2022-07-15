using CalculadoraIR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIR.Services.Interfaces
{
    public interface IPessoaFisicaService
    {

        public void SalvarPessoaFisica(PessoaFisica pessoa);

        public void BuscarPessoaFisica(string nome);

        
    }
}
