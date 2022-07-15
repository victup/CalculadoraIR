﻿using CalculadoraIR.Domain;
using CalculadoraIR.Presentation.Telas.Interfaces;
using CalculadoraIR.Services;
using CalculadoraIR.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIR.Presentation.Telas
{
    public class AddPessoaFisicaScreen : IAddPessoaFisicaScreen
    {
        private readonly IPessoaFisicaService _pessoaFisicaService;
        private readonly ITaxCalculator _taxCalculator;
        public AddPessoaFisicaScreen(IPessoaFisicaService service, ITaxCalculator taxCalculator)
        {
          
            _pessoaFisicaService = service;
            _taxCalculator = taxCalculator;
           
        }

        public void Begin()
        {
            
            int op;
           
            do
            {
                
                Console.WriteLine(Mensagens.MenuPessoaFisica.Menu.MenuIncial);
                op = Validacoes.verificaOpcaoMenuInicial();

                if (op == 1)
                {
                    AddPessoaFisica();
                }
                else if (op == 2)
                {
                    BuscarPessoa();
                }

            }while(op != 3);
            

        }


        public void AddPessoaFisica()
        {
            Console.WriteLine(Mensagens.Labels.entreComSeuNomeLabel);
            var peopleName = Console.ReadLine();

            Console.WriteLine(Mensagens.Labels.entreComSeuCpfLabel);
            var cpf = Console.ReadLine();

            Console.WriteLine(Mensagens.Labels.entreComSeuSalarioLabel);

            bool salarioIsValid = double.TryParse(Console.ReadLine(), out var salario);

            var impostoRenda = _taxCalculator.TaxCalculation(salario);

            PessoaFisica novaPessoaFisica = new PessoaFisica(peopleName, cpf, salario, impostoRenda);


            _pessoaFisicaService.SalvarPessoaFisica(novaPessoaFisica);


          
            
        }

        public void BuscarPessoa()
        {
            Console.WriteLine(Mensagens.Labels.buscarComCpfLabel);
            var buscarCpf = Console.ReadLine();

            _pessoaFisicaService.BuscarPessoaFisica(buscarCpf);
        }

       
      
    }
}