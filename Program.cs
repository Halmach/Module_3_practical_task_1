using System;

namespace Module_3_practical_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            myName = "Halmach";
            byte age = 34;
            bool havePet = true;
            float legSize = 40;
            Semaphore lights = Semaphore.Green;


            Console.WriteLine("My name is {0}",myName);
            Console.WriteLine("My age is {0}", age);
            Console.WriteLine("Do I have a pet? {0}", havePet);
            Console.WriteLine("My shoe size is {0}", legSize);
            Console.WriteLine("My favorite traffic light color is " + lights);

            Console.ReadKey();
        }
    }

    enum Semaphore
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }

}
