//////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////
//////      CopyRight: Ahmad Karmi Bukani     احمد کرمی بوکانی    //////
//////          Rojhalat Kurdistan  2025          روژهلات کوردستان     ///////
///////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;

namespace XAxisBigData
{

    class Program
    {
        static void Main(string[] args)
        {

         //   long low = -150;
         //   long high = 150;


            long low = -133999999;
            long high = 133999999;

            string[] Number_Random_Array;
            Number_Random_Array = new string[high];

            string[] X_Axis;
            X_Axis = new string[2 * high + 1];

            string[] Result_Sort_Array;
            Result_Sort_Array = new string[high];

            long[] count_element_x_axis;
            count_element_x_axis = new long[2 * high + 1];

           
            double sum = 0;
            double sum2 = 0;

            long index = 0;
            long index2 = 0;

            double len = 0;
            long offset = 0;

         
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" X-Axis Sorting Algorithm");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Init X Values in Array ");
            for (long i = 0; i < X_Axis.Length; i++)
            {
                X_Axis[i] = "X";
                count_element_x_axis[i] = 0;
            }

           
            for (long i = 0; i < Result_Sort_Array.Length; i++)
            {
                Number_Random_Array[i] = "X";
                Result_Sort_Array[i] = "X";
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Make Random Numbers in Array");
            Random rnd = new Random();
            for (long i = 0; i < Number_Random_Array.Length; i++)
            {
                Number_Random_Array[i] = rnd.Next(-50 /*low*/ , 50 /*high*/).ToString();
                sum += long.Parse(Number_Random_Array[i]);

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            /*
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(" Print Random Numbers of Array");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < Number_Random_Array.Length; i++)
            {
                if (Number_Random_Array[i] == "0")
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Green;


                Console.Write("     {0}", Number_Random_Array[i]);
            }
            */

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine(" Convert Array on the X-Axis");
            Console.WriteLine();
           

            Console.ForegroundColor = ConsoleColor.Green;
           
             len = X_Axis.Length / 2;
             offset = 0;
            for (long i = 0; i < Number_Random_Array.Length; i++)
            {
                
                offset = (long)len - long.Parse(Number_Random_Array[i]);
                X_Axis[offset] = Number_Random_Array[i];
                ++count_element_x_axis[offset];

            }


            Console.WriteLine();
            Console.WriteLine();
            Number_Random_Array = null;
            GC.Collect();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Clear Number_Random_Array of Memory");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine(" Sort Memory LOT Another Array");
            Console.ForegroundColor = ConsoleColor.Green;
            for (long i = X_Axis.Length - 1; i >= 0; i--)
                if (X_Axis[i] != "X")
                {
                    Result_Sort_Array[index] = X_Axis[i];
                    index++;

                }


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();
            X_Axis = null;
            GC.Collect();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Clear X_Axis Array of Memory");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Sort Final Compact Array");
            Console.ForegroundColor = ConsoleColor.Green;
            for (long i = 0; i < Result_Sort_Array.Length; i++)
            {
                if (Result_Sort_Array[i] != "X")
                {
                    sum2 += long.Parse(Result_Sort_Array[i]);
                   // Console.Write("   {0}  ", Result_Sort_Array[i]);
                }
            }



            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("  Left & Right   |    Segma i=0 -> n (Number * Count)           Total Sum = {0}", sum);
            Console.WriteLine();
            Console.WriteLine("  Only Left      |    Segma i=0 -> n (Number)                   Total Sum2 = {0}", sum2);
            Console.WriteLine();
            Console.WriteLine("                 |    Final  Sum - Sum2  =  {0} ", sum - sum2);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine(" Count Elements of Sort Array ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (long i = count_element_x_axis.Length - 1; i >= 0; i--)
                if (count_element_x_axis[i] != 0)
                {
                   
                    if (count_element_x_axis[i] >= 2)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;


                    Console.WriteLine("      Number {0} : Count {1}    ", long.Parse(Result_Sort_Array[index2]), count_element_x_axis[i]);
                    index2++;
                }


            Console.WriteLine();
            Console.WriteLine();
            Result_Sort_Array = null;
            GC.Collect();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Clear Result_Sort_Array of Memory");

            Console.WriteLine();
            Console.WriteLine();
            count_element_x_axis = null;
            GC.Collect();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Clear count_element_x_axis Array of Memory");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" This is the X-Axis sorting algorithm of time order and its memory => ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("O(n)");
           
            Console.ReadKey();
        }
    }

}
