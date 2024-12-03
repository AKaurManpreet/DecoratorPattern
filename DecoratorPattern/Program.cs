using System;

class Program
{
    static void Main(string[] args)
    {
        // Base Component
        IComponent<string> component = new ConcreteComponent();
        
        // Plain Decorator
        IComponent<string> plainDecorator = new PlainDecorator(component);
        
        // UpperCase Decorator
        IComponent<string> upperCaseDecorator = new UpperCaseDecorator(component);
        
        // Color Decorator
        IComponent<string> colorDecorator = new ColorDecorator(component);

        // Output results
        Console.WriteLine("Original Component: " + component.GetText());
        Console.WriteLine("Plain Decorator: " + plainDecorator.GetText());
        Console.WriteLine("UpperCase Decorator: " + upperCaseDecorator.GetText());
        Console.WriteLine("Color Decorator: " + colorDecorator.GetText());
    }
}
