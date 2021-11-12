using System;

namespace Open_Lab_01._03
{
    public class Exercise
    {
        public int Addition(int number)
        {
            throw new NotImplementedException();
            Console.WriteLine("zadaj číslo");
            int vstup = Convert.ToInt32(Console.ReadLine());
            int vystup = vstup + 1;
            Console.WriteLine("výsledopk " + vystup);
        }
    }
}