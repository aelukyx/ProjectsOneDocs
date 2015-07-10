using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistratur.DataBase.DB;
using Sistratur.Interfaces.Services;
using Sistratur.Models.Models;

namespace Sistratur.Services.Services
{
    public class ProveedorService:IProveedorService
    {

        private readonly SistraturEntities entities;

        public ProveedorService(SistraturEntities entities)
        {
            this.entities = entities;
        }

        public IList<Proveedor> All()
        {
            return entities.Proveedores.ToList();
        }

        public Proveedor GetById(int id)
        {
            return entities.Proveedores.First(x => x.Id == id);
        }

        public void Insert(Proveedor proveedor)
        {
            entities.Proveedores.Add(proveedor);
            entities.SaveChanges();
        }

        public void Update(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }


        Ciudad IProveedorService.GetCiudadById(int id)
        {
            return entities.Ciudades.First(x => x.Id == id);
        }


        public List<Ciudad> GetCiudades()
        {
            return entities.Ciudades.ToList();
        }
    }
}
