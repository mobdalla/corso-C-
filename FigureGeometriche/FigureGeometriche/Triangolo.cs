using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Triangolo
    {
        public double Lato1 { get; set; }
        public double Lato2 { get; set; }
        public double Lato3 { get; set; }

        public double Permetro()
        {
            return Lato1 + Lato2 + Lato3;
        }
        public bool IsCostruibile()
        {
            return Lato1+Lato2 > Lato3 
                && Lato2+Lato3 > Lato1
                && Lato1 + Lato3 > Lato2;
        }
        public double Area()
        {
            double sp = Permetro() / 2;
            return Math.Sqrt(sp * (sp - Lato1) * (sp - Lato2) * (sp - Lato3));
        }

        public string Tipo()
        {
            if (Lato1 == Lato2 && Lato1 == Lato3)
            {
                return "Equilatero";
            }
            else
            {
                if (Lato1 == Lato2 && Lato2 == Lato3 && Lato3 == Lato1)
                {
                    return "Isoscele";
                }
                else
                {
                    return "Scaleno";
                }
            }
        }

        public override string ToString()
        {
            if (!IsCostruibile())
                return "Con i lati forniti non si puo  costruire";
            return $"{nameof(Lato1)}={Lato1.ToString()} " +
                $"{nameof(Lato2)}={Lato2.ToString()}" +
                $" {nameof(Lato3)}={Lato3.ToString()}" +
                $"Permertro = {Permetro()}" +
                $"Area= {Area()}" +
                $"Tipo ={Tipo()}";
        }
    }   
}
