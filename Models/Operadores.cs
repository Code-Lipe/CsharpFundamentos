using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsharpFundamentos.Models
{
    public class Operadores
    {
        public void Atribuicao(int a, int b)
        {
            int c = a + b;

            Console.WriteLine($"O resultado entre: {a} + {b} = {c}");
        }

        public void Condicionais(int quantidadeCompra=0)
        {
            int quantidadeEstoque = 10;
            bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

            Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
            Console.WriteLine($"Quantidade na compra: {quantidadeCompra}");

            if (quantidadeCompra == 0)
            {  
                Console.WriteLine("Venda inválida!");
            }
            else if (possivelVenda)
            {
                Console.WriteLine("Venda ralizada.");
            }
            else
            {
                Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
            }
        }

        public void CondicionaisSwitch()
        {
            Console.WriteLine("Digite uma letra:");
            string? letra = Console.ReadLine();

            switch(letra)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("Vogal");
                    break;
                default:
                    Console.WriteLine("Não é uma vogal");
                    break;
            }
        }

        public void Logicos(bool maiorDeIdade, bool possuiAutorizacao=false)
        {
            Console.WriteLine("Bem-vindo(a) ao festival!");
            Console.WriteLine($"Maior de idade: {maiorDeIdade}");
            Console.WriteLine($"Possui autorização do responsavel: {possuiAutorizacao}");
            Console.WriteLine("Analisando as informações...");
            Console.WriteLine("");

            if (maiorDeIdade || possuiAutorizacao)
            {
                Console.WriteLine("Entrada liberada!");
                
                Console.WriteLine("Qual a nota você dar ao show? [0 - 10]");
                double notaMediaDoShow = 5.0;
                double notaDoShow = Convert.ToDouble(Console.ReadLine());
                
                if (notaDoShow >= notaMediaDoShow && notaDoShow <= 10)
                {
                    Console.WriteLine("Show foi irado! Obrigado e volte sempre!");
                }
                else if (notaDoShow > 10)
                {
                    Console.WriteLine("Vamos entender essa nota como MUITO IRADO!");
                }
                else
                {
                    Console.WriteLine("Agradecemos por comparecer, prometemos melhorar.");
                }
                
            }
            else
            {
                Console.WriteLine("Barrodo(a)!");

            }
        }

        public void Aritmeticos(int valorX, int valorY)
        {
            Console.WriteLine("=== CALCULADORA ===");
            Console.WriteLine($"Somar: {valorX} + {valorY} = {valorX + valorY}");
            Console.WriteLine("=====================");

            Console.WriteLine($"Subtrair: {valorX} - {valorY} = {valorX - valorY}");
            Console.WriteLine("=====================");

            Console.WriteLine($"Multiplicar: {valorX} x {valorY} = {valorX * valorY}");
            Console.WriteLine("=====================");

            Console.WriteLine($"Dividir: {valorX} / {valorY} = {valorX / valorY}");
            Console.WriteLine("=====================");

            double pot = Math.Pow(valorX, valorY);
            Console.WriteLine($"Potência: {valorX} ^ {valorY} = {pot}");

        }
    }
}