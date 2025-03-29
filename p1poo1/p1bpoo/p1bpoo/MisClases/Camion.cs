using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.MisClases;

namespace p1bpoo.MisClases
{
    public class Camion : Vehiculo
    {
        public int CapacidadCarga { get; } // en kg

        public Camion(int anio, string color, string modelo, int capacidadCarga) : base(anio, color, modelo)
        {
            VelocidadMaxima = 90;
            CapacidadTanque = 150;
            ConsumoCombustible = 5;
            CapacidadCarga = capacidadCarga;
            TiposLicenciaAceptados = new List<string> { "C", "D" };
        }

        public override void InformacionVehiculo()
        {
            base.InformacionVehiculo();
            Console.WriteLine($"Capacidad de carga: {CapacidadCarga} kg");
            Console.WriteLine($"Capacidad del tanque: {CapacidadTanque} galones");
            Console.WriteLine($"Consumo de combustible: {ConsumoCombustible} galones/km");
        }
    }
}