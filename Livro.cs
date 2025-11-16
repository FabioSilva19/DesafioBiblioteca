using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___Desafio_Biblioteca
{
    internal class Livro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int AnoPublicacao { get;}
        public bool Disponivel { get; private set; }

        public Livro(string titulo,string autor, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            Disponivel = true;
        }

        public string ExibirInformacoes() {
            string disponibilidade = Disponivel ? "Disponível" : "Indisponível";
            return $"\nTitulo: {Titulo}" +
                $"\nAutor: {Autor}" +
                $"\nAno de publicação: {AnoPublicacao}" +
                $"\nDisponibilidade: {disponibilidade}";
        }

        public string Emprestar()
        {
            if (Disponivel)
            {
                Disponivel = false;
                return $"\nLivro {Titulo} emprestado com sucesso!";
            }

            return $"\nLivro {Titulo} indisponível no momento.";
        }

        public string Devolver()
        {
            if (!Disponivel)
            {
                Disponivel = true;
                return $"\nLivro {Titulo} devolvido com sucesso!";
            }

            return $"\nLivro {Titulo} não pode ser devolvido.";
        }
    }
}
