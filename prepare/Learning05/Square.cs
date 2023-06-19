namespace Learning05
{
    class Square : Shape
    {
        private double _side;

        public Square(double side, string colour) : base(colour) {
            _side = side;
        }

        public void GetSide(double side)
        {
            _side = side;
        }

        public double SetSide()
        {
            return _side;
        }

        public override double GetArea() {
            return _side * _side;
        }
    }
}