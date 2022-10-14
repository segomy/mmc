using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mmc.Modelos.ConsultasMovil
{
    public class Modelo:ClaseBase
    {
        [Key]
        public int ModeloId { get; set; }
        public String ModeloDescripcion { get; set; }

        public int IdSerie { get; set; }
        [ForeignKey("IdSerie")]
        public IEnumerable<Serie> Series { get; set; }

    }
}

