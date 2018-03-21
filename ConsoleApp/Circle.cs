namespace ConsoleApp
{
    public class Circle : Shape
    {
        private readonly double _radius;
        
        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double Area()
        {
            return 3.14 * _radius * _radius;
        }
    }
}