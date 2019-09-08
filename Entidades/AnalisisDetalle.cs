using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AnalisisDetalle
    {
        [Key]

        public int AnalisisId { get; set; }
        public int UsuariosId { get; set; }
        public string Resultado { get; set; }

        public AnalisisDetalle()
        {
            AnalisisId = 0;
            UsuariosId = 0;
            Resultado = String.Empty;
        }
    }
}
