using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Container
    {
        private List<Figura> figury = new List<Figura>();

        public void AddFigura(Figura figura)
        {
            figury.Add(figura);
        }
        public void RemoveFiguraByOpis(string opis)
        {
            var figuraToRemove = figury.FirstOrDefault(f => f.Opys_figury() == opis);
            if (figuraToRemove != null)
            {
                figury.Remove(figuraToRemove);
            }
        }
        public void ClearAllFigury()
        {
            figury.Clear();
        }

        public List<Figura> GetFigury()
        {
            return figury;
        }
        
    }
}

