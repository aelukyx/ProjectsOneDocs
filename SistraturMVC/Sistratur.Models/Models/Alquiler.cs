using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistratur.Models.Models
{
    public class Alquiler
    {
        public int Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        public String Observaciones { get; set; }

        public int? ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public int? PerfilUsuarioId { get; set; }
        public virtual PerfilUsuario PerfilUsuario { get; set; }

        public virtual ICollection<DetalleAlquiler> DetallesAlquilers { get; set; }

    }
}
