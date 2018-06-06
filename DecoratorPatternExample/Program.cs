using DecoratorDesignPatternExample.ConcreteDecorators;
using DecoratorDesignPatternExample.Decorators;
using DecoratorDesignPatternExample.Decorators.Components;
using DecoratorDesignPatternExample.Decorators.ConcreteDecorators;
using System;

namespace DecoratorDesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent myTheBestChristmasTreeEver = new Pine();

            BaublesDecorator baubles = new BaublesDecorator();
            baubles.BaseComponent = myTheBestChristmasTreeEver;
            myTheBestChristmasTreeEver = baubles;

            ChainsDecorator chains = new ChainsDecorator();
            chains.BaseComponent = myTheBestChristmasTreeEver;
            myTheBestChristmasTreeEver = chains;

            ChristmasTreeLightsDecorator christmasTreeLightsDecorator = new ChristmasTreeLightsDecorator();
            christmasTreeLightsDecorator.BaseComponent = myTheBestChristmasTreeEver;
            myTheBestChristmasTreeEver = christmasTreeLightsDecorator;

            ChristmasStarDecorator christmasStar = new ChristmasStarDecorator();
            christmasStar.BaseComponent = myTheBestChristmasTreeEver;
            myTheBestChristmasTreeEver = christmasStar;

            string description = myTheBestChristmasTreeEver.GetDescription();
            Console.WriteLine(description);

            Console.ReadKey();
        }
    }
}