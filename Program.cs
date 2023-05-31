using Lanchonete.Models;

namespace Lanchonete
{
    public class Menu
    {
        public static void Main(string[] args)
        {

            Cardapio cardapio = new Cardapio();
            
            cardapio.Batata = 6;
            cardapio.LancheFrango = 16;
            cardapio.LancheCarne = 20;
            cardapio.Refrigerante = 4;
            cardapio.Maionese = 1;
            cardapio.Salada = 2;
            
            System.Console.WriteLine("BEM VINDO A LANCHONETE FAÇA JÁ O SEU PEDIDO" +
            "\nVocê deseja lanche de Carne ou de Frango?     [1]Carne / [2] Frango");
            
            int pedidoLanche = int.Parse(System.Console.ReadLine());

            if(pedidoLanche == 1)
            {   
                System.Console.WriteLine("Quantos lanches de Carne você deseja?");
                int quantidade = int.Parse(System.Console.ReadLine());
                pedidoLanche = quantidade * cardapio.LancheCarne;
            }
            else if(pedidoLanche == 2)
            {
                System.Console.WriteLine("Quantos lanches de Frango você deseja?");
                int quantidade = int.Parse(System.Console.ReadLine());
                pedidoLanche = quantidade * cardapio.LancheFrango;
            }

            System.Console.WriteLine("Deseja batata frita? [1]Sim / [2] Nao");
            int pedidoBatatas = int.Parse(System.Console.ReadLine());
            if(pedidoBatatas == 1)
            {
                System.Console.WriteLine("Quantas Batatas você deseja?");
                int quantidade = int.Parse(System.Console.ReadLine());
                pedidoBatatas = quantidade * cardapio.Batata;
            }else{
                pedidoBatatas = 0;
            }

            System.Console.WriteLine("Deseja refri? [1]Sim / [2] Nao");
            int pedidoRefri = int.Parse(System.Console.ReadLine());

            if (pedidoRefri == 1)
            {
                System.Console.WriteLine("Quantos refris você deseja?");
                int quantidade = int.Parse(System.Console.ReadLine());
                pedidoRefri = quantidade * cardapio.Refrigerante;

            }else{
                pedidoRefri = 0;
            }

            System.Console.WriteLine("Deseja salada? [1]Sim / [2] Nao");
            int pedidoSalada = int.Parse(System.Console.ReadLine());

            if (pedidoSalada == 1)
            {
                pedidoSalada = cardapio.Salada;
            }else{
                pedidoSalada = 0;
            }

            System.Console.WriteLine("Deseja Maionese? [1]Sim / [2] Nao");
            int pedidoMaionese = int.Parse(System.Console.ReadLine());

            if (pedidoMaionese == 1)
            {   
                System.Console.WriteLine("deseja quantas maioneses?");
                int quantidade = int.Parse(System.Console.ReadLine());

                pedidoMaionese = quantidade * cardapio.Maionese;
            }else{
                pedidoMaionese = 0;
            }
            
            int totalCompra = pedidoBatatas + pedidoLanche + pedidoMaionese + pedidoRefri + pedidoSalada;
            System.Console.WriteLine($"O total do seu pedido ficou {totalCompra}");

        }
    }
}