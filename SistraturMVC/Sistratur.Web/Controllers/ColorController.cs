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
    public class ColorController : Controller
    {
        //
        // GET: /Color/

        private readonly IColorService service;

        public ColorController(IColorService service)
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
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Color color)
        {
            service.Insert(color);
            return RedirectToAction("Index");
        }

    }
}
