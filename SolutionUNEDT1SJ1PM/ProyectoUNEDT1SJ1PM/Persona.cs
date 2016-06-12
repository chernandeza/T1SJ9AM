using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUNEDT1SJ1PM
{
    /// <summary>
    /// Clase base Persona
    /// </summary>
    public abstract class Persona
    {
        private String _cedula;
        /// <summary>
        /// Cedula de la persona
        /// </summary>
        public String Cedula
        {
            get { return _cedula; }
            set { _cedula = value; }
        }

        private String _nombre;
        /// <summary>
        /// Nombre o razon social de la persona
        /// </summary>
        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private String _direccion;
        /// <summary>
        /// Direccion de la persona
        /// </summary>
        public String Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private DateTime _fechaNacConst;
        /// <summary>
        /// Fecha de nacimiento o constitucion para una persona
        /// </summary>
        public DateTime FechaNacConst
        {
            get { return _fechaNacConst; }
            set { _fechaNacConst = value; }
        }

        public abstract void desplegarInfo();
    }
}
