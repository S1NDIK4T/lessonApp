using System;

namespace lessonapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree a = new Appletree(1, "sda");
            Tree grusha = new GrushaTree(-12, "Груща");
            Console.WriteLine(a.Age);
            a.Grow();
            Console.WriteLine(a.Age);
            Console.WriteLine(grusha.Age);
            grusha.Grow();
            Console.WriteLine(grusha.Age);
            Console.ReadKey();


        }
    }


}
