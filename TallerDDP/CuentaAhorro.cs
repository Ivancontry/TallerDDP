using System;
using System.Collections.Generic;
using System.Text;

namespace TallerDDP
{
    public class CuentaAhorro : Cuenta, IServiciosFinancieros
    {
        private bool primeraConsignacion;

        public CuentaAhorro(string nombreCuenta, string numeroCuenta, double saldo, string ciudad):base(nombreCuenta, numeroCuenta, saldo, ciudad) 
        {
            this.nombreCuenta = nombreCuenta;
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
            this.ciudad = ciudad;

        }

        public void setPrimeraConsignacion(bool primeraConsignacion) { this.primeraConsignacion = primeraConsignacion; }

        public string Consignacion(Consignacion consignacion)
        {
           
            if (consignacion.getMonto() > 0)
            {
                if (primeraConsignacion)
                {
                    if (consignacion.getMonto() >= consignacion.getVALORCONSIGNACIONINICIAL())
                    {
                        ValidadCiudadDestino(consignacion);
                        primeraConsignacion = true;
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
            this.saldo += consignacion.getMonto();
            return "Su nuevo saldo es " + this.saldo + " m/c";

        }

        private void ValidadCiudadDestino(Consignacion consignacion)
        {
            if (!consignacion.getCiudad().Equals(this.ciudad))
            {
                consignacion.setMonto(consignacion.getMonto() - consignacion.getDESCUENTOCIUDADDESTINO());
                this.listaTransancion.Add(consignacion);                           

            }
        }

        public void Retiros(Retiro retiro)
        {

        }

        public void TrasladoDinero(Trasnferencia trasnferencia)
        {

        }
    }
}
