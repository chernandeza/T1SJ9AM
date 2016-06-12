using System;

namespace LibreriaPrincipal
{
    public abstract class Persona
    {
        private String _id;
        /// <summary>
        /// Representa la identificacion de una persona
        /// </summary>
        public String Identificacion
        {
            get { return _id; }
            set { _id = value; }
        }

        private DateTime _fecha;
        /// <summary>
        /// Fecha de nacimiento o constitucion
        /// </summary>
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private String _direccion;

        public String Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public abstract void DesplegarDatos();
    }
}
