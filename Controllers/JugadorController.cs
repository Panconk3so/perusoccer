using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using perusoccer.Models;

namespace perusoccer.Controllers
{
   
    public class JugadorController : Controller
    {
        private readonly ILogger<JugadorController> _logger;

        public JugadorController(ILogger<JugadorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Jugador jugador)
        {
            const decimal RegistrationFee = 300;
            const decimal TaxRate = 0.19m;

            decimal totalFee = RegistrationFee * jugador.Seasons;
            decimal taxAmount = totalFee * TaxRate;
            jugador.TotalAmount = totalFee + taxAmount;

            return View("Index",jugador);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
        }
    }

