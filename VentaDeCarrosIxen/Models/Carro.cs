using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VentaDeCarrosIxen.Models
{
    public class Carro
    {
        [Key]
        public int idCarro { get; set; }
        public String modelo { get; set; }
        public String marca { get; set; }
        public String precio { get; set; }
        public String color { get; set; }
        public String combustible { get; set; }
        public int kilometros { get; set; }
        [Display(Name = "Año Fabricacion"), Required(ErrorMessage = "Año es oblligatoria")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime añoFabricacion { get; set; }
        public String descripcion { get; set; }
        public int cantidad { get; set; }
        public virtual List<Archivo> archivos { get; set; }
        public virtual List<Compra> compra { get; set; }

    }
}