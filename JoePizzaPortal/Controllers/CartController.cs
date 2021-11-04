using JoePizzaPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoePizzaPortal.Controllers
{
    public class CartController : Controller
    {
        private readonly JoePizzaPortalContext _context;
        public CartController(JoePizzaPortalContext context)
        {
            _context = context;
        }

        public Pizza FindPizzaByName(string PizzaName)
        {
            return _context.Pizzas.FirstOrDefault(x => x.PizzaName == PizzaName);
        }

        public Order FindOrderById(int id)
        {
            return _context.Orders.Find(id);
        }
        [HttpPost]
        public IActionResult Buy(string PizzaName,int Quantity,string Type)
        {
            if (Quantity > 0 && !string.IsNullOrEmpty(Type)){
                var pizza = FindPizzaByName(PizzaName);
                double total = Quantity * pizza.Price;
                ViewBag.amount = total;
                ViewBag.Quantity = Quantity;
                ViewBag.Type = Type;
                ViewBag.PizzaName = PizzaName;
                return View();
            }
            else
                return RedirectToAction("Index","Pizza");
        }

        [HttpPost]
        public IActionResult CheckOut(string PizzaName, string CardNumber,int Quantity,string ShippingAddress,double TotalAmount,string type) 
        {
            Order order = new Order();
            order.CardNumber = CardNumber;
            order.TotalAmount = TotalAmount;
            order.OrderQuantity = Quantity;
            order.ShippingAddress = ShippingAddress;
            order.PizzaType = type;
            order.PizzaId = _context.Pizzas.FirstOrDefault(x => x.PizzaName == PizzaName).PizzaId;
            order.transactionTime = DateTime.Now;
            _context.Orders.Add(order);
            _context.SaveChanges();
            return RedirectToAction("Confirmation", new { id = order.OrderId }); 
        }

        public IActionResult Confirmation(int id)
        {
            ViewBag.id = id;
            var orderInfo = FindOrderById(id);
            ViewBag.orderId = orderInfo.OrderId;
            ViewBag.pizza = _context.Pizzas.Find(orderInfo.PizzaId).PizzaName;
            ViewBag.type = orderInfo.PizzaType;
            ViewBag.quantity = orderInfo.OrderQuantity;
            ViewBag.address = orderInfo.ShippingAddress;
            ViewBag.total = orderInfo.TotalAmount;
            ViewBag.time = orderInfo.transactionTime;
            return View();
        }
    }
}
