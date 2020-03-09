using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadFinanciera
{
    public class ServiciosFinancieros
    {
        public readonly IServiciosFinancieros servicios;
        public ServiciosFinancieros(IServiciosFinancieros servicios) {
            this.servicios = servicios;
        }

        public string Consignacion(Consignacion consignacion) {
            return this.servicios.Consignar(consignacion);
        }
    }
}
