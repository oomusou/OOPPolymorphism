namespace ConsoleApp
{
    public class Rectangle : Shape
    {
        private readonly double _width;
        private readonly double _height;
        
        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }
        
        public override double Area()
        {
            return _width * _height;
        }
    }
}