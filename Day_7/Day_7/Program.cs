using System;

namespace Day_7
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Car car1 = new Car();
            
            car1.color = "Red";
            car1.brand = "Volkswagen";
            car1.model = "Jetta";


            car1.PrintInfo();

            Car c2 = new Car();
            c2.PrintInfo();*/



            Studenti students = new Studenti();
            Console.WriteLine("Ievadi vārdu: ");
            students.vards = Console.ReadLine();

            Console.WriteLine("Ievadi uzvārdu: ");
            students.uzvards = Console.ReadLine();

            Console.WriteLine("Ievadi kursu: ");
            students.kurss = Convert.ToInt32(Console.ReadLine());

            
            
            students.PrintInfo(); 




        }
    }
}
