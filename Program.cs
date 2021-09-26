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
            Console.WriteLine("What is your name?");
            myName =  Console.ReadLine();
            Console.WriteLine("Enter your age");
            age = (byte)int.Parse(Console.ReadLine());
            //bool isAgeCorrenct = byte.TryParse(Console.ReadLine(), out age);
            //while (!isAgeCorrenct)
            //{
            //    Console.WriteLine("Enter your age");
            //    isAgeCorrenct = byte.TryParse(Console.ReadLine(), out age);
            //}
            Console.WriteLine("My name is {0}",myName); 
            Console.WriteLine("My age is {0}", age);
            Console.WriteLine("Do I have a pet? {0}", havePet);
            Console.WriteLine("My shoe size is {0}", legSize);
            Console.WriteLine($"My favorite traffic light color is {lights}");
            double result = 5.0 / 2;
            Console.WriteLine(result);
            int count = 10;
            Console.WriteLine("Value:{0},Prefix Increment:{1}", count, ++count);
            Console.WriteLine("Value:{0},Postfix Increment:{1}", count, count++);
            double result_ostatok = 10 % 3;
            Console.WriteLine(result_ostatok);
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
