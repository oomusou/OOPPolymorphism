namespace ConsoleApp
{
    public class Triangle: Shape
    {
        private readonly double _base;
        private readonly double _height;
        
        public Triangle(double base_, double height)
        {
            _base = base_;
            _height = height;
        }
        
        public override double Area()
        {
            return 0.5 * _base * _height;
        }
    }
}