using LibreriaPrincipal;
using System;

namespace InfoPersonas
{
    class InfoPersonas
    {
        static void Main(string[] args)
        {
            PersonaFisica perF = new PersonaFisica();
            PersonaJuridica perJ = new PersonaJuridica();
            perF.Identificacion = "1-1000-2000";
            perF.Fecha = new DateTime(1975, 4, 20);
            perF.Direccion = "San Jose";
            perF.Nombre = "Fernando";
            perF.Apellidos = "Torres Rojas";
            perF.Sexo = Genero.Masculino;
            perF.EstadoCivil = EstadoCivil.Casado;

            perJ.Identificacion = "3-101-123456";
            perJ.Fecha = new DateTime(2000, 6, 9);
            perJ.Direccion = "Alajuela";
            perJ.RazonSocial = "La empresa exitosa S.A";
            perJ.Tipo = TipoPJ.SociedadAnonima;
            perJ.Representante = perF;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            perJ.DesplegarDatos();
            Console.ReadLine();
        }
    }
}
