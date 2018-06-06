namespace DecoratorDesignPatternExample.Decorators
{
    public interface IDecorator : IComponent
    {
        IComponent BaseComponent { get; set; }
    }
}