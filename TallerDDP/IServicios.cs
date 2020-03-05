using System;
using System.Collections.Generic;
using System.Text;

namespace TallerDDP
{
    public  interface IServicios
    {
        public string Consignacion(Consignacion consignacion);
        public void Retiros(Retiro retiro);
        public void TrasladoDinero(Trasnferencia trasnferencia);
    }
}
