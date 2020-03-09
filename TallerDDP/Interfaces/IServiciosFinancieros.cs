using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadFinanciera
{
    public  interface IServiciosFinancieros
    {
        public string Consignar(Consignacion consignacion);
        public void Retirar(Retiro retiro);
        public void TrasladarDinero(Trasnferencia trasnferencia);
    }
}
