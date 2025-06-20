
// TODO: Realizar os testes com as classes Nokia e Iphone
using System;
using DesafioPOO.Models;

namespace SistemaCelulares
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone nokia = new Nokia("11999999999", "Nokia 3310", "123456789012345", 32);
            nokia.Ligar();
            nokia.InstalarAplicativo("Snake");

            Console.WriteLine();

            Smartphone iphone = new Iphone("11988888888", "iPhone 13", "987654321098765", 128);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
