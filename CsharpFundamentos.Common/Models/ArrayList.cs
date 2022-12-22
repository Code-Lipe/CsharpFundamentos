using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsharpFundamentos.Common.Models
{
    public class ArrayList
    {

        public void TrabalhandoComArray()
        {
            int[] arrayInteiros = new int[4];

            arrayInteiros[0] = 72;
            arrayInteiros[1] = 64;
            arrayInteiros[2] = 50;
            arrayInteiros[3] = 1;

            // Array.Resize, redimensiona a capacidade da arrayInteiros (de 4 para 8)
            // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

            Console.WriteLine("Pecorrendo o Array com o FOR");
            for (int contador = 0; contador < arrayInteiros.Length; contador++)
            {
                Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
            }   

            Console.WriteLine("Pecorrendo o Array com o FOREACH");
            int contadorForeach = 0;
            foreach(int valor in arrayInteiros)
            {
                Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
                contadorForeach++;
            }
        }

        public void SaudacaoArray()
        {
            string[] namesArray = {"Felipe", "Pedro", "Gabriel"};

            foreach(string name in namesArray)
            {
                Console.WriteLine($"Bem vindo(a), {name}.");
            }
        }

        public void TrabalhandoComList()
        {
            List<string> listaString = new List<string>();

            listaString.Add("RJ");
            listaString.Add("ES");
            listaString.Add("SP");

            foreach(string estado in listaString)
            {
                Console.WriteLine($"Estado: {estado}");
            }
        }
    }
}