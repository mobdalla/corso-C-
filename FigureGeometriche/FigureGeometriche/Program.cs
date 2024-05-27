using System.Xml.Linq;

namespace FigureGeometriche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Quadrato q = new Quadrato();
            q.Lato = 12;
            Cerchio c = new Cerchio(20);
            
            Console.WriteLine(c);
            Console.WriteLine(c.StampaDetttaglio());

            Rettangolo r = new Rettangolo()
            {
                Base = 2.2,
                Altezza = 2.3
            };
            Console.WriteLine(r);
            Triangolo t = new Triangolo() { Lato1 = 1.2, Lato2 = 2.3, Lato3 = 4.3 };
            Console.WriteLine(t);
            Punto p = new Punto("P", 1.2, 2.3);
            Console.WriteLine(p);

            Punto p1 = new Punto("Q", -1.2, -1.1);
            Console.WriteLine(p1);

            Console.WriteLine($"PQ={p.Distanza(p1)}");
            Console.WriteLine($"PQ={p1.Distanza(p)}");



        }
    }
}