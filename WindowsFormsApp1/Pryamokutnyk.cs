using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Pryamokutnyk : Figura
    {
        public double Width { get; set; } // Ширина
        public double Height { get; set; } // Висота або Довжина

        public Pryamokutnyk(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Plosha() => Width * Height;
        public override double Perimeter() => 2 * (Width + Height);
        public override string Opys_figury() => $"Прямокутник:     \nШирина = {Width}     \nВисота = {Height}     \nПлоща = {Plosha()}     \nПериметр = {Perimeter()}";
    }

}
