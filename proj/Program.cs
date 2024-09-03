using System;

namespace Homework
{
    internal class Interface
    {
        public abstract class Animal
        {
            protected string Name { get; set; }
            protected string Species { get; set; }

            public Animal(string name, string species)
            {
                Name = name;
                Species = species;
            }

            public void Describe()
            {
                Console.WriteLine($"{Species} has name {Name}");
            }
        };

        public interface ISwim
        {
            void Swim();
        }

        public interface IFly
        {
            void Fly();
        }

        public interface IHunt
        {
            void Hunt();
        }
        public class Shark : Animal, ISwim, IHunt
        {
            public Shark(string name) : base(name, "Shark") { }

            public void Swim()
            {
                Console.WriteLine($"{Name} swimming.");
            }

            public void Hunt()
            {
                Console.WriteLine($"{Name} hunting.");
            }
        }

        public class Eagle : Animal, IFly, IHunt
        {
            public Eagle(string name) : base(name, "Eagle") { }

            public void Fly()
            {
                Console.WriteLine($"{Name} flying.");
            }

            public void Hunt()
            {
                Console.WriteLine($"{Name} hunting.");
            }
        }

        public class Penguin : Animal, ISwim
        {
            public Penguin(string name) : base(name, "Penguin") { }

            public void Swim()
            {
                Console.WriteLine($"{Name} swimming.");
            }

        }


        static void Main(string[] args)
        {
            Animal[] animals =
            {
                new Shark("Grigoriy"),
                new Eagle("Vasya"),
                new Penguin("Petya")
            };

            foreach (var animal in animals)
            {
                animal.Describe();

                if (animal is ISwim swimmer)
                {
                    swimmer.Swim();
                }

                if (animal is IFly flyer)
                {
                    flyer.Fly();
                }

                if (animal is IHunt hunter)
                {
                    hunter.Hunt();
                }

                Console.WriteLine();
            }


        }
    }
            
}
