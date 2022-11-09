using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmc.Modelos.ConsultasMovil
{
    public class Marca:ClaseBase
    {
        [Key]
        public int MarcaId { get; set; }
        public String MarcaDescripcion { get; set; }

        public int ModeloId { get; set; }
        [ForeignKey("ModeloId")]
        public IEnumerable<Modelo> Modelos { get; set; }

        // iniciales  MARDESC
        // comptleto descripcion 
        // lowercamelcase marDesc  marDescripcion  marcaDescripcion 
        // upercamelcase  MarDesk  MarDescripcion  MarcaDescripcion 
        // Descripcion  FechaAlta 
    }
}

