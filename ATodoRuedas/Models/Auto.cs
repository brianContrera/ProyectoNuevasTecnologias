using ATodoRuedas.Models;
using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aTodoRuedas
{
    public class Auto
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "La patente es obligatoria")]
        public String patente { get; set; }

        [Required(ErrorMessage = "El km es obligatorio")]
        public double km { get; set; }

        [Display(Name = "Año fabricacion")]
        [Required(ErrorMessage = "El año fabricacion es obligatorio")]
        public int anioFab { get; set; }

        [Required(ErrorMessage = "El modelo es obligatorio")]
        public String modelo { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        [Range(0, 100000, ErrorMessage = "debe ser mayor a 0 y menor a 1.000.000")]
        public double precio { get; set; }
        [Required]
        [Display(Name = "Id cliente")]
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }






    }
    
}
