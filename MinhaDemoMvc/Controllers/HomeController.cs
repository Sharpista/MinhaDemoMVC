﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhaDemoMvc.Models;

namespace MinhaDemoMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var filme = new Filme
            {
                Titulo = "Oi",
                DataLancamento = DateTime.Now,
                Genero = "",
                Avaliacao = 10,
                Valor = 20000
            };
            return RedirectToAction("Privacy", filme);
        }

        public IActionResult Privacy()
        {
            if(ModelState.IsValid)
            {
            
            }
            foreach(var item in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(item.ErrorMessage);
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
