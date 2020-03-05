using System;
using System.Collections.Generic;
using System.Text;

namespace TallerDDP
{
    public class Cuenta
    {
        
        protected string nombreCuenta { get; set; }
        protected string numeroCuenta { get; set; }
        protected double saldo { get; set; }
        protected string ciudad { get; set; }
        protected List<Transancion> listaTransancion;

        public Cuenta(string nombreCuenta, string numeroCuenta, double saldo, string ciudad)
        {
            this.nombreCuenta = nombreCuenta;
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
            this.ciudad = ciudad;
            this.listaTransancion = new List<Transancion>();
        }

        public int numeroTransaciones(Transancion transancion) {
            return this.listaTransancion.FindAll(x => x.GetType().IsAssignableFrom(transancion.GetType())).Count;           

        }
        


    }
}
