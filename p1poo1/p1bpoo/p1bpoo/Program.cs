using p1bpoo.MisClases;

try
{
    // Crear choferes con validación de licencia
    Chofer piloto1 = new Chofer("Monica", 21, "B");
    Chofer piloto2 = new Chofer("Andrea", 31, "C");
    Chofer piloto3 = new Chofer("Pedro", 24, "A"); // Licencia para moto
    Chofer piloto4 = new Chofer("Juan", 27, "D");

    // Crear vehículos
    Moto miMoto = new Moto(2023, "Rojo", "Honda CBR");
    Camion miCamion = new Camion(2025, "Azul", "Volvo FH", 20000);

    // Asignar pilotos
    miMoto.AsignarPiloto(piloto3); // Correcto (licencia A)
    miCamion.AsignarPiloto(piloto2); // Correcto (licencia C)

    // Probar funcionalidades
    miMoto.Encender();
    miMoto.Acelerar(50);
    miMoto.HacerCaballito();
    miMoto.InformacionVehiculo();

    miCamion.Encender();
    miCamion.Acelerar(100); // Intentar superar velocidad máxima
    miCamion.Frenar(20);
    miCamion.Apagar();
    miCamion.InformacionVehiculo();
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error al crear chofer: {ex.Message}");
}


