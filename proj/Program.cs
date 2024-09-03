using System;

namespace RefTypeValueType
{
    internal class Drob
    {
        public int Ch { get; set; }
        int zn;
        public int Zn
        {
            get { return zn; }
            set
            {
                if (value == 0)
                    throw new DivideByZeroException();
                else
                    zn = value;
            }
        }

        public override string ToString()
        {
            return Ch.ToString() + "/" + Zn.ToString();
        }

        public Drob()
        {
            Ch = 1; zn = 1;
        }

        public Drob(int ch, int zn)
        {
            this.Ch = ch; this.Zn = zn;
        }


        public static Drob operator *(Drob a, Drob b)
        {
            return new Drob(a.Ch * b.Ch, a.Zn * b.Zn);
        }


        public static Drob operator +(Drob a, Drob b)
        {
            int newCh = a.Ch * b.Zn + b.Ch * a.Zn;
            int newZn = a.Zn * b.Zn;
            return new Drob(newCh, newZn);
        }


        public static Drob operator /(Drob a, Drob b)
        {
            if (b.Ch == 0)
                throw new DivideByZeroException();
            return new Drob(a.Ch * b.Zn, a.Zn * b.Ch);
        }

        public static bool operator >=(Drob a, Drob b)
        {
            return (a.Ch * b.Zn) >= (b.Ch * a.Zn);
        }


        public static bool operator <=(Drob a, Drob b)
        {
            return (a.Ch * b.Zn) <= (b.Ch * a.Zn);
        }


        static void Main(string[] args)
        {
            try
            {
                Drob drob1 = new Drob(1, 2);
                Console.WriteLine(drob1);

                Drob drob2 = new Drob(2, 3);
                Console.WriteLine(drob2);

                Drob drob3 = drob1 * drob2;
                Console.WriteLine("Multiplication: " + drob3);

                Drob drob4 = drob1 + drob2;
                Console.WriteLine("Addition: " + drob4);

                Drob drob5 = drob1 / drob2;
                Console.WriteLine("Division: " + drob5);

                Console.WriteLine("drob1 >= drob2: " + (drob1 >= drob2));
                Console.WriteLine("drob1 <= drob2: " + (drob1 <= drob2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
