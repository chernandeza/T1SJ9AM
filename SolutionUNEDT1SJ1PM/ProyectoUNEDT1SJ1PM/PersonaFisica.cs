using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUNEDT1SJ1PM
{
    public class PersonaFisica : Persona
    {
        private int _sexo;
        /// <summary>
        /// 0 = Masc
        /// 1 = Fem
        /// 2 = No indica
        /// </summary>
        public int Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        private EstadosCiviles _estCivil;

        public EstadosCiviles EstadoCivil
        {
            get { return _estCivil; }
            set { _estCivil = value; }
        }

        public PersonaFisica()
        {
            this.Cedula = "";
            this.Direccion = "";
            this.EstadoCivil = EstadosCiviles.Ninguno;
            this.FechaNacConst = DateTime.Now;
            this.Nombre = "";
            this.Sexo = 0;
        }

        public override void desplegarInfo()
        {
            Console.WriteLine("\t--- Informacion Persona Fisica ---");
            Console.WriteLine("\t- Cedula: " + this.Cedula);
            Console.WriteLine("\t- Nombre: " + this.Nombre);
            Console.WriteLine("\t- Direccion: " + this.Direccion);
            Console.WriteLine("\t- Estado Civil: " + this.EstadoCivil.ToString());
            Console.WriteLine("\t- Sexo: " + (this.Sexo == 1 ? "Masculino" : "Femenino"));
            Console.WriteLine("\t- Fecha de Nacimiento: " + this.FechaNacConst.ToShortDateString());
        }
    }
    /// <summary>
    /// Contiene los estados civiles posibles para una persona fisica
    /// </summary>
    public enum EstadosCiviles
    {
        Soltero,
        Casado,
        Viudo,
        Divorciado,
        UnionLibre,
        Ninguno
    }
}
