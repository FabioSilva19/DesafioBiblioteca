using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___Desafio_Biblioteca
{
    internal class Biblioteca
    {
        private List<Livro> livros = [];

        public string AdicionarLivro(string titulo, string autor, int anoPublicacao)
        {
            Livro novoLivro = new Livro(titulo, autor, anoPublicacao);
            livros.Add(novoLivro);
            return $"\nLivro adicionado com sucesso.";
        }

        public string ListarLivros()
        {
            string todosLivros = "";
            foreach(Livro livro in livros)
            {
                todosLivros += "\n" +livro.ExibirInformacoes() + "\n";
            };
            return todosLivros;
        }

        public string EmprestarLivro(string titulo)
        {
            foreach (Livro livro in livros)
            {
                if (livro.Titulo == titulo)
                {
                    string retorno = livro.Emprestar();
                    return retorno;
                }
            };

            return $"\nLivro {titulo} não encontrado.";

        }

        public string DevolverLivro(string titulo)
        {
            foreach (Livro livro in livros)
            {
                if (livro.Titulo == titulo)
                {
                    string retorno = livro.Devolver();
                    return retorno;
                }
            };

            return $"\nLivro {titulo} não encontrado.";
        }
    }
}
