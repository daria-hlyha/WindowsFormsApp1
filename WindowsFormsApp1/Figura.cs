using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Figura
    {
        public abstract double Plosha(); // Метод для обчислення площі
        public abstract double Perimeter(); // Метод для обчислення периметра
        public abstract string Opys_figury(); // Метод для отримання опису фігури
    }
}