using ProyectoUNEDT1SJ1PM;
using System;

namespace AplicacionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Embarcacion miBarco = new Embarcacion();
            miBarco.Placa = "B123456789";
            miBarco.Tipo = TipoTransporte.Maritimo;
            miBarco.VelocidadMaxima = 70;
            miBarco.CapacidadCarga = 10000;
            miBarco.Bandera = "Costa Rica";
            miBarco.AnoFabricacion = 2015;

            PersonaFisica pf1 = new PersonaFisica();
            pf1.Nombre = "Jorge Campos";
            pf1.Direccion = "San Jose";
            pf1.FechaNacConst = new DateTime(1980, 12, 15);
            pf1.Cedula = "1-0982-02536";
            pf1.EstadoCivil = EstadosCiviles.Casado;
            pf1.Sexo = 1;

            PersonaJuridica pj1 = new PersonaJuridica();
            pj1.Cedula = "3-101-591486";
            pj1.Direccion = "Limon";
            pj1.FechaNacConst = new DateTime(2008, 12, 09);
            pj1.Nombre = "Maersk Line";
            pj1.Tipo = TipoPJ.Mercantil;
            pj1.RepresentanteLegal = pf1;

            miBarco.Propietario = pj1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            miBarco.MostrarInformacion();

            Console.ReadLine();
        }
    }
}
