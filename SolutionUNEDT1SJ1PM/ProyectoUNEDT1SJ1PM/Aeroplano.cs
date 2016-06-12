using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUNEDT1SJ1PM
{
    public class Aeroplano : MedioTransporte
    {
        private TipoAeronave _tipoAeronave;

        public TipoAeronave TipoAeronave
        {
            get { return _tipoAeronave; }
            set { _tipoAeronave = value; }
        }

        private int _capacidad;

        public int Capacidad
        {
            get { return _capacidad; }
            set { _capacidad = value; }
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("*** Informacion de la Embarcacion ***");
            Console.WriteLine("\t* Identificacion:  " + this.Placa);
            Console.WriteLine("\t* Ano de fabricacion " + this.AnoFabricacion);
            Console.WriteLine("\t* Velocidad Maxima " + this.VelocidadMaxima);
            Console.WriteLine("\t* Propietario ");
            this.Propietario.desplegarInfo();
            this.MostrarInfoPropia();
        }

        public void MostrarInfoPropia()
        {
            Console.WriteLine("\t* Capacidad: " + this.Capacidad);
            Console.WriteLine("\t* Tipo de aeronave " + this.TipoAeronave.ToString());
        }
    }

    public enum TipoAeronave
    {
        Ninguno,
        Militar,
        Carga,
        Pasajeros
    }
}
