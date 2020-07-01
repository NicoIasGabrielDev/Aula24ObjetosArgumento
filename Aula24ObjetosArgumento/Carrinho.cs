using System;
using System.Collections.Generic;

namespace Aula24ObjetosArgumento {
    public class Carrinho {
        //0-Propriedade para guardar o valor total do carrinho
        public float ValorTotal { get; set; }

        //1- Criamos uma lista que será o nosso carrinho
        List<Produto> carrinho = new List<Produto>();

        //2- Criando metodo para adicionar o item ao carrinho, passando obj como argumento

        public void AdicionarProduto (Produto produto) {
            carrinho.Add (produto);
        }

        //3- Criando metodo que irá remover um item do carrinho

        public void RemoverProduto (Produto produto) {
            carrinho.Remove (produto);
        }

        //4- Criando metodo para listar os itens que estão no carrinho

        public void MostrarProdutos() 
        {
            if (carrinho != null) 
            {
                foreach(Produto p in carrinho)
                {
                  Console.ForegroundColor = ConsoleColor.Green;
                  Console.WriteLine($" R$ {p.Preco.ToString("n2")} - {p.Nome} ");
                  Console.ResetColor();
                }
                MostrarTotal();
            }
        } 

        //5- Criando metodo para calcular total da compra:
        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            if(carrinho != null)
            {
                foreach(Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                Console.WriteLine($" O valor do carrinho é de R${ValorTotal.ToString("n2")}");            
            }else
            {
                Console.WriteLine($"Seu carrinho está vazio, tente de novo!");
            }   
            Console.ResetColor();
        }
        //6- Podemos alterar produtos
        public void AlterarItem(int _codigo,Produto _novoProduto){
        carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
        carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }   
    }
}