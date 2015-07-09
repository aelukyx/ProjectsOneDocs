using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Sistratur.Models.Models;

namespace Sistratur.DataBase.Mapping
{
    public class DetalleAlquilerConfiguration : EntityTypeConfiguration<DetalleAlquiler>
    {
        public DetalleAlquilerConfiguration()
        {

            ToTable("DetalleAlquiler", "dbo");

            HasKey(i => new { i.AlquilerId, i.VehiculoId });
            Property(i => i.AlquilerId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(i => i.VehiculoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(o => o.FechaInicio)
                .IsRequired();
            Property(o => o.FechaFin)
                .IsRequired();
            Property(o => o.LugarReferencia)
                .HasMaxLength(100)
                .IsOptional();
            Property(o => o.MontoTotal)
                .HasPrecision(5, 2);

            HasRequired(o => o.Conductor)
                .WithMany(o => o.DetallesAlquilers)
                .HasForeignKey(o => o.ConductorId);

            HasRequired(o => o.Alquiler)
                .WithMany(o => o.DetallesAlquilers)
                .HasForeignKey(o => o.AlquilerId);

            HasRequired(o => o.Vehiculo)
                .WithMany(o => o.DetallesAlquilers)
                .HasForeignKey(o => o.VehiculoId);

        }
    }
}
