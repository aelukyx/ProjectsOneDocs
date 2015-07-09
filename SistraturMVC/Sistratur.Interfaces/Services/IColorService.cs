using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistratur.Models.Models;

namespace Sistratur.Interfaces.Services
{
    public interface IColorService
    {

        IList<Color> All();
        Color GetColorById(int id);
        void Insert(Color color);
        void Update(Color color);

    }
}
