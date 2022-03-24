namespace SOLID
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalcArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }

}