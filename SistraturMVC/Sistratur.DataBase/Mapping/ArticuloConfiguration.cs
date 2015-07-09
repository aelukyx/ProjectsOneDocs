using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;

using Sistratur.Models.Models;


namespace Sistratur.DataBase.Mapping
{
    public class ArticuloConfiguration : EntityTypeConfiguration<Articulo>
    {
        public ArticuloConfiguration()
        {

            ToTable("Articulo", "dbo");
            HasKey(o => o.Id);
            Property(o => o.Descripcion)
                .HasMaxLength(100)
                .IsRequired();
            Property(o => o.Codigo)
                .HasMaxLength(20)
                .IsOptional();
            Property(o => o.Stock)
                .IsRequired();
            Property(o => o.FechaRegistro);
            Property(o => o.FechaModificacion);
            Property(o => o.Descontinuado);

            HasRequired(o => o.Categoria)
                .WithMany(o => o.Articulo)
                .HasForeignKey(o => o.CategoriaId);

            HasRequired(o => o.MarcaArticulo)
                .WithMany(o => o.Articulo)
                .HasForeignKey(o => o.MarcaArticuloId);


        }
    }
}
