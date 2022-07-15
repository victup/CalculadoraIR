using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIR.Presentation.Telas.Mensagens.MenuPessoaFisica
{
    public class Menu
    {
        public const string MenuIncial = @" 
----------------------------
Bem vindo ao IR Calculator.
----------------------------
1 - Calcular Imposto de Renda
2 - Buscar Imposto Calculado Anteriormente
3 - Sair
";

        public const string TabelaCalculos = @" 
-------------------------------------------------------------
Faixas de Valor ($) 	             Aliquota 	    Deduzir
-------------------------------------------------------------
Até 22.847,76.........................Isento........Isento
De 22.847,77 a 33.919,80..............0,075.........1.713,58
De R$ 33.919,81 a 45.012,60...........0,150.........4.257,57
De R$ 45.012,61 a 55.976,16...........0,225.........7.633,51
Acima de 55.976,16....................0,275.........10.432,32
";

    }
}
