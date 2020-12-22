using System;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Usuario
    {

        public Usuario(){
            // Cadastar usuário automaticamente quando esta classe for intanciada
            Cadastrar();

        }


        public Usuario( int _codigo, string _nome, string _email, string _senha){
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.UtcNow;


        }




        int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }   

        DateTime DataCadastro { get; set; }

        public void Cadastrar(){
            Nome = "Paulo";
            Email = "admin@admin.com";
            Senha = "123456";
            DataCadastro = DateTime.UtcNow;           
        }
        
        public void Deletar(){
            Nome = "";
            Email = "";
            Senha = "";
            //2020-00-21t09:44:25
            DataCadastro = DateTime.Parse("0000-00-00t00>00:00");
            

        }

    }
}