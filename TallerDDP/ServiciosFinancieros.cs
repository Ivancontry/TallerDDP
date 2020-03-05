using System;
using System.Collections.Generic;
using System.Text;

namespace TallerDDP
{
    public class ServiciosFinancieros
    {
        public readonly IServicios servicios;
        public ServiciosFinancieros(IServicios servicios) {
            this.servicios = servicios;
        }

        public string Consignacion(Consignacion consignacion) {
            return this.servicios.Consignacion(consignacion);
        }
    }
}
