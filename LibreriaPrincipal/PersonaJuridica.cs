using System;

namespace LibreriaPrincipal
{
    public class PersonaJuridica : Persona
    {
        private String _razon;

        public String RazonSocial
        {
            get { return _razon; }
            set { _razon = value; }
        }

        private PersonaFisica _representante;

        public PersonaFisica Representante
        {
            get { return _representante; }
            set { _representante = value; }
        }

        private TipoPJ _tipo;

        public TipoPJ Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public override void DesplegarDatos()
        {
            Console.WriteLine("\t*** Informacion de Persona Juridica ***");
            Console.WriteLine("\t\tIdentificacion: " + Identificacion);
            Console.WriteLine("\t\tFecha de constitucion: " + Fecha);
            Console.WriteLine("\t\tDireccion: " + Direccion);
            Console.WriteLine("\t\tRazon Social: " + RazonSocial);
            Console.WriteLine("\t\tTipo: " + Tipo.ToString());
            Console.WriteLine("\t\t * Representante Legal * ");
            Representante.DesplegarDatos();
        }

        public PersonaJuridica()
        {
            Identificacion = "";
            Direccion = "";
            Fecha = DateTime.Now;
            Tipo = TipoPJ.Ninguno;
            RazonSocial = "";
            Representante = new PersonaFisica();
        }
    }

    public enum TipoPJ
    {
        Ninguno,
        SociedadAnonima,
        ResponsabilidadLimitada,
        Mercantil,
        Asociacion,
        ONG,
        SinFinesLucro
    }
}
