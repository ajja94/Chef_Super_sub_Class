using System;

namespace Chef_super_sub_C
{
    class program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeSpecialDish();

            ItalianChef italianchef = new ItalianChef();
            italianchef.MakeSpecialDish();


            Console.ReadLine();
        }
    }
}
