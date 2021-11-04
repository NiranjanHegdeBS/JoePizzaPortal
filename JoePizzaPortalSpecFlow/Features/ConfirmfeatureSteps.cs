using FluentAssertions;
using JoePizzaPortal.Models;
using System;
using TechTalk.SpecFlow;

namespace JoePizzaPortalSpecFlow.Features
{
    [Binding]
    public class ConfirmfeatureSteps
    {
        public JoePizzaPortalContext context = new JoePizzaPortalContext();
        public int OrderId;

        public int expectedOrderQuantity;
        public int OrderQuantity;

        public string expectedCardNumber;
        public string CardNumber;

        public int expectedPizzaId;
        public int PizzaId;

        public string expectedType;
        public string Type;

        public string expectedAddress;
        public string Address;


        [Given(@"the order id is (.*)")]
        public void GivenTheOrderIdIs(int p0)
        {
            OrderId = p0;
        }
        
        [Then(@"order quantity should be (.*)")]
        public void ThenOrderQuantityShouldBe(int p0)
        {
            expectedOrderQuantity = p0;
            OrderQuantity = context.Orders.Find(OrderId).OrderQuantity;

            OrderQuantity.Should().Be(expectedOrderQuantity);

        }
        
        [Then(@"the card number should be (.*)")]
        public void ThenTheCardNumberShouldBe(string p0)
        {
            expectedCardNumber = p0;
            CardNumber = context.Orders.Find(OrderId).CardNumber;

            CardNumber.Should().Be(expectedCardNumber);
        }
        
        [Then(@"the shipping adress should be (.*)st Cross, HM Marg, New Delhi")]
        public void ThenTheShippingAdressShouldBeStCrossHMMargNewDelhi(int p0)
        {
            expectedAddress = p0 + "st Cross, HM Marg, New Delhi";
            Address = context.Orders.Find(OrderId).ShippingAddress;

            Address.Should().Be(expectedAddress);
        }
        
        [Then(@"the Pizza Id should be (.*)")]
        public void ThenThePizzaIdShouldBe(int p0)
        {
            expectedPizzaId = p0;
            PizzaId = context.Orders.Find(OrderId).PizzaId;

            PizzaId.Should().Be(expectedPizzaId);
        }
        
        [Then(@"the Pizza Type should be Veg")]
        public void ThenThePizzaTypeShouldBeVeg()
        {
            expectedType = "Veg";
            Type = context.Orders.Find(OrderId).PizzaType;

            Type.Should().Be(expectedType);
        }
    }
}
