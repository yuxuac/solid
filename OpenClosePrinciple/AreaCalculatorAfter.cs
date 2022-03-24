using System;

/*
Open-close principle
*/
namespace SOLID
{
    public class AreaCalculatorAfter
    {
        public void CalcAreas(IShape[] shapes)
        {
            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"Size of {shape.GetType().Name} is {shape.CalcArea()}");
            }
        }
    }
}