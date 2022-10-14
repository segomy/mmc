using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mmc.Modelos.ConsultasMovil
{
    public class Serie:ClaseBase
    {
        [Key]
        public int SerieoId { get; set; }
        public String SerieDescripcion { get; set; }

        //public int ModeloId { get; set; }
        //[ForeignKey("ModeloId")]
        //public IEnumerable<Modelo> Modelos { get; set; }
    }
}

