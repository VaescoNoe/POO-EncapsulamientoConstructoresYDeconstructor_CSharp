

namespace POO
{
    class Rectangulo
    {
        private double _baseRectangulo;
        public double BaseRectangulo
                {
                get { return _baseRectangulo; }
                set { _baseRectangulo = value; }
                }


        private double _alturaRectangulo;
        public double AlturaRectangulo
                {
                get { return _alturaRectangulo; }
                set { _alturaRectangulo = value; }
                }
        
        
        private string _color;
        public string Color
                {
                get { return _color; }
                set { _color = value; }
                }

        public Rectangulo()
        {
            _baseRectangulo = 0;
            _alturaRectangulo = 0;
            _color = "Negro";
        }

        public Rectangulo(double baseRectangulo, double alturaRectangulo, string color)
        {
            _baseRectangulo = baseRectangulo;
            _alturaRectangulo = alturaRectangulo;
            _color = color;
        }

        public Rectangulo(string color, double baseRectangulo, double alturaRectangulo)
        {
            _baseRectangulo = baseRectangulo;
            _alturaRectangulo = alturaRectangulo;
            _color = color;
        }

        public double calcularArea()
        {
            return _baseRectangulo * _alturaRectangulo;
        }

        public double calcularPerimetro()
        {
            return (_baseRectangulo + _alturaRectangulo) *2;
        }

        public void Deconstruct(out double baseRect, out double alturaRect) {
            baseRect = _baseRectangulo;
            alturaRect = _alturaRectangulo;
        }
    }
}
