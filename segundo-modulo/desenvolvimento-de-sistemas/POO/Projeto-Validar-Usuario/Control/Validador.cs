using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidarUsuario.Model;

namespace ValidarUsuario.Control
{
    class Validador
    {
       public Validador()
        {

        }

        public string ValidarUsuario(Usuario usu)
        {
            if(usu.getLogin() == usu.getLogin() 
                && usu.getSenha()== usu.getSenha() && usu.getAtivo())
            {
                return usu.GetType().ToString() + " - Autorizado";
            }
            return usu.GetType().ToString() + " - Não autorizado!"; 
        }
    }
}
