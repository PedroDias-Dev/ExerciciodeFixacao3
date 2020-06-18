using System;

namespace SENAIIfood
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente predo = new Cliente("Pedro");
            //predo.Nome = "Predo"; 
            predo.EnderecoAtual = "Casa do Predo";
            Console.WriteLine( predo.MostrarDados() );

            Restaurante PapaPizza = new Restaurante("PapaPizza");
            //PapaPizza.Nome = "PapaPizza";
            PapaPizza.Endereco = "Rua Marcelina, 223";
            
            Console.WriteLine( PapaPizza.MostrarDados() );

            string[] itens = { "Pizza 1", "Pizza 2"};
            Pedido pedido = new Pedido();
            
            pedido.Cliente = predo.Nome;
            pedido.Restaurante = PapaPizza.Nome;
            Console.WriteLine( pedido.EntregarPedido() );


        }
    }
}
