using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.MisClases;

namespace p1bpoo.MisClases
{
    public class Moto : Vehiculo
    {
        public Moto(int anio, string color, string modelo) : base(anio, color, modelo)
        {
            VelocidadMaxima = 120;
            CapacidadTanque = 10;
            ConsumoCombustible = 2;
            TiposLicenciaAceptados = new List<string> { "A", "M" };
        }

        public void HacerCaballito()
        {
            if (Estado != 2 || VelocidadActual <= 0)
            {
                Console.WriteLine("No se puede hacer un caballito si la moto está apagada o parada.");
                return;
            }

            if (VelocidadActual > 30)
            {
                Console.WriteLine("¡Demasiado rápido para hacer un caballito!");
                return;
            }

            Console.WriteLine("¡Haciendo un caballito!");
        }

        public override void InformacionVehiculo()
        {
            base.InformacionVehiculo();
            Console.WriteLine($"Capacidad del tanque: {CapacidadTanque} galones");
            Console.WriteLine($"Consumo de combustible: {ConsumoCombustible} galones/km");
        }
    }
}