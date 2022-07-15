using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIR.Domain
{
    public abstract class Pessoa
    {
        public Guid IdPessoa { get => Guid.NewGuid();  }
        public string Nome { get; set; }

        public double ImpostoRenda { get; set; }

    }
}
