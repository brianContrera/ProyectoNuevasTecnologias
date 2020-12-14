using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

namespace aTodoRuedas
{
    class Pricipal{
        private String nombre;
        private ArrayList autos;


        private void GenerarFactura(Factura factura) { }
        private void RegistrarCliente(String nombre,String apellido, String dni) { }
        private void CargarAuto(String patente,double km, int anioFab,String modelo, double precio, Boolean disponible) { }
        private void MostrarAutos() { }

        private Boolean validarNombre(String nombre){
            Boolean validado = false;
            return validado;}
        private Boolean existeVehiculo(Auto auto)        {
            Boolean existe = false;
            return existe;
        }
        private Auto BuscarVehiculo(String patente) { }
        private void alquilar(Auto auto, Cliente cliente, Factura factura) { }

    }
}
