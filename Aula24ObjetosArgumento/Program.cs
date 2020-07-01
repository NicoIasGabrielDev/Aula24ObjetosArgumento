using System;

namespace Aula24ObjetosArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando alguns produtos
            Produto p1 = new Produto(1,"Açucar", 5f);
            Produto p2 = new Produto(2, "Feijão", 6f);
            Produto p3 = new Produto(3,"Macarrão", 4f);
            Produto p4 = new Produto(4,"Refrigerante",7f);

            //adicionando eles ao carrinho[]
            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);  
            carrinho.AdicionarProduto(p3);  
            carrinho.AdicionarProduto(p4);

            //mostrando todos os itens do carrinho:
            carrinho.MostrarProdutos();              
        }
    }
}
