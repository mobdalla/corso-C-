using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Cerchio
    {
		//
		private double raggio;

		public double Raggio
		{
			get { return raggio; }
			set {
				if (value <= 0)
					throw new Exception("Raggio inseristo non valido");
				raggio = value; 
				}
		}
		//costruttore con passaggio di parametro
		public Cerchio(double raggio) {
			Raggio = raggio;
		}
        public double Diametro()
        {
            return 2 * Raggio;
        }
        public double Circonferenza()
        {
            return Diametro() * Math.PI;
        }
        public double Area()
        {
            return Math.PI * Math.Pow(Raggio, 2);
        }
        public string StampaDetttaglio()
        {
            return $"{nameof(Raggio)}={Raggio.ToString()}" +
                $",\n Diametro={Diametro()}" +
                $",\n Circonfereza={Circonferenza()}" +
                $",\n Area={Area()}";
        }

        public override string ToString()
        {
            return $"{nameof(Raggio)}={Raggio.ToString()}" +
                $", Diametro={Diametro()}" +
                $", Circonfereza={Circonferenza()}" +
                $", Area={Area()}";

        }
    }
	

}
