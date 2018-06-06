using DecoratorDesignPatternExample.Decorators;

namespace DecoratorDesignPatternExample.ConcreteDecorators
{
    public class ChainsDecorator : IDecorator
    {
        public IComponent BaseComponent { get; set; }

        public string GetDescription()
        {
            var description = BaseComponent.GetDescription();
            return string.Format("{0} obwieszona łańcuchami", description);
        }
    }
}