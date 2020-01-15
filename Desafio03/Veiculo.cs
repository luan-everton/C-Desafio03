using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio03
{
    class Veiculo
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public int combustivel { get; set; }
        public int velocidade { get; set; }
        public bool isligado { get; set; }

		public Veiculo(string marca, string modelo, string cor, int combustivel, int velocidade, bool isligado)
		{
			this.marca = marca;
			this.modelo = modelo;
			this.cor = cor;
			this.combustivel = combustivel;
			this.velocidade = velocidade;
			this.isligado = isligado;
		}

		public Veiculo()
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
				Console.WriteLine ("voce precisa ligar o vaiculo primeiro ");
			}

		}

		public void abastecer(int QtdCombustivel)
		{
			this.combustivel += QtdCombustivel;

		}

		public void ligar()
		{
			if (this.isligado == true)
			{
				Console.WriteLine("veiculo esta ligado");

			}
			else
			{
				this.isligado = true;

			}

		

		}
		public void mostrarDados()

		{
			Console.WriteLine("Qual é a marca: " +this.marca);
			Console.WriteLine("Qual é o modelo: " + this.modelo);
			Console.WriteLine("Qual é a velocidade : " + this.velocidade);
			Console.WriteLine("Limite de combustivel: " + this.combustivel+" Litros");
			Console.WriteLine("velocidade atual: " + this.velocidade);
			Console.WriteLine("Esta ligado: " + this.isligado);

		}

	}

}

