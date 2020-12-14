using aTodoRuedas;
using ATodoRuedas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATodoRuedas.DataContext
{
    public class AplicacionDbContext : DbContext // instalamos entity framework core

    {
        //dentro de la clase creamos el constructor ( atajo escribir : ctor doble tab ) 
        public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options) : base(options) //investigar que pasa aca que hace este metodo?
        {

        }

        //fuera del constructor creamos el dbSet
        public DbSet<Cliente> cliente { get; set; } // dentro de <vamos a usar el modelo usuario> si hubiese varias tablas hay q agregar mas ( ejemplo categoria se agrega aca)
    }
}
