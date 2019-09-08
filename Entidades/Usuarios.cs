using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        [Key]

        public int UsuariosId { get; set; }
        public String Nombres { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }

        public Usuarios()
        {
            UsuariosId = 0;
            Nombres = String.Empty;
            Direccion = String.Empty;
            Telefono = String.Empty;
        }
    }
}
