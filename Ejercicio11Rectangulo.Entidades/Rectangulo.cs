using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11Rectangulo.Entidades
{
    public class Rectangulo:ICloneable
    {
        public int LadoMayor { get; set; }
        public int LadoMenor { get; set; }

        public int GetPerimetro()
        {
            return 2 * LadoMayor + 2 * LadoMenor;
        }

        public int GetSuperficie()
        {
            return LadoMayor * LadoMenor;
        }

        public bool Validar()
        {
            return LadoMayor > 0 && LadoMenor > 0 && LadoMayor > LadoMenor;
        }

        public override bool Equals(object obj)
        {
            if (obj==null ||!(obj is Rectangulo))
            {
                return false;
            }

            return this.LadoMayor == ((Rectangulo) obj).LadoMayor &&
                   this.LadoMenor == ((Rectangulo) obj).LadoMenor;
        }

        public override int GetHashCode()
        {
            return (LadoMayor + LadoMenor).GetHashCode();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
