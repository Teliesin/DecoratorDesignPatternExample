namespace DecoratorDesignPatternExample.Decorators.ConcreteDecorators
{
    public class ChristmasStarDecorator : IDecorator
    {
        public IComponent BaseComponent { get; set; }

        public string GetDescription()
        {
            var description = BaseComponent.GetDescription();
            return string.Format("{0} z gwiadką choinkową na czubku", description);
        }
    }
}