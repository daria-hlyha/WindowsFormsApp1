using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Romb : Figura
    {
        public double Diagonal1 { get; set; } // Перша діагональ
        public double Diagonal2 { get; set; } // Друга діагональ

        public Romb(double diagonal1, double diagonal2)
        {
            Diagonal1 = diagonal1;
            Diagonal2 = diagonal2;
        }

        public override double Plosha() => (Diagonal1 * Diagonal2) / 2;
        public override double Perimeter() => 4 * Math.Sqrt(Math.Pow(Diagonal1 / 2, 2) + Math.Pow(Diagonal2 / 2, 2));
        public override string Opys_figury() => $"Ромб:     \nПерша діагональ = {Diagonal1}     \nДруга діагональ = {Diagonal2}     \nПлоща = {Plosha()}     \nПериметр = {Perimeter()}";
    }

}
