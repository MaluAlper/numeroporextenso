using System;
using Humanizer;
namespace numeroporextenso


//Receba um número inteiro e exiba-o por extenso.


{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Escreva um número e e ele aparecerá por extenso.");
            Console.Write("Digíte um número: ");
            int numero=Convert.ToInt32(Console.ReadLine()); 
            string numero2=numero.ToWords();
            Console.Clear();
            Console.WriteLine($"O número por extenso é= {numero2}");
        }
    }
}
