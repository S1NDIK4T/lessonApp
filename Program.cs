using System;

namespace lessonapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree apple = new Appletree(1, "sda");
            Tree grusha = new GrushaTree(-12, "Груща");
            Console.WriteLine(apple.Age);
            apple.Grow();
            Console.WriteLine(apple.Age);
            Console.WriteLine(grusha.Age);
            grusha.Grow();
            Console.WriteLine(grusha.Age);
            Console.ReadKey();


        }
    }


}
