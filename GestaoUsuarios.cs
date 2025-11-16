using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___Desafio_Biblioteca
{
    internal class GestaoUsuarios
    {
        private List<Usuario> usuarios = [];


        public string CriarUsuario(string nome, string login, string senha)
        {
            Usuario novoUsuario = new Usuario(nome, login, senha);
            usuarios.Add(novoUsuario);
            return "\nUsuário criado com sucesso!";
        }

        public int Logar(string login, string senha)
        {
            int codigoRetorno = 0;
            foreach(Usuario usuario in usuarios){
                if (usuario.Login == login)
                {
                    if (usuario.Senha == senha)
                    {
                        codigoRetorno = 1;
                        
                    }
                    else
                    {
                        codigoRetorno = 2;
                  
                    }
                    break;
                }
                else
                {
                    codigoRetorno = 3;
                }

            };

            return codigoRetorno;
        }

        public string getNome(string login, bool logado)
        {
            string nome = "";
            if (logado)
            {
                usuarios.ForEach(usuario => {
                    if (usuario.Login == login)
                    {
                        nome = usuario.Nome;
                    }
                });
            }

            return nome;
        }
    }
}
