using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadFinanciera
{
    public abstract class Transaccion
    {
        protected double monto { get; set; } 
        protected DateTime fecha { get; set; }

        public Transaccion(double monto)
        {
            this.monto = monto;
            this.fecha = DateTime.Now;
        }
    }
}
