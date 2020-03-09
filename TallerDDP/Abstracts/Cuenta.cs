using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadFinanciera
{
    public abstract class Cuenta
    {
        
        protected string nombreCuenta { get; set; }
        protected string numeroCuenta { get; set; }
        protected double saldo { get; set; }
        protected string ciudad { get; set; }
        protected List<Transaccion> listaTransancion;

        public Cuenta(string nombreCuenta, string numeroCuenta, double saldo, string ciudad)
        {
            this.nombreCuenta = nombreCuenta;
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
            this.ciudad = ciudad;
            this.listaTransancion = new List<Transaccion>();
        }

        public int NumeroTransaciones(Transaccion transanccion) {
            return this.listaTransancion.FindAll(x => x.GetType().IsAssignableFrom(transanccion.GetType())).Count;           

        }
        


    }
}
