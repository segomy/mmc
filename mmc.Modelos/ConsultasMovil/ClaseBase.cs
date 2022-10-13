using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmc.Modelos.ConsultasMovil
{
   public class ClaseBase
    {
        [Key]
        public int Id { get; set; }
        public string UsuarioAlta { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaModifica { get; set; }
        public bool Estado { get; set; }
    }
}
