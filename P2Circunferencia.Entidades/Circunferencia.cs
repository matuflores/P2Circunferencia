using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Circunferencia.Entidades
{
    public class Circunferencia
    {
        private int radio;

        public ColoresDispiblesRelleno ColoresDispiblesRelleno { get; set; }
        public ColoresDisponiblesBorde ColoresDisponiblesBorde { get; set; }
        public int Radio 

        {
            get { return radio; } 
            set{ radio = value; } 
        }

        public double GetPerimetro() 
        {
            double perimetro=2 * Math.PI * Radio;
            return Math.Truncate(perimetro);
        }

        public bool Validar()
        {
            return Radio > 0;
        }
        public double GetArea()
        { 
            double area=Math.PI * Math.Pow(Radio, 2);
            return Math.Truncate(area);
        }

        public override bool Equals(object obj)
        {
            if (obj==null || !(obj is Circunferencia))
            {
                return false;
            }
            return this.Radio == ((Circunferencia)obj).Radio;
        }

        public override int GetHashCode()
        {
            return (Radio).GetHashCode();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
