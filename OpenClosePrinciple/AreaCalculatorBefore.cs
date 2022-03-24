using System;

/*
Open-close principle
*/
namespace SOLID
{

    public class AreaCalculatorBefore
    {
        public double CalculatorRectArea(Rectangle rect)
        {
            return rect.Height * rect.Width;
        }

        public double CalculatorCircleArea(Circle circ)
        {
            return Math.PI * circ.Radius * circ.Radius;
        }

        public double CalcArea(Object obj)
        {
            if(obj is Rectangle)
                return CalculatorRectArea(obj as Rectangle);
            else if(obj is Circle)
                return CalculatorCircleArea(obj as Circle);
            else
                throw new NotSupportedException("no support shape");
        }

        public void CalcAreas(Object[] objs)
        {
            foreach(var obj in objs)
            {
                Console.WriteLine($"Size of {obj.GetType().Name} is {CalcArea(obj)}");
            }
        }
    }
}