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
    public class ProveedorController : Controller
    {
        //
        // GET: /Proveedor/

        private readonly IProveedorService service;

        public ProveedorController(IProveedorService service)
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
            var ciudades = service.GetCiudades();

            ViewData["CiudadId"] = new SelectList(ciudades, "Id", "Descripcion");

            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Proveedor proveedor)
        {
            if (ModelState.IsValid)
            {
                service.Insert(proveedor);
                return RedirectToAction("Index");
            }
            return View("Create", proveedor);
        }

    }
}
