using System;

namespace SENAIIfood
{
    public class Restaurante
    {
        public string Nome {get; set;}
        public string Endereco {get; set;}
        public Restaurante (string _nome, string _endereço){
            this.Nome = _nome;
            this.Endereco = _endereço;
        }
        public string MostrarDados() {
            string dados = $"Nome: {Nome}\n Endereco do Restaurante: {Endereco}";

            return dados;

        }
    }
}