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
    public class ColorService:IColorService
    {

        private readonly SistraturEntities entities;

        public ColorService(SistraturEntities entities)
        {
            this.entities = entities;
        }

        public IList<Color> All()
        {
            return entities.Colores.ToList();
        }

        public Color GetColorById(int id)
        {
            return entities.Colores.First(x => x.Id == id);
        }

        public void Insert(Color color)
        {
            entities.Colores.Add(color);
            entities.SaveChanges();
        }

        public void Update(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
