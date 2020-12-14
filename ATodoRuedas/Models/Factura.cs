using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ATodoRuedas.Models
{
    public class Factura
    {
        
        [Key]
        public int idFactura { get; set; }
        
        [Display(Name = "Tipo Factura")]
        [Required(ErrorMessage = "El tipo de factura es obligatorio")]
        [EnumDataType(typeof(EnumFactura))]
        public EnumFactura tipoFactura { get; set; }
        [Required(ErrorMessage = "El Importe es obligatorio")]
        [Range(0, 100000, ErrorMessage = "debe ser mayor a 0 y menor a 1.000.000")]
        public double importe { get; set; }
        [Required]
        [Display(Name = "id cliente")]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }


    

    }
    

}
