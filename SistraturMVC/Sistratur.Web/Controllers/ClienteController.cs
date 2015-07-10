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
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/

        private readonly SistraturEntities entities;

        private readonly IClienteService service;
        public ClienteController(IClienteService service)
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
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                service.Insert(cliente);
                return RedirectToAction("Index");
            }
            return View("Create", cliente);
        }

    }
}
