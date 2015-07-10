using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistratur.Models.Models;

namespace Sistratur.Interfaces.Services
{
    public interface IVehiculoService
    {

        IList<Vehiculo> All();
        Vehiculo GetById(int id);
        List<EstadoVehiculo> GetEstadosVehiculos();
        List<Tipo> GetTipos();
        List<Modelo> GetModelos();
        List<Color> GetColores();
        List<MarcaVehiculo> GetMarcasVehiculo();
        void Insert(Vehiculo vehiculo);
        void Update(Vehiculo vehiculo);
    }
}
