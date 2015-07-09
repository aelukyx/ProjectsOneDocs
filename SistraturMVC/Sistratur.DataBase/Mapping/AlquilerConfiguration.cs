using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.Entity.ModelConfiguration;

using Sistratur.Models.Models;

namespace Sistratur.DataBase.Mapping
{
    public class AlquilerConfiguration: EntityTypeConfiguration<Alquiler>
    {
        public AlquilerConfiguration()
        {

            ToTable("Alquiler", "dbo");
            HasKey(o => o.Id);
            Property(o => o.FechaRegistro)
                .IsRequired();
            Property(o => o.Observaciones)
                .HasMaxLength(200);

            HasRequired(o => o.PerfilUsuario)
                .WithMany(o => o.Alquiler)
                .HasForeignKey(o => o.PerfilUsuarioId);

            HasRequired(o => o.Cliente)
                .WithMany(o => o.Alquileres)
                .HasForeignKey(o => o.ClienteId);
        }
    }
}
