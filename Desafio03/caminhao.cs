using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio03
{
    class caminhao:Veiculo
    {
        public caminhao(int capacidadeKG, string marca, string modelo, string cor, int combustivel, int velocidade, bool isligado):base(marca,modelo,cor,combustivel,velocidade,isligado)
        {
            this.capacidadeKG = capacidadeKG;
        }

        public caminhao()
        {

        }


        public int capacidadeKG { get; set; }
        public void acelerar()
        {
            if (isligado == true)
            {

                this.velocidade += 20;
                this.combustivel -= 1;

            }
            else
            {
                Console.WriteLine("voce precisa ligar o  caminhao primeiro ");

            }

        }

        public void mostarDados()
        {
            base.mostrarDados();
            Console.WriteLine("Capacidade total de peso: "+ this.capacidadeKG+" Toleladas");
        }


    }
}
