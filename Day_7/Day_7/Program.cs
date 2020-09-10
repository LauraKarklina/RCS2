using System;
using System.Collections.Generic;

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

                        /*Studenti students = new Studenti();
            Console.WriteLine("Ievadi vārdu: ");
            students.vards = Console.ReadLine();

            Console.WriteLine("Ievadi uzvārdu: ");
            students.uzvards = Console.ReadLine();

            Console.WriteLine("Ievadi kursu: ");
            students.kurss = Convert.ToInt32(Console.ReadLine());
                        
            students.PrintInfo(); */

            //List<Studenti> students = new List<Studenti>();


            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadi vārdu: ");
                String vards = Console.ReadLine();

                Console.WriteLine("Ievadi uzvārdu: ");
                String uzvards = Console.ReadLine();

                Console.WriteLine("Ievadi kursu: ");
                int kurss = Convert.ToInt32(Console.ReadLine());
                students.Add(new Studenti(vards, uzvards, kurss));
                
            }

            foreach (Studenti stud in students)
            {
                stud.PrintInfo();
            }*/

            MD();


        }
        static void MD()
        {
            List<Studenti> students = new List<Studenti>();
            String choice = "";

            while (choice != "3")
            {
                Console.WriteLine("Izvēlies darbību:");
                Console.WriteLine("0- Pievienot");
                Console.WriteLine("1- Dzēst");
                Console.WriteLine("2- Izvadīt");
                Console.WriteLine("3- Iziet");

                choice = Console.ReadLine();


                switch (choice)
                {
                    case "0":
                        AddElement(students);
                        break;
                    case "1":
                        RemoveElement(students);
                        break;
                    case "2":
                        PrintLst(students);
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("nepareiza ievade!");
                        break;
                }


            }
        }


        private static void AddElement(List<Studenti> students)
        {
            Console.WriteLine();
            Console.WriteLine("Cik studentus pievienosiet? ");
            int vertibuSkaits = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < vertibuSkaits; i++)
            {
                Console.WriteLine("Pievieno studentu nr." + i);
                Console.WriteLine("Ievadi vārdu: ");
                String vards = Console.ReadLine();

                Console.WriteLine("Ievadi uzvārdu: ");
                String uzvards = Console.ReadLine();

                Console.WriteLine("Ievadi kursu: ");
                int kurss = Convert.ToInt32(Console.ReadLine());
                students.Add(new Studenti(vards, uzvards, kurss));
            }
            
        }
        private static void RemoveElement(List<Studenti> students)
        {

            try
            {
                Console.WriteLine();
                Console.WriteLine("Norādi indeksu, kuru studentu vēlies dzēst?");
                int studentNumber = Convert.ToInt32(Console.ReadLine());

                students.RemoveAt(studentNumber);

                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Nav tāda vērtība");
                //RemoveElement(students);

            }

        }

        private static void PrintLst(List<Studenti> students)
        {
            Console.WriteLine();

            if (students.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss!");
                return;
            }

            /*foreach (Studenti stud in students)
            {
                stud.PrintInfo();
            }*/

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(i+ ":" +students[i].vards+" " 
                    + students[i].uzvards +"" + students[i].kurss);
            }

            Console.WriteLine();
        }
        static string InputString()
        {
            string darbiba = "";
            try
            {
                Console.WriteLine("Ievadiet darbibu");
                darbiba = Console.ReadLine();
            }
            catch
            {
                darbiba = InputString();
            }

            return darbiba;
        }

    }
}

