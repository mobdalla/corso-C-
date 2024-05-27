using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Rettangolo
    {
        public double Base { get; set; }
        public double Altezza { get; set; }
        public double Perimetro()
        {
            return (Altezza + Base) * 2;
        }
        public double Area()
        {
            return Base * Altezza;
        }
        public double Diagonale()
        {
            return Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altezza, 2));
        }
        public override string ToString()
        {
            return $"Lato: {Base}" +
                $", Perimetro: {Perimetro()}" +
                $", Area: {Area()}" +
                $", Diagonale: {Diagonale()}";
        }

    }
    
}
