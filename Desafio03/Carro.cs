using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio03
{
    class Carro : Veiculo
    {

        public int portas { get; set; }
        public int ano { get; set; }

      
        public Carro(int portas, int ano, string marca, string modelo, string cor, int combustivel, int velocidade, bool isligado):base(marca,modelo,cor,combustivel,velocidade,isligado)
        {
            this.portas = portas;
            this.ano = ano;
        }

        public Carro()
        {

        }

        public void acelerar()
        {
            if (isligado == true)
            {

                this.velocidade += 20;
                this.combustivel -= 1;

            }
            else
            {
                Console.WriteLine("voce precisa ligar o carro primeiro ");
            }

        }
        public void mostrarDados()
        {
            base.mostrarDados();
            Console.WriteLine("quatidade de portas : " +this.portas);
            Console.WriteLine("Qual é o ano do carro : " + this.ano);
                
            
        }
    }
}