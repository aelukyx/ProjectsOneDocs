using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;

using Sistratur.Models.Models;

namespace Sistratur.DataBase.Mapping
{
    public class VehiculoConfiguration: EntityTypeConfiguration<Vehiculo>
    {
        public VehiculoConfiguration()
        {

            ToTable("Vehiculo", "dbo");
            HasKey(o => o.Id);
            Property(o => o.Placa)
                .HasMaxLength(7)
                .IsRequired();
            Property(o => o.Kilometraje)
                .HasPrecision(9, 2);
            Property(o => o.Anio);

            HasRequired(o => o.EstadoVehiculo)
                .WithMany(o => o.Vehiculos)
                .HasForeignKey(o => o.EstadoVehiculoId);

            HasRequired(o => o.MarcaVehiculo)
                .WithMany(o => o.Vehiculos)
                .HasForeignKey(o => o.MarcaVehiculoId);

            HasRequired(o => o.Modelo)
                .WithMany(o => o.Vehiculos)
                .HasForeignKey(o => o.ModeloId);

            HasRequired(o => o.Tipo)
                .WithMany(o => o.Vehiculos)
                .HasForeignKey(o => o.TipoId);

            HasRequired(o => o.Color)
                .WithMany(o => o.Vehiculos)
                .HasForeignKey(o => o.ColorId);


        }
    }
}
