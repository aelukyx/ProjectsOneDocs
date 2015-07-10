using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using Sistratur.Models.Models;
using Sistratur.DataBase.Mapping;

namespace Sistratur.DataBase.DB
{
    public class SistraturEntities : DbContext
    {
       public virtual IDbSet<Color> Colores { get; set; }
       public virtual IDbSet<Tipo> Tipos { get; set; }
       public virtual IDbSet<Vehiculo> Vehiculos { get; set; }
       public virtual IDbSet<Modelo> Modelos { get; set; }
       public virtual IDbSet<MarcaVehiculo> MarcaVehiculos { get; set; }
       public virtual IDbSet<EstadoVehiculo> EstadosVehiculos { get; set; }
       public virtual IDbSet<Cliente> Clientes { get; set; }
       public virtual IDbSet<UsuarioRoles> UsuariosRoles { get; set; }
       public virtual IDbSet<Rol> Roles { get; set; }
       public virtual IDbSet<PerfilUsuario> PerfilesUsuarios { get; set; }
       public virtual IDbSet<Alquiler> Alquileres { get; set; }
       public virtual IDbSet<Conductor> Conductores { get; set; }
       public virtual IDbSet<Articulo> Articulos { get; set; }
       public virtual IDbSet<Categoria> Categorias { get; set; }
       public virtual IDbSet<MarcaArticulo> MarcasArticulos { get; set; }
       public virtual IDbSet<DetalleArticulo> DetallesArticulos { get; set; }
       public virtual IDbSet<Ciudad> Ciudades { get; set; }
       public virtual IDbSet<Proveedor> Proveedores { get; set; }
       public virtual IDbSet<DetalleArticuloToVehiculo> DetallesArticulosToVehiculos { get; set; }


       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           //Database.SetInitializer<DemoEntities>(null);
           //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

           base.OnModelCreating(modelBuilder);
           modelBuilder.Configurations.Add<Color>(new ColorConfiguration());
           modelBuilder.Configurations.Add<Tipo>(new TipoConfiguration());
           modelBuilder.Configurations.Add<Vehiculo>(new VehiculoConfiguration());
           modelBuilder.Configurations.Add<Modelo>(new ModeloConfiguration());
           modelBuilder.Configurations.Add<MarcaVehiculo>(new MarcaVehiculoConfiguration());
           modelBuilder.Configurations.Add<EstadoVehiculo>(new EstadoVehiculoConfiguration());
           modelBuilder.Configurations.Add<Cliente>(new ClienteConfiguration());
           modelBuilder.Configurations.Add<UsuarioRoles>(new UsuarioRolesConfiguration());
           modelBuilder.Configurations.Add<Rol>(new RolConfiguration());
           modelBuilder.Configurations.Add<PerfilUsuario>(new PerfilUsuarioConfiguration());
           modelBuilder.Configurations.Add<Alquiler>(new AlquilerConfiguration());
           modelBuilder.Configurations.Add<Conductor>(new ConductorConfiguration());
           modelBuilder.Configurations.Add<Articulo>(new ArticuloConfiguration());
           modelBuilder.Configurations.Add<Categoria>(new CategoriaConfiguration());
           modelBuilder.Configurations.Add<MarcaArticulo>(new MarcaArticuloConfiguration());
           modelBuilder.Configurations.Add<DetalleArticulo>(new DetalleArticuloConfiguration());
           modelBuilder.Configurations.Add<Ciudad>(new CiudadConfiguration());
           modelBuilder.Configurations.Add<Proveedor>(new ProveedorConfiguration());
           modelBuilder.Configurations.Add<DetalleArticuloToVehiculo>(new DetalleArticuloToVehiculoConfiguration());
       }
    }
}