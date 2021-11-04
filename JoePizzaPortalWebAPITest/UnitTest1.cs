using NUnit.Framework;
using JoePizzaPortal.Controllers;
using JoePizzaPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Newtonsoft;
using System.Net.Http;
using Newtonsoft.Json;

namespace JoePizzaPortalWebAPITest
{
    public class Tests
    {
        public JoePizzaPortalContext context = new JoePizzaPortalContext();
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CheckOutTest()
        {
            //Assign
            Order order = new Order()
            {
                OrderId = 20,
                CardNumber = "256798907865",
                OrderQuantity = 2,
                ShippingAddress = "1st Cross, HM Marg, New Delhi",
                TotalAmount = 452,
                PizzaType = "Veg",
                PizzaId = 4,
                transactionTime = new DateTime(2021, 11, 3, 11, 23, 12, 23)
            };

            //Act
            CartController cartController = new CartController(context);
            cartController.CheckOut("French Pizza", order.CardNumber, order.OrderQuantity, order.ShippingAddress, order.TotalAmount, order.PizzaType);
            var result = cartController.FindOrderById(order.OrderId);

            //Assert
            Assert.AreEqual(order.OrderId, result.OrderId);
            Assert.AreEqual(order.transactionTime, result.transactionTime);
        }

        [Test]
        public void ConfirmationTest()
        {
            //Assign
            int id = 9;
            int expectedQuantity = 2;
            string expectedPizzaType = "Veg";

            //Action
            CartController cartController = new CartController(context);
            var result = cartController.FindOrderById(id);

            //Assert
            Assert.AreEqual(id, result.OrderId);
            Assert.AreEqual(expectedQuantity, result.OrderQuantity);
            Assert.AreEqual(expectedPizzaType, result.PizzaType);
        }

        //Test to check FindPizzaByName
        [Test]
        public void BuyTest()
        {
            //Assign
            string PizzaName = "Italian Pizza";

            //Action
            CartController cartController = new CartController(context);
            var resultAction = cartController.FindPizzaByName(PizzaName);

            //Assert
            Assert.AreEqual(PizzaName,resultAction.PizzaName);

        }
    }
}