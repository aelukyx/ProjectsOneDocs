using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;

using Sistratur.Models.Models;


namespace Sistratur.DataBase.Mapping
{
    public class CiudadConfiguration : EntityTypeConfiguration<Ciudad>
    {
        public CiudadConfiguration()
        {

            ToTable("Ciudad", "dbo");
            HasKey(o => o.Id);
            Property(o => o.Descripcion)
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
