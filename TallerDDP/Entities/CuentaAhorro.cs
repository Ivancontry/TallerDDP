using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadFinanciera
{
    public class CuentaAhorro : Cuenta, IServiciosFinancieros
    {
        private bool _primeraConsignacion;

        public CuentaAhorro(string nombreCuenta, string numeroCuenta, double saldo, string ciudad):base(nombreCuenta, numeroCuenta, saldo, ciudad) 
        {
            this.nombreCuenta = nombreCuenta;
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
            this.ciudad = ciudad;

        }

        public void setPrimeraConsignacion(bool primeraConsignacion) { this._primeraConsignacion = primeraConsignacion; }

        public string Consignar(Consignacion consignacion)
        {
           
            if (consignacion.GetMonto() > 0)
            {
                if (_primeraConsignacion)
                {
                    if (consignacion.GetMonto() >= consignacion.GetVALORCONSIGNACIONINICIAL())
                    {
                        ValidadCiudadDestino(consignacion);
                        _primeraConsignacion = true;
                    }
                    else
                    {                        
                        return "El valor mínimo de la primera consignación debe ser de $50.000 mil pesos. Su nuevo saldo es $0 pesos";
                    }
                }
                else
                {
                    ValidadCiudadDestino(consignacion);                   
                }

            }
            else
            {
                return  "El valor a consignar es incorrecto";
            }
            
            this.listaTransancion.Add(consignacion);
            this.saldo += consignacion.GetMonto();
            return "Su nuevo saldo es " + this.saldo + " m/c";

        }

        private void ValidadCiudadDestino(Consignacion consignacion)
        {
            if (!consignacion.GetCiudad().Equals(this.ciudad))
            {
                consignacion.SetMonto(consignacion.GetMonto() - consignacion.GetDESCUENTOCIUDADDESTINO());
                this.listaTransancion.Add(consignacion);                           

            }
        }

        public void Retirar(Retiro retiro)
        {

        }

        public void TrasladarDinero(Trasnferencia trasnferencia)
        {

        }
    }
}
