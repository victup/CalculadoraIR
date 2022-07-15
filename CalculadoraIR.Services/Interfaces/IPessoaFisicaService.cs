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
        void AddPessoaFisica(PessoaFisica pf);

        public void SalvarPessoaFisica(PessoaFisica pessoa);

        public void BuscarPessoaFisica(string nome);

        
    }
}
