using aTodoRuedas;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;



namespace ATodoRuedas.Models
{
    public class Cliente

    {
        [Key]
        
        public int id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String dni { get; set; }
        //public ArrayList autosAlquilados { get; set; }


       // public void alquiler() { }
        //public Auto DevolverAuto()
        //{
          //  return null;
        //}
    }
}
