using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio03
{
    class Aviao : Veiculo
    {
        public string tipo { get; set; }
        public string uso { get; set; }

        public Aviao(string tipo, string uso, string marca, string modelo, string cor, int combustivel, int velocidade, bool isligado):base(marca,modelo,cor,combustivel,velocidade,isligado)
        {
            this.tipo = tipo;
            this.uso = uso;
        }

        public Aviao()
        {

        }

        public void acelerar()
        {
            if (isligado == true)
            {

                this.velocidade += 20;
                this.combustivel -= 1;

            } else
            {
                Console.WriteLine("voce precisa ligar o aviao primeiro ");
            }
        }

        public void mostrarDados()
        {
            base.mostrarDados();
            Console.WriteLine("Qual e o tipo do aviao :"+ this.tipo);
            Console.WriteLine("Para que é usado :" + this.uso);
        }
    }
}