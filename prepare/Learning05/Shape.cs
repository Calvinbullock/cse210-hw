namespace Learning05
{
    public abstract class Shape
    {
        private string _colour;

        public Shape(string colour) {
            _colour = colour;
        }

        public void SetColour(string colour) {
            _colour = colour;
        }

        public string GetColour() {
            return _colour;
        }

        public abstract double GetArea(); 
    }
}