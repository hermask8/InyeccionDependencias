﻿using InyeccionDependencias.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InyeccionDependencias.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransient _transient;
        private readonly IScoped _scoped;
        private readonly ISingleton _singleton;

        private readonly ITransient _transient2;
        private readonly IScoped _scoped2;
        private readonly ISingleton _singleton2;

        private readonly ITransient _transient3;
        private readonly IScoped _scoped3;
        private readonly ISingleton _singleton3;
        public HomeController(ITransient transient, IScoped scoped, ISingleton singleton, 
            ITransient transient2, 
            IScoped scoped2, 
            ISingleton singleton2,
            ITransient transient3,
            IScoped scoped3,
            ISingleton singleton3)
        {
            _transient = transient;
            _scoped = scoped;
            _singleton = singleton;

            _transient2 = transient2;
            _scoped2 = scoped2;
            _singleton2 = singleton2;

            _transient3 = transient3;
            _scoped3 = scoped3;
            _singleton3 = singleton3;


        }

        public IActionResult Index()
        {
            ViewBag.transient = _transient;
            ViewBag.scoped = _scoped;
            ViewBag.singleton = _singleton;

            ViewBag.transient2 = _transient2;
            ViewBag.scoped2 = _scoped2;
            ViewBag.singleton2 = _singleton2;

            ViewBag.transient3 = _transient3;
            ViewBag.scoped3 = _scoped3;
            ViewBag.singleton3 = _singleton3;
            return View();
        }

    }
}