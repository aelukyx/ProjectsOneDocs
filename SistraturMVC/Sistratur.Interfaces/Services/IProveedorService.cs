﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistratur.Models.Models;

namespace Sistratur.Interfaces.Services
{
    public interface IProveedorService
    {
        IList<Proveedor> All();
        Proveedor GetById(int id);
        Ciudad GetCiudadById(int id);
        List<Ciudad> GetCiudades();
        void Insert(Proveedor proveedor);
        void Update(Proveedor proveedor);
    }
}