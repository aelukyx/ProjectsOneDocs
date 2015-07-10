using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sistratur.Interfaces.Services;
using Sistratur.Models.Models;
using Sistratur.Services.Services;
using Sistratur.DataBase.DB;

namespace Sistratur.Web.Controllers
{
    public class VehiculoController : Controller
    {
        //
        // GET: /Vehiculo/

        private readonly IVehiculoService service;

        public VehiculoController(IVehiculoService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View("Index", service.All());
        }

        [HttpGet]
        public ActionResult Create()
        {
            var estados = service.GetEstadosVehiculos();
            var tipos = service.GetTipos();
            var modelos = service.GetModelos();
            var colores = service.GetColores();
            var marcas = service.GetMarcasVehiculo();


            ViewData["EstadoVehiculoId"] = new SelectList(estados, "Id", "Descripcion");
            ViewData["MarcaVehiculoId"] = new SelectList(marcas, "Id", "Descripcion");
            ViewData["ModeloId"] = new SelectList(modelos, "Id", "Descripcion");
            ViewData["ColorId"] = new SelectList(colores, "Id", "Descripcion");
            ViewData["TipoId"] = new SelectList(tipos, "Id", "Descripcion");

            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Vehiculo vehiculo)
        {
            service.Insert(vehiculo);
            return RedirectToAction("Index");
        }


    }
}
