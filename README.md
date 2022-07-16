Este projeto visa utilizar principios do SOLID.
Projeto: Calculando IR

Crie um programa que receba um valor e apresente o imposto a ser pago com base na tabela abaixo¹:
![image](https://user-images.githubusercontent.com/38474570/179327859-72709b15-ea40-472f-baaf-4f08ed576678.png)


O programa deve seguir algumas diretrizes:

    Estar dividido em 3 camadas principais:

    Domain: camada responsável por conter:
        Classes que são apenas para conter dados (POCOs/DTOs)
        Enums
        Extensões
        Qualquer outro tipo de informação que seja comum a todas as camadas
    Presentation: camada que representa o console app. Nesta camada poderemos ter:
        Uma interface que represente a lógica da "tela".
        Uma classe que contenha a lógica da "tela". A lógica da tela não deve estar diretamente no método Main da classe Program
        A classe deve receber a 'injeção' da interface através do construtor da classe
        Mensagens apresentadas aos usuário
        Entrada de dados
        Montagem dos objetos que contém dados (POCOs/DTOs)
        Criação do container para injeção de dependência
    Services: camada responsável por conter as regras de negócio. Essa camada terá a princípio:
        Uma interface ITaxCalculator com um método: TaxCalculation
        A implementação dessa interface

Segue abaixo exemplo da interface:

![image](https://user-images.githubusercontent.com/38474570/179327810-8cf3e044-9986-49bb-ab3f-b9a269831402.png)

A tabela representa o cálculo de imposto anual para verificar se um contribuinte pagou mais ou menos imposto durante um ano. Caso o valor esteja acima da soma de impostos retidos ma fonte durante um ano o contribuinte poderá ter uma restituição. Essa informação é apenas a título de curiosidade em nada afeta o comportamento do programa.
