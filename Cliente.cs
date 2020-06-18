using System;

namespace SENAIIfood
{
    public class Cliente
    {
        public string Nome { get; set; }

        public Cliente(string _nome){
            this.Nome = _nome;
        }
        public string EnderecoAtual { get; set; }

        public string MostrarDados() {
             string dados = $"Nome: {Nome}\n Endereco de entrega: {EnderecoAtual}";

            return dados;
        }
    }
}