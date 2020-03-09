using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadFinanciera
{
    public class Consignacion : Transaccion
    {
        private string _ciudadDestino { get; set; }
        private const double _DESCUENTOCIUDADDESTINO = 10000;
        private const double _VALORCONSIGNACIONINICIAL = 50000;

        public Consignacion(string ciudad, double monto):base(monto)
        {
            this._ciudadDestino = ciudad;
            this.monto = monto;        

        }
        
        public double GetMonto(){ return this.monto; }

        public void SetMonto(double monto) { this.monto = monto; }

        public void SetCiudad(string ciudad) { this._ciudadDestino = ciudad; }
        public string GetCiudad() { return this._ciudadDestino; }

        public double GetDESCUENTOCIUDADDESTINO() { return _DESCUENTOCIUDADDESTINO; }

        public double GetVALORCONSIGNACIONINICIAL() { return _VALORCONSIGNACIONINICIAL;  }

    }
}
