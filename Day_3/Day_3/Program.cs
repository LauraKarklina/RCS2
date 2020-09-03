using System;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1.uzdevums
            /*Console.WriteLine("Ievadi skaitli: ");
           int number=Convert.ToInt32( Console.ReadLine());
            int[] arr=RandomArr(number);
            
            Console.WriteLine(" ");
            ClearArr(arr);*/


            //2.uzdevums
           /* String[] arr2 = { "qqq", "www", "rrr"};
            Console.WriteLine("Kopejais simbolu skaits ir:"+GetStrLenght(arr2));*/


            //extra
            int[] arr3 =  { 2, 8, 4, 5, 7, 0, 2, 1 } ;
            AscendingOrder(arr3);

        }

        static int[] RandomArr(int number)
        {
            int[] arr = new int[number];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                
                arr[i] = rand.Next(101);
                Console.Write(arr[i]+" ");
            }

            return arr;
        }
        static void ClearArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]>50)
                {
                    
                    a[i] = 0;
                }
                Console.Write(a[i]+" ");
            }
        }
        static int GetStrLenght(String [] arr2)
        {
           

            int result = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                result += arr2[i].Length;
               
                
            } 
            return result;
        }

        static void AscendingOrder(int [] arr3)
        {
            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = i+1; j < arr3.Length; j++)
                {
                    if (arr3[i]>arr3[j])
                    {
                        int temp = arr3[i];//samainam elementus, ja 1.lielāks par 2.elementu
                        arr3[i] = arr3[j];
                        arr3[j] = temp;
                    }
                }
                Console.Write(arr3[i]+";");
            }
        }

    }
}
