using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Usuarios
    {
        string usuario, contrasena, tipo;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        
        public bool Iniciar(string user, string pass)
        {
            if (usuario == user && contrasena == pass)
                return true;
            return false;
        }
    }
}
