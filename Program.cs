using System;

namespace SOLID // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Before
            Rectangle rect = new Rectangle() { Width = 10, Height = 20 };
            Circle circ = new Circle() { Radius = 13 };
            object[] objs = new object[] { rect, circ };
            AreaCalculatorBefore calc = new AreaCalculatorBefore();
            calc.CalcAreas(objs);

            // After
            IShape[] shapes = new IShape[] { rect, circ, rect, circ };
            AreaCalculatorAfter calc2 = new AreaCalculatorAfter();
            calc2.CalcAreas(shapes);

        }
    }
}
