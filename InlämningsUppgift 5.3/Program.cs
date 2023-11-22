using System;
namespace InlämningUppgift_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in tre heltal som du vill veta summan av");
            int [] skrift = new int[3];
            skrift[0]=int.Parse(Console.ReadLine());
            skrift[1]=int.Parse(Console.ReadLine());
            skrift[2]=int.Parse(Console.ReadLine());
            int Tal1 = skrift[0];
            int Tal2 = skrift[1];
            int Tal3 = skrift[2];
            
            Console.WriteLine("Summan av talen du valt är: " + (Tal1 + Tal2 + Tal3));
            Console.ReadKey();
        }
    }
}