using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Kolo : Figura
    {
        public double Radius { get; set; } // Радіус

        public Kolo(double radius)
        {
            Radius = radius;
        }
        public override double Plosha() => 3.14 * Radius * Radius;
        public override double Perimeter() => 2 * 3.14 * Radius;
        public override string Opys_figury() => $"Коло:     \nРадіус = {Radius}     \nПлоща = {Plosha()}    \nПериметр = {Perimeter()}";
    }

}
