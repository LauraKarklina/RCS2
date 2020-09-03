using System;
using System.Reflection;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.uzd-Uztaisīt metodi, kas kā parametru paņem vienu int tipa skaitli
            //un izvada vai skaitlis ir pozitīvs vai negatīvs.
            Console.WriteLine("Ieraksti skaitli: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Task3_1(number));


            //2.uzd-Paņemt kodu no pirmā punkta un pārveidot, 
            //lai pozitīva skaitļa gadījumā atgriež true, negatīva- false.
            Console.WriteLine("Ieraksti skaitli: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Task3_2(number2));


            //3.uzd-Uztaisīt metodi, kas kā parametru paņem vienu int tipa skaitli, 
            //šo skaitli izmantot, lai noteiktu, cik skaitļus cilvēkam jāievada. Izvadīt skaitļu summu. 
            Console.WriteLine("Ieraksti, cik skaitļus vēlies saskaitīt: ");
            int skaitluDaudzums = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaitļu summa ir: " + Task3_3(skaitluDaudzums));


            //4.uzd-Realizēt kāpināšanu ar veseliem/pozitīviem skaitļiem, 
            //metodei ir vajadzīgi parametri un return. 
            Console.WriteLine("Ieraksti skaitli, ko vēlies kāpināt: ");
            var number4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kādā pakāpē vēlies skaitli: ");
            var pakape = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Rezultāts ir: " + Task3_4(number4, pakape));

        }
        static void Task3_1(int number)
        {


            if (number > 0)
            {
                Console.WriteLine("Skaitlis ir pozitīvs");
            }
            else
            {
                Console.WriteLine("Skaitlis ir negatīvs");
            }

        }
        static bool Task3_2(int number2)
        {

            bool positiveOrNegative = number2 > 0;

            return positiveOrNegative;
        }
        static int Task3_3(int skaitluDaudzums)
        {


            if (skaitluDaudzums < 1)
            {
                Console.WriteLine("Cikls nav iespējams");
                return;
            }

            int sum = 0;
            for (int i = 0; i < skaitluDaudzums; i++)
            {
                Console.WriteLine("Ievadi skaitli: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);

                sum += number;
            }


            return sum;
        }
        static int Task3_4(int number4, int pakape)
        {

            int result = 1;
            for (int i = 0; i < pakape; i++)
            {

                result = result * number4;
            }


            return result;
        }
    }
}
