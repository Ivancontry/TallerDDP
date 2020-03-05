using System;
using System.Collections.Generic;
using System.Text;

namespace TallerDDP
{
    public class Transancion
    {
        protected double monto { get; set; } 
        protected DateTime fecha { get; set; }

        public Transancion(double monto)
        {
            this.monto = monto;
            this.fecha = DateTime.Now;
        }
    }
}
