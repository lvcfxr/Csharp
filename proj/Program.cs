using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    internal class Program
    {
        public enum DayType { Morning, AllDay, Evening }

        public class Dish : IComparable<Dish>
        {
            public string Title { get; set; }

            public double Price { get; set; }

            public DayType DayTypes { get; set; }

            public override string ToString()
            {
                return $"Title: {Title}, Day: {DayTypes}, Price: {Price}";
            }

            public int CompareTo(Dish other)
            {
                if (other == null) return 0;
                return this.Title.CompareTo(other.Title);
            }
            public static PriceCompare SortDish
            {
                get { return new PriceCompare(); }

            }
        }

        public class PriceCompare : IComparer<Dish>
        {
            public int Compare(Dish? x, Dish? y)
            {
                if (x == null && y == null) return 0;
                if (x == null) return -1;
                if (y == null) return 1;

                return -x.Price.CompareTo(y.Price);
            }
        }

        static void Main(string[] args)
        {
            Dish[] dishes = new Dish[]
            {
                new Dish
                {
                    Title = "Coffee", DayTypes = DayType.Morning, Price = 2.00
                },

                new Dish
                {
                    Title = "Tea", DayTypes = DayType.AllDay, Price = 1.50
                }
            };

            Array.Sort(dishes);

            foreach (var dish in dishes)
            {
                Console.WriteLine(dish);
            }

            Array.Sort(dishes, Dish.SortDish);

            foreach (var dish in dishes)
            {
                Console.WriteLine(dish);
            }
        }
    }
}
