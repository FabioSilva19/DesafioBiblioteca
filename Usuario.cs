using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___Desafio_Biblioteca
{
    internal class Usuario
    {
        public string Nome {  get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }

        public Usuario(string nome, string login, string senha) {
            Nome = nome;
            Login = login;
            Senha = senha;
        }
    }
}
