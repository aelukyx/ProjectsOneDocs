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

            Property(o => o.FechaServicio)
                .HasMaxLength(15)
                .IsRequired();

            Property(o => o.HoraServicio)
                .HasMaxLength(15)
                .IsRequired();

            Property(o => o.LugarReferencia)
                .HasMaxLength(200);

            Property(o => o.Observaciones)
                .IsOptional()
                .HasMaxLength(200);


            Property(o => o.FechaInicio)
                .HasMaxLength(15)
                .IsRequired();

            Property(o => o.FechaFin)
                .HasMaxLength(15)
                .IsRequired();

            Property(o => o.NroDias)
                .IsRequired();

            Property(o => o.Montodia)
                .IsRequired()
                .HasPrecision(5, 2);

            Property(o => o.MontoTotal)
                .IsRequired()
                .HasPrecision(5, 2);

            HasRequired(o => o.Conductor)
                .WithMany(o => o.Alquiler)
                .HasForeignKey(o => o.ConductorId);

            HasRequired(o => o.Vehiculo)
                .WithMany(o => o.Alquiler)
                .HasForeignKey(o => o.VehiculoId);

            HasOptional(o => o.PerfilUsuario)
                .WithMany(o => o.Alquiler)
                .HasForeignKey(o => o.PerfilUsuarioId);

            HasRequired(o => o.Cliente)
                .WithMany(o => o.Alquiler)
                .HasForeignKey(o => o.ClienteId);
        }
    }
}
