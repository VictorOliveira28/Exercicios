using System;


namespace RetanguloPOO {
    internal class Retangulo {
        public double Widith;
        public double Height;

        public double Area() {
            return Widith * Height;

        }

        public double Perimetro() {
            return 2 * (Widith + Height);
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(Widith, 2) + Math.Pow(Height, 2));
        }
    }
}
