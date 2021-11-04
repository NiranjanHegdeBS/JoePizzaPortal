using JoePizzaPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoePizzaPortal.Controllers
{
    public class PizzaController : Controller
    {
        private readonly JoePizzaPortalContext _context;

        public PizzaController(JoePizzaPortalContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var pizzas = _context.Pizzas.ToList();
            return View(pizzas);
        }
    }
}
