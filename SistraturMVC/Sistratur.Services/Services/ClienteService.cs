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
    public class ClienteService : IClienteService
    {

        private readonly SistraturEntities entities;


        public ClienteService(SistraturEntities entities)
        {
            this.entities = entities;
        }


        public IList<Cliente> All()
        {
            return entities.Clientes.ToList();
        }

        public IEnumerable<Cliente> GetFromClienteByRucDni(string DniRuc)
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(int id)
        {
            return entities.Clientes.First(x => x.Id == id);
        }

        public void Insert(Cliente cliente)
        {
            entities.Clientes.Add(cliente);
            entities.SaveChanges();
        }

        public void Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}