using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistratur.Models.Models
{
    public class DetalleArticuloToVehiculo
    {

        public Int32 ArticuloId { get; set; }
        public Articulo Articulo { get; set; }

        public Int32 VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }

        public int Cantidad { get; set; }

    }
}
