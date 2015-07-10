using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistratur.Models.Models;

namespace Sistratur.Interfaces.Services
{
    public interface IAlquilerService
    {

        IList<Alquiler> All();
        Alquiler GetAlquilerById(int id);

        List<Cliente> GetClientes();
        List<Vehiculo> GetVehiculos();
        List<Conductor> GetConductores();

        void Insert(Alquiler alquiler);
        void Update(Alquiler alquiler);

    }
}
