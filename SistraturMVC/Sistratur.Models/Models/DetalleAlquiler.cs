using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistratur.Models.Models
{
    public class DetalleAlquiler
    {
        public Int32 AlquilerId { get; set; }
        public Alquiler Alquiler { get; set; }

        public Int32 VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public String LugarReferencia { get; set; }
        public Decimal MontoTotal { get; set; }

        public int? ConductorId { get; set; }
        public virtual Conductor Conductor { get; set; }

    }
}
