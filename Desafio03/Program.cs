using System;

namespace Desafio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------CARRO-----------------------");
            Carro c1 = new Carro(4,2017,"Lamburguine","Galardo", "vermelha",100,240,false);
            c1.ligar();
            c1.acelerar();
            c1.mostrarDados();
            Console.WriteLine("---------------CAMINHÃO-------------------------");
            caminhao caa = new caminhao(10,"Scania","Tractor 600", "preto", 300,80,false);
            caa.ligar();
            caa.acelerar();
            caa.mostrarDados();
            Console.WriteLine("------------------AVIÃO------------------");
            Aviao av = new Aviao("Turbo"," Voos Comerciais" , "boing", "747","Branco",500,350,false);
            av.ligar();
            av.acelerar();
            av.mostrarDados();














        }
    }
}
