using FluentAssertions;
using JoePizzaPortal.Models;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace JoePizzaPortalSpecFlow.Features
{
    [Binding]
    public class BuyFeatureSteps
    {
        public JoePizzaPortalContext context = new JoePizzaPortalContext();
        string PizzaName;
        int id;
        int expectedId = 4;

        [Given(@"the Pizza Name is French Pizza")]
        public void GivenThePizzaNameIsFrenchPizza()
        {
            PizzaName = "French Pizza";
            id = context.Pizzas.FirstOrDefault(x => x.PizzaName == PizzaName).PizzaId;
        }
        
        [Then(@"the PizzaId should be (.*)")]
        public void ThenThePizzaIdShouldBe(int id)
        {
            id.Should().Be(expectedId);
        }
    }
}
