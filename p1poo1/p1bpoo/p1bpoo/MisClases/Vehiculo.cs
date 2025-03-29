using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.MisClases;

namespace p1bpoo.MisClases
{
    public abstract class Vehiculo
    {
        public int Anio { get; }
        public string Color { get; }
        public string Modelo { get; }
        public int VelocidadActual { get; protected set; }
        protected int VelocidadMaxima { get; set; }
        protected int CapacidadTanque { get; set; }
        protected int ConsumoCombustible { get; set; }
        public int Estado { get; protected set; }
        public Chofer PilotoAsignado { get; protected set; }
        public List<string> TiposLicenciaAceptados { get; protected set; }

        public Vehiculo(int anio, string color, string modelo)
        {
            Anio = anio;
            Color = color;
            Modelo = modelo;
            Estado = 0; // Apagado por defecto
            VelocidadActual = 0;
            TiposLicenciaAceptados = new List<string>();
        }

        public void Encender()
        {
            if (Estado == 0)
            {
                Estado = 1;
                Console.WriteLine("Vehículo encendido.");
            }
            else
            {
                Console.WriteLine("El vehículo ya está encendido.");
            }
        }

        public void Acelerar(int incremento)
        {
            if (Estado == 0)
            {
                Console.WriteLine("No se puede acelerar, el vehículo está apagado.");
                return;
            }

            if (VelocidadActual + incremento > VelocidadMaxima)
            {
                VelocidadActual = VelocidadMaxima;
                Console.WriteLine($"¡Alerta! No se puede superar la velocidad máxima de {VelocidadMaxima} km/h.");
            }
            else
            {
                VelocidadActual += incremento;
                Estado = 2; // En movimiento
                Console.WriteLine($"Acelerando a {VelocidadActual} km/h.");
            }
        }

        public void Frenar(int decremento)
        {
            if (VelocidadActual - decremento <= 0)
            {
                VelocidadActual = 0;
                Estado = 1; // Encendido pero detenido
                Console.WriteLine("Vehículo detenido completamente.");
            }
            else
            {
                VelocidadActual -= decremento;
                Console.WriteLine($"Frenando a {VelocidadActual} km/h.");
            }
        }

        public void Apagar()
        {
            if (VelocidadActual > 0)
            {
                Console.WriteLine("No se puede apagar el vehículo en movimiento.");
                return;
            }

            Estado = 0;
            Console.WriteLine("Vehículo apagado.");
        }

        public bool AsignarPiloto(Chofer piloto)
        {
            if (TiposLicenciaAceptados.Contains(piloto.TipoLicencia))
            {
                PilotoAsignado = piloto;
                Console.WriteLine($"Piloto {piloto.Nombre} asignado al vehículo.");
                return true;
            }

            Console.WriteLine($"El piloto {piloto.Nombre} no tiene la licencia adecuada para este vehículo.");
            return false;
        }

        public virtual void InformacionVehiculo()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Anio}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Velocidad actual: {VelocidadActual} km/h");
            Console.WriteLine($"Velocidad máxima: {VelocidadMaxima} km/h");

            string estado = Estado switch
            {
                0 => "Apagado",
                1 => "Encendido",
                2 => "En movimiento",
                _ => "Desconocido"
            };
            Console.WriteLine($"Estado: {estado}");

            Console.WriteLine(PilotoAsignado != null
                ? $"Piloto asignado: {PilotoAsignado.Nombre} (Licencia: {PilotoAsignado.TipoLicencia})"
                : "Sin piloto asignado");
        }
    }
}