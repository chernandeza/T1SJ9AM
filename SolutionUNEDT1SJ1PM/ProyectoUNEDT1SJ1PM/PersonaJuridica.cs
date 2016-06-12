using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUNEDT1SJ1PM
{
    public class PersonaJuridica : Persona
    {
        private TipoPJ _tipoPerJ;
        /// <summary>
        /// Tipo de persona juridica
        /// </summary>
        public TipoPJ Tipo
        {
            get { return _tipoPerJ; }
            set { _tipoPerJ = value; }
        }

        private PersonaFisica _repLegal;
        /// <summary>
        /// Representante legal de la persona juridica
        /// </summary>
        public PersonaFisica RepresentanteLegal
        {
            get { return _repLegal; }
            set { _repLegal = value; }
        }

        public PersonaJuridica()
        {
            this.Cedula = "";
            this.Direccion = "";
            this.FechaNacConst = DateTime.Now;
            this.Nombre = "";
            this.RepresentanteLegal = new PersonaFisica();
            this.Tipo = TipoPJ.Ninguno;
        }

        public override void desplegarInfo()
        {
            Console.WriteLine("*** Informacion Persona Juridica ***");
            Console.WriteLine("* Cedula: " + this.Cedula);
            Console.WriteLine("* Nombre: " + this.Nombre);
            Console.WriteLine("* Direccion: " + this.Direccion);
            Console.WriteLine("* Fecha de Constitucion: " + this.FechaNacConst.ToShortDateString());
            Console.WriteLine("* Tipo de Persona Juridica: " + this.Tipo.ToString());
            Console.WriteLine("\t*** Representante Legal ***");
            this.RepresentanteLegal.desplegarInfo();
        }
    }

    public enum TipoPJ
    {
        SociedadAnonima,
        RespLimitada,
        Mercantil,
        Ninguno
    }
}
