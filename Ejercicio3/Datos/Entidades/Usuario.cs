using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Usuario
    {
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }

        public Usuario()
        {
        }

        public Usuario(string idUsuario, string nombre, string clave)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Clave = clave;
        }

    }
}
