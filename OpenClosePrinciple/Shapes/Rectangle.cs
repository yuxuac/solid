namespace SOLID
{
    public class Rectangle : IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public double CalcArea()
        {
            return this.Width * this.Height;
        }
    }

}