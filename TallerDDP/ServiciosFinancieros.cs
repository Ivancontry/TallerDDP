using System;
using System.Collections.Generic;
using System.Text;

namespace TallerDDP
{
    public class ServiciosFinancieros
    {
        public readonly IServiciosFinancieros servicios;
        public ServiciosFinancieros(IServiciosFinancieros servicios) {
            this.servicios = servicios;
        }

        public string Consignacion(Consignacion consignacion) {
            return this.servicios.Consignacion(consignacion);
        }
    }
}
