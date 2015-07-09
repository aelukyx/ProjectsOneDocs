using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

using Sistratur.Models.Models;


namespace Sistratur.DataBase.Mapping
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {

        public ClienteConfiguration()
        {
            ToTable("Cliente", "dbo");
            HasKey(o => o.Id);
            Property(o => o.NroDocumento)
                .HasMaxLength(11)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_NroDocumento") { IsUnique = true }));
            Property(o => o.TipoDoc)
                .IsRequired();
            Property(o => o.NombresRazonSocial)
                .HasMaxLength(100)
                .IsRequired();
            Property(o => o.AppPaterno)
                .HasMaxLength(100)
                .IsOptional();
            Property(o => o.AppMaterno)
                .HasMaxLength(100)
                .IsOptional();
            Property(o => o.Celular)
                .IsRequired();
            Property(o => o.Telefono)
                .IsOptional();
            Property(o => o.Direccion)
                .HasMaxLength(200)
                .IsRequired();
            Property(o => o.Email)
                .HasMaxLength(50)
                .IsOptional();
            Property(o => o.FechaRegistro)
                .IsRequired();
            Property(o => o.Comentarios)
                .HasMaxLength(200)
                .IsOptional();

        }
    }
}
