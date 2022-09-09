using System;

namespace lessonapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree apple = new Appletree(19, "sda");
            Tree grusha = new GrushaTree(-12, "Груща");
            Console.WriteLine(apple.Age);
            apple.Grow();
            Console.WriteLine(apple.Age);
            Console.WriteLine(grusha.Age);
            grusha.Grow();
            Console.WriteLine(grusha.Age);
            Console.ReadKey();
            Tree antonovka = new Antonovka(5, "Антоновка");
            Console.WriteLine(antonovka.Age);
            antonovka.Grow();
            Console.WriteLine(antonovka.Age);

            Antonovka antonovka2 = new Antonovka(5, "Антоновка");
            Console.WriteLine(antonovka2.Age);
            antonovka2.Grow();
            Console.WriteLine(antonovka2.Age);




        }
    }


}
