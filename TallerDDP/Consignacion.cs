using System;
using System.Collections.Generic;
using System.Text;

namespace TallerDDP
{
    public class Consignacion : Transancion
    {
        private string ciudadDestino { get; set; }
        private const double DESCUENTOCIUDADDESTINO = 10000;
        private const double VALORCONSIGNACIONINICIAL = 50000;

        public Consignacion(string ciudad, double monto):base(monto)
        {
            this.ciudadDestino = ciudad;
            this.monto = monto;        

        }
        
        public double getMonto(){ return this.monto; }

        public void setMonto(double monto) { this.monto = monto; }

        public void setCiudad(string ciudad) { this.ciudadDestino = ciudad; }
        public string getCiudad() { return this.ciudadDestino; }

        public double getDESCUENTOCIUDADDESTINO() { return DESCUENTOCIUDADDESTINO; }

        public double getVALORCONSIGNACIONINICIAL() { return VALORCONSIGNACIONINICIAL;  }

    }
}
