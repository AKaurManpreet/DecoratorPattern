using System;

public class ColorDecorator : Decorator<string>
{
    public ColorDecorator(IComponent<string> component) : base(component) { }

    public override string GetText()
    {
        string text = base.GetText();
        string[] lines = text.Split('\n');
        
        if (lines.Length >= 2)
        {
            string firstLine = "\u001b[31m" + lines[0] + "\u001b[0m"; // Red color
            string secondLine = "\u001b[34m" + lines[1] + "\u001b[0m"; // Blue color

            return $"{firstLine}\n{secondLine}";
        }

        return text;
    }
}