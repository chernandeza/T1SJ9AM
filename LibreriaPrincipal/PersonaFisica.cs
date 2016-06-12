using System;

namespace LibreriaPrincipal
{
    public class PersonaFisica : Persona
    {
        private String _nombre;

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private String _apellidos;

        public String Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        private Genero _sexo;

        public Genero Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        private EstadoCivil _estadoCivil;

        public EstadoCivil EstadoCivil
        {
            get { return _estadoCivil; }
            set { _estadoCivil = value; }
        }

        public override void DesplegarDatos()
        {
            Console.WriteLine("\t*** Informacion de Persona Fisica ***");
            Console.WriteLine("\t\tIdentificacion: " + Identificacion);
            Console.WriteLine("\t\tFecha de nacimiento: " + Fecha);
            Console.WriteLine("\t\tDireccion: " + Direccion);
            Console.WriteLine("\t\tNombre: " + Nombre + " " + Apellidos);
            Console.WriteLine("\t\tSexo: " + Sexo.ToString());
            Console.WriteLine("\t\tEstado Civil: " + EstadoCivil.ToString());    
        }

        public PersonaFisica()
        {
            Identificacion = "";
            Direccion = "";
            Fecha = DateTime.Now;
            Nombre = "";
            Apellidos = "";
            Sexo = Genero.Ninguno;
            EstadoCivil = EstadoCivil.Ninguno;
        }
    }

    public enum Genero
    {
        Ninguno,
        Masculino,
        Femenino,
        NoEspecifica
    }

    public enum EstadoCivil
    {
        Ninguno,
        Soltero,
        Casado,
        Viudo,
        Divorciado,
        UnionLibre
    }
}
