namespace Learning05
{
    class Rectangle : Shape
    {
        private double _length;
        private double _width;

        public Rectangle(double length, double width, string colour) : base(colour) {
            _length = length;
            _width = width;
        }

        public void GetLength(double length)
        {
            _length = length;
        }

        public double SetLength()
        {
            return _length;
        }

        public void GetWidth(double width)
        {
            _width = width;
        }

        public double SetWidth()
        {
            return _width;
        }

        public override double GetArea()
        {
            return _length * _width;
        }
    }
}