using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sistratur.Interfaces.Services;
using Sistratur.Models.Models;
using Sistratur.Services.Services;
using Sistratur.DataBase.DB;

using System.ComponentModel.DataAnnotations;


namespace Sistratur.Web.Controllers
{
    public class AlquilerController : Controller
    {
        //
        // GET: /Alquiler/

        private readonly SistraturEntities entities;

        private readonly IAlquilerService service;
        public AlquilerController(IAlquilerService service)
        {
            this.service = service;
            this.entities = new SistraturEntities();
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View("Index", service.All());
        }

        [HttpGet]
        public ActionResult Create()
        {
            var clientes = service.GetClientes();
            var vehiculos = service.GetVehiculos();
            var conductores = service.GetConductores();

            ViewData["ClienteId"] = new SelectList(clientes, "Id", "NombresRazonSocial");
            ViewData["VehiculoId"] = new SelectList(vehiculos, "Id", "Placa");
            ViewData["ConductorId"] = new SelectList(conductores, "Id", "Nombres");

            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Alquiler alquiler)
        {
            service.Insert(alquiler);
            return RedirectToAction("Index");
        }

    }
}
