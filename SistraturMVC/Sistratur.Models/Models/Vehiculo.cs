using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistratur.Models.Models
{
    public class Vehiculo
    {

        public int Id { get; set; }
        public String Placa { get; set; }
        public Decimal Kilometraje { get; set; }
        public int Anio  { get; set; }
        public Decimal MontoDia { get; set; }

        public int? EstadoVehiculoId { get; set; }
        public virtual EstadoVehiculo EstadoVehiculo { get; set; }

        public int? MarcaVehiculoId { get; set; }
        public virtual MarcaVehiculo MarcaVehiculo { get; set; }

        public int? ModeloId { get; set; }
        public virtual Modelo Modelo { get; set; }

        public int? ColorId { get; set; }
        public virtual Color Color { get; set; }

        public int? TipoId { get; set; }
        public virtual Tipo Tipo { get; set; }

        public virtual ICollection<DetalleAlquiler> DetallesAlquilers { get; set; }

        public virtual ICollection<DetalleArticuloToVehiculo> DetallesArticulosToVehiculo { get; set; }



    }
}
