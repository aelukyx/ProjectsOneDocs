using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.Entity.ModelConfiguration;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Sistratur.Models.Models;


namespace Sistratur.DataBase.Mapping
{
    public class DetalleArticuloToVehiculoConfiguration: EntityTypeConfiguration<DetalleArticuloToVehiculo>
    {
        public DetalleArticuloToVehiculoConfiguration()
        {

            ToTable("DetalleArticuloToVehiculo", "dbo");

            HasKey(i => new { i.VehiculoId, i.ArticuloId });
            Property(i => i.VehiculoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(i => i.ArticuloId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            HasRequired(o => o.Vehiculo)
                .WithMany(o => o.DetallesArticulosToVehiculo)
                .HasForeignKey(o => o.VehiculoId);

            HasRequired(o => o.Articulo)
                .WithMany(o => o.DetallesArticulosToVehiculo)
                .HasForeignKey(o => o.ArticuloId);

        }
    }
}