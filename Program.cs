﻿using System;
using System.Threading;

namespace EncontroRemoto
{
   class Program
   {
       static void Main(string[] args)
       {
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.DarkGreen;
           Console.BackgroundColor = ConsoleColor.White;
           Console.WriteLine(@$"
========================================
|  Bem-vindo ao Sistema de Cadastro    |
|  de Pessoa Física e Pessoa Jurídica  |
========================================
");
            BarraCarregamento("Iniciando");

            string? opcao;
           
            do
            {
                Console.WriteLine(@$"
===================================
| Escolha uma das opções abaixo   |
|        1 - Pessoa Física        |
|        2 - Pessoa Jurídica      |
|                                 |
|        0 - Sair                 |
===================================
");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    
                        Endereco endPF = new Endereco();

                        endPF.logradouro = "avenida anotonio";
                        endPF.numero = 3398;
                        endPF.complemento = "casa 100";
                        endPF.enderecoComercial = false;

                        PessoaFisica novapf = new PessoaFisica();

                        novapf.endereco = endPF;
                        novapf.cpf = "123456789";
                        novapf.rendimento = 1500;
                        novapf.dataNascimento = new DateTime(1994, 09, 22);
                        novapf.nome = "Vinicius Fernandes dos Santos";

                        PessoaFisica pf = new PessoaFisica();
                        //pf.ValidarDataNascimento(pf.dataNascimento);

                         Console.WriteLine(pf.PagarImposto(novapf.rendimento).ToString("N2"));

                        
                        bool idadeValida = pf.ValidarDataNascimento(novapf.dataNascimento);
                        Console.WriteLine(idadeValida);

                        if (idadeValida == true)
                        {
                            Console.WriteLine($"Cadastro Aprovado");    
                        }
                        else
                        {
                            Console.WriteLine($"Cadastro Não Aprovado");
                        }

                        //Console.WriteLine(pf.ValidarDataNascimento(novapf.dataNascimento));
                        //Console.WriteLine("Rua: " + novapf.endereco.logradouro + ", " + novapf.endereco.numero);
                        break;

                    case "2":

                        PessoaJuridica pj = new PessoaJuridica();

                        PessoaJuridica novapj = new PessoaJuridica();

                        Endereco endPJ = new Endereco();

                        endPJ.logradouro = "Rua Nova";
                        endPJ.numero = 745;
                        endPJ.complemento = "Perto da igreja Santa Terezinha";
                        endPJ.enderecoComercial = true;

                        novapj.endereco = endPJ;
                        novapj.cnpj = "1234567890001";
                        novapj.rendimento = 8000;
                        novapj.razaoSocial = "Pessoa Juridica";
                        
                        Console.WriteLine(pj.PagarImposto(novapj.rendimento).ToString("N2"));
                        break;

                    case "0":
                        Console.WriteLine($"Obrigado por utilizar o nosso sistema !");
                        BarraCarregamento("Finalizando");
                        break;

                    default:
                        Console.WriteLine($"Opção inválida, digite uma opção válida");

                        break;
                }
                
            } while (opcao != "0");                                   
        }

        static void BarraCarregamento(string textoCarregamento)
        {
            Console.ResetColor(); 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(textoCarregamento);
            Thread.Sleep(500);


            for (var contador = 0; contador < 10; contador++)
            {
                
                Console.Write($".");
                Thread.Sleep(500);            
            }
            Console.ResetColor();  


        }
   }
}