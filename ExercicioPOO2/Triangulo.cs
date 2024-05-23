using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO2
{
    internal class Triangulo
    {
        public double Largura, Altura;

        public double Area() 
        {
            return Largura * Altura;
        }

        public double Perimetro() 
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
        
    }
}
