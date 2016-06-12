using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUNEDT1SJ1PM
{
    public abstract class MedioTransporte
    {
        private String _identificacion;

        public String Placa
        {
            get { return _identificacion; }
            set { _identificacion = value; }
        }

        private Persona _propietario;

        public Persona Propietario
        {
            get { return _propietario; }
            set { _propietario = value; }
        }

        private int _velocidadMax;

        public int VelocidadMaxima
        {
            get { return _velocidadMax; }
            set { _velocidadMax = value; }
        }

        private int _anoFab;

        public int AnoFabricacion
        {
            get { return _anoFab; }
            set { _anoFab = value; }
        }

        private TipoTransporte _tipo;

        public TipoTransporte Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public abstract void MostrarInformacion();
    }

    public enum TipoTransporte
    {
        Ninguno,
        Terrestre,
        Maritimo,
        Aereo,
        Mixto
    }
}

