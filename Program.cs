using System;
using System.ComponentModel.Design;
using System.Globalization;
using _22___Desafio_Biblioteca;

namespace Desafio
{
    class Program
    {
        public static void Main(string[] args)
        {

            Biblioteca biblioteca = new Biblioteca();
            GestaoUsuarios gerirUsuario = new GestaoUsuarios();

            gerirUsuario.CriarUsuario("Fabio Nunes", "fabio.nunes", "123");
            gerirUsuario.CriarUsuario("Jonatas Cavalcante", "jonatas.cavalcante", "321");

            int opcao;
            int opcaoInicial;
            do {
                opcaoInicial = MenuInicial();
            } while (opcaoInicial != 1 && opcaoInicial != 2);

            switch (opcaoInicial)
            {
                case 1:
                    logar(gerirUsuario);
                    break;
                case 2:
                    Cadastrar(gerirUsuario);
                    break;
            }

            do
            {
                opcao = Menu();
                Acao(biblioteca, opcao);
            } while (opcao != 5);

            
        }

        public static string logar(GestaoUsuarios gerirUsuario)
        {
            int codLogar = 0;
            string mensagemLogin = "";
            bool sair = false;
            do
            {
                Console.WriteLine("\nDigite seu login: ");
                string login = Console.ReadLine();
                Console.WriteLine("Digite sua senha:");
                string senha = Console.ReadLine();

                codLogar = gerirUsuario.Logar(login, senha);

                if (codLogar == 1)
                {
                    mensagemLogin = $"\nBem vindo {gerirUsuario.getNome(login, true)}\n";
                    sair = true;
                }
                else if (codLogar == 2)
                {
                    mensagemLogin = $"\nSenha incorreta. Tente novamente.\n";
                }
                else
                {
                    mensagemLogin = "\nLogin não encontrado. Tente novamente.\n";

                }

                Console.WriteLine(mensagemLogin);

            }
            while (!sair);

            return mensagemLogin;
           
        }

        public static void Cadastrar(GestaoUsuarios gerirUsuarios)
        {
            Console.WriteLine("Digite seu nome: ");
            string nomeCriar = Console.ReadLine();
            Console.WriteLine("Digite seu login: ");
            string loginCriar = Console.ReadLine();
            Console.WriteLine("Digite sua senha:");
            string senhaCriar = Console.ReadLine();
            Console.WriteLine(gerirUsuarios.CriarUsuario(nomeCriar, loginCriar, senhaCriar));
            
        }

        public static int MenuInicial()
        {
            int opcaoInicial;

            Console.WriteLine("Digite uma opção: ");
            Console.WriteLine("1 - Logar" +
            "\n2 - Cadastrar");
            opcaoInicial = int.Parse(Console.ReadLine());

            if (opcaoInicial != 1 && opcaoInicial != 2)
            {
                Console.WriteLine("\nPor favor, digite uma opção correta (1/2)\n");
            }

            return opcaoInicial;
        }

        public static int Menu()
        {
            int opcao;

                Console.WriteLine("Selecione 1 opção: " +
                "\n1 - Listar todos os livros" +
                "\n2 - Devolver um livro" +
                "\n3 - Pegar um livro emprestado" +
                "\n4 - Cadastrar um livro" +
                "\n5 - Sair");

                opcao = int.Parse(Console.ReadLine());

            return opcao;
        }

        public static void Acao(Biblioteca biblioteca, int opcao)
        {
            switch (opcao)
            {
                case 1:
                    string todosLivros = biblioteca.ListarLivros();
                    Console.WriteLine("\n");
                    Console.WriteLine(todosLivros);
                    break;
                case 2:
                    Console.WriteLine("Digite o título do livro: ");
                    string tituloDevolucao = Console.ReadLine();
                    Console.WriteLine(biblioteca.DevolverLivro(tituloDevolucao));
                    break;
                case 3:
                    Console.WriteLine("Digite o título do livro: ");
                    string tituloEmprestimo = Console.ReadLine();
                    Console.WriteLine(biblioteca.EmprestarLivro(tituloEmprestimo));
                    break;
                case 4:
                    Console.WriteLine("Digite o titulo do livro");
                    string tituloCadastro = Console.ReadLine();
                    Console.WriteLine("Digite o autor do livro");
                    string autor = Console.ReadLine();
                    Console.WriteLine("Digite o ano de publicação do livro");
                    int anoPublicacao = int.Parse(Console.ReadLine());
                    biblioteca.AdicionarLivro(tituloCadastro, autor, anoPublicacao);
                    break;
            }
        }
    }
}