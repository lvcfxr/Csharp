using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    enum DayType { Morning, AllDay, Evening}
    class Dish
    {
        public string Title { get; set; }

        public double Price { get; set; }

        public DayType DayType { get; set; }
        
        public override string ToString()
        {
            return $"Title:{Title}, Day:{DayType}, Price:{Price} ";
        }
    }
}
