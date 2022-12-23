using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsharpFundamentos.Common.Models
{
    /// <summary>
    /// Representa: As estruturas de repetição (while e switch)
    /// </summary>
    public class EstruturaRepeticao
    {
        /// <summary>
        /// Uma calculadora mais elaborada 
        /// </summary>
        /// <param name="valor">Um número do tipo inteiro</param>
        /// <param name="sinal">Um operador (*, +, -, /) </param>
        public void Calculadora(int valor, string operador)
        {
            switch(operador)
            {
                case "*":
                    for(int contador = 0; contador <= 10; contador++)
                    {
                        Console.WriteLine($"{valor} x {contador} = {valor * contador}");
                    }
                    break;
                case "+":
                    for(int contador = 0; contador <= 10; contador++)
                    {
                        Console.WriteLine($"{valor} + {contador} = {valor + contador}");
                    }
                    break;
                case "-":
                    for(int contador = 0; contador <= 10; contador++)
                    {
                        Console.WriteLine($"{valor} - {contador} = {valor - contador}");
                    }
                    break;
                case "/":
                    for(int contador = 1; contador <= 10; contador++)
                    {
                        Console.WriteLine($"{valor} % {contador} = {valor / contador}");
                    }
                    break;
                default:
                    Console.WriteLine("Erro!, passe os argumentos corretamente.");
                    break;
                
            }
        }

        /// <summary>
        /// Um menu simples e interativo
        /// </summary>
        public void MenuInterativo()
        {
            string? opcao;
            bool exibirMenu = true;

            while(exibirMenu)
            {
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Buscar cliente");
                Console.WriteLine("3 - Apagar cliente");
                Console.WriteLine("4 - Encerrar");

                opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastro do cliente");
                        break;
                    case "2":
                        Console.WriteLine("Busca de cliente");
                        break;
                    case "3":
                        Console.WriteLine("Apagando cliente");
                        break;
                    case "4":
                        Console.WriteLine("Encerrando...");
                        exibirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        break;                
                }
            }
        }
    }
}