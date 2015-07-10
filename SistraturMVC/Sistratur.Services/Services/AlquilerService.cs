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
    public class AlquilerService:IAlquilerService
    {

        private readonly SistraturEntities entities;

        public AlquilerService(SistraturEntities entities)
        {
            this.entities = entities;
        }

        public IList<Alquiler> All()
        {
            return entities.Alquileres.ToList();
        }

        public void Insert(Alquiler alquiler)
        {
            entities.Alquileres.Add(alquiler);
            entities.SaveChanges();
        }

        public List<Cliente> GetClientes()
        {
            return entities.Clientes.ToList();
        }

        public List<Vehiculo> GetVehiculos()
        {
            return entities.Vehiculos.ToList();
        }

        public List<Conductor> GetConductores()
        {
            return entities.Conductores.ToList();
        }

        public void Update(Alquiler alquiler)
        {
            throw new NotImplementedException();
        }


        public Alquiler GetAlquilerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
