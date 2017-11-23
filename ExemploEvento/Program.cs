using System;

namespace ExemploEvento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro(10);
            c.TanqueVazio += new Carro.EventoCarro(tanque_vazio);
            c.TanqueVazio += new Carro.EventoCarro(ligar_uber);
            c.Ligacao += new Carro.Chamar(ligar_casa);
            c.Ligar();
        }
        static void tanque_vazio()
        {
            System.Console.WriteLine("Tanque Vazio!");
        }
        static void ligar_uber()
        {
            System.Console.WriteLine("Seu motorista está a caminho");
        }
        static void ligar_casa(string telefone)
        {
            System.Console.WriteLine("Ligando casa " + telefone);
        }
    }
}
