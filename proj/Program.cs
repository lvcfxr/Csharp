using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Interface
    {
        protected string shop_name = "IKEA";
        protected string shop_adress = "shop adress";
        protected string shop_description = "Furnitures, bathroom vanities, etc.";
        protected string shop_contact_number = "+12 345 678 910";
        protected string shop_contact_email = "ikea@gmail.com";

        string get_name()
        {
            return shop_name;
        }
        string get_adress()
        {
            return shop_adress;
        }
        string get_desc()
        {
            return shop_description;
        }
        string get_number()
        {
            return shop_contact_number;
        }
        string get_email()
        {
            return shop_contact_email;
        }
        public void display_name()
        {
            Console.WriteLine(get_name());
        }

        public void display_adress()
        {
            Console.WriteLine(get_adress());
        }

        public void display_desc()
        {
            Console.WriteLine(get_desc());
        }
        public void display_number()
        {
            Console.WriteLine(get_number());
        }
        public void display_email()
        {
            Console.WriteLine(get_email());
        }
        static void Main(string[] args)
        {
            Interface shop = new Interface();

            shop.display_name();
            shop.display_adress();
            shop.display_desc();
            shop.display_number();
            shop.display_email();

        }
    }
}
