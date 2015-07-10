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
    public class VehiculoService:IVehiculoService
    {
        private readonly SistraturEntities entities;

        public VehiculoService(SistraturEntities entities)
        {
            this.entities = entities;
        }


        public IList<Vehiculo> All()
        {
            return entities.Vehiculos.ToList();
        }

        public Vehiculo GetById(int id)
        {
            return entities.Vehiculos.First(x => x.Id == id);
        }

        public List<EstadoVehiculo> GetEstadosVehiculos()
        {
            return entities.EstadosVehiculos.ToList();
        }

        public List<Tipo> GetTipos()
        {
            return entities.Tipos.ToList();
        }

        public List<Modelo> GetModelos()
        {
            return entities.Modelos.ToList();
        }

        public List<Color> GetColores()
        {
            return entities.Colores.ToList();
        }

        public List<MarcaVehiculo> GetMarcasVehiculo()
        {
            return entities.MarcaVehiculos.ToList();
        }

        public void Insert(Vehiculo vehiculo)
        {
            entities.Vehiculos.Add(vehiculo);
            entities.SaveChanges();
        }

        public void Update(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }



    }
}
