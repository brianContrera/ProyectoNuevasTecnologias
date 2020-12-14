using aTodoRuedas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace ATodoRuedas.Models
{
    public class Cliente

    {
        /*el problema esta en esta clase*/

        [Key]

        public int id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String dni { get; set; }
 
       // public List<Factura> facturas { get; set; }
  
        //public List<Auto> autos { get; set; }



    }
}
