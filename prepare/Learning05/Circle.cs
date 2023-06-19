namespace Learning05
{
    class Circle : Shape
    {
        private double _radius;

        public Circle(double radius, string colour) : base(colour){
            _radius = radius;
        }

        public double GetRadius() {
            return _radius;
        }

        public void SetRadius(double radius) {
            _radius = radius;
        }


        public override double GetArea()
        {
            return Math.PI * _radius;
        }
    }
}
