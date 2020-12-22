using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Produto
    {
        public int Codigo { get; set;}
        public string NomeProduto { get; set;}
        public float Preco{ get; set;}
        
        public DateTime DataCadastro { get; set ;}
        Marca Marca { get; set; }
        public Usuario CadastradoPor { get; set;}
        public List<Produto> ListaDeProduto = new List<Produto>();


        public void Cadastrar(){

            Produto novoProduto = new Produto();

            Console.WriteLine("Digite o código do Produto:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do Produto:");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do Produto:");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            DataCadastro = DateTime.UtcNow;

            // Atribuimos nossa marca através de um método criado para cadastro
            novoProduto.Marca = Marca.CadastrarMarca();

            // Atribuimos o usuários através do método construtor
            novoProduto.CadastradoPor = new Usuario();

            ListaDeProduto.Add(novoProduto);
        }

        public void Listar(){
                
            Console.ForegroundColor = ConsoleColor.Green;
            foreach( var item in ListaDeProduto)
            {
                Console.WriteLine($"Código{item.Codigo}");
                Console.WriteLine($"Produto{item.NomeProduto}");
                Console.WriteLine($"Preço{item.Preco}");
                Console.WriteLine($"Data de Cadastro:{item.DataCadastro}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado por: {item.CadastradoPor.Nome}");
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        public void Deletar(int cod){
            Produto prodDelete = ListaDeProduto .Find(p => p.Codigo == cod);
            ListaDeProduto.Remove(prodDelete);

        }


    }
}