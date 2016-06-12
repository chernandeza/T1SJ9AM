using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUNEDT1SJ1PM
{
    public class Embarcacion : MedioTransporte
    {
        private int _capacidadCarga;

        public int CapacidadCarga
        {
            get { return _capacidadCarga; }
            set { _capacidadCarga = value; }
        }

        private String _bandera;

        public String Bandera
        {
            get { return _bandera; }
            set { _bandera = value; }
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

        private void MostrarInfoPropia()
        {
            Console.WriteLine("\t* Bandera: " + this.Bandera);
            Console.WriteLine("\t* Capacidad de carga " + this.CapacidadCarga.ToString());
        }
    }
}
