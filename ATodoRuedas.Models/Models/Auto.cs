using System;

using System.ComponentModel.DataAnnotations;


namespace aTodoRuedas
{
   public class Auto
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "El patente es obligatorio")]
        public String patente { get; set; }

        [Required(ErrorMessage = "El telefóno es obligatorio")]
        public double km { get; set; }


        [Display(Name = "Año fabricacion")]
        [Required(ErrorMessage = "El telefóno es obligatorio")]
        public int anioFab { get; set; }

        [Required(ErrorMessage = "El telefóno es obligatorio")]
        public String modelo { get; set; }

        [Required(ErrorMessage = "El telefóno es obligatorio")]
        public double precio { get; set; }

        [Required(ErrorMessage = "El telefóno es obligatorio")]
        [Display(Name = "esta disponible")]
        public Boolean disponible { get; set; }
    }
}
