using System;
using System.Collections.Generic;
using System.Text;

namespace TallerDDP
{
    public class Transanccion
    {
        protected double monto { get; set; } 
        protected DateTime fecha { get; set; }

        public Transanccion(double monto)
        {
            this.monto = monto;
            this.fecha = DateTime.Now;
        }
    }
}
