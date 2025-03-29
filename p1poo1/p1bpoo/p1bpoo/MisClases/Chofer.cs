using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class Chofer
    {
        public string Nombre { get; }
        public int Edad { get; }
        public string TipoLicencia { get; }

        public Chofer(string nombre, int edad, string tipoLicencia)
        {
            // Validar requisitos de edad según licencia en Guatemala
            switch (tipoLicencia.ToUpper())
            {
                case "A": // Motocicletas
                    if (edad < 16)
                        throw new ArgumentException("Para licencia tipo A (motocicletas) se requiere mínimo 16 años");
                    break;
                case "B": // Vehículos livianos
                    if (edad < 18)
                        throw new ArgumentException("Para licencia tipo B (vehículos livianos) se requiere mínimo 18 años");
                    break;
                case "C": // Vehículos pesados
                    if (edad < 21)
                        throw new ArgumentException("Para licencia tipo C (vehículos pesados) se requiere mínimo 21 años");
                    break;
                case "D": // Transporte público
                    if (edad < 25)
                        throw new ArgumentException("Para licencia tipo D (transporte público) se requiere mínimo 25 años");
                    break;
                default:
                    throw new ArgumentException("Tipo de licencia no válido. Los tipos son: A, B, C, D");
            }

            Nombre = nombre;
            Edad = edad;
            TipoLicencia = tipoLicencia.ToUpper();
        }
    }
}