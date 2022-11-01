using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tartuga_Simonov.EF;

namespace Tartuga_Simonov.Clases
{
    internal class ListDish
    {
        public static List<Dish> dishes = new List<Dish>();
    }

    public interface MenuInterface
    {
        void ChangeDishCount(int count);
    }
}
