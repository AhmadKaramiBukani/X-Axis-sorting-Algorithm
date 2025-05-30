//////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////
//////      CopyRight: Ahmad Karmi Bukani     احمد کرمی بوکانی    //////
//////          Rojhalat Kurdistan  2025          روژهلات کوردستان     ///////
///////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;

namespace XAxisBigDataNumbers
{

    class Program
    {
        static void Main(string[] args)
        {
            long high = 499999000;
            long max = 500000000;

           
            //  long high = 20;
            //  long max = 200;

            float[] Number_Random_Array;
            Number_Random_Array = new float[high];

            float[] X_Axis;
            X_Axis = new float[max];

            float[] Result_Sort_Array;
            Result_Sort_Array = new float[high];

            float[] count_element_x_axis;
            count_element_x_axis = new float[max];


            double sum = 0;
            double sum2 = 0;

            long index = 0;
            long index2 = 0;

            float len = 0;
            long offset = 0;

            long Zero = 0;
            long CountZero = 0;
            int signNumber = 0;
            bool Once = true;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" X-Axis Sorting Algorithm");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(" Make a Random Number Array");
            Random rnd = new Random();
            for (long i = 0; i < Number_Random_Array.Length; i++)
            {
                Number_Random_Array[i] = rnd.Next(-10, 10);

                if (Number_Random_Array[i] == 0)
                    Zero++;
                else
                sum += Number_Random_Array[i];

            }

            /*
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine(" Print A Random Number Array");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;

           
            for (long i = 0; i < Number_Random_Array.Length; i++)
            {
              
                    Console.Write("    {0}    ", Number_Random_Array[i]);
            }
             
             */

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine(" Convert Array on the X-Axis");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            len = X_Axis.Length / 2;
          
            for (long i = 0; i < Number_Random_Array.Length; i++)
            {
          
                offset = (long)len - (long)Number_Random_Array[i];
                X_Axis[offset] = Number_Random_Array[i];
                ++count_element_x_axis[offset];

            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();
            Number_Random_Array = null;
            GC.Collect();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Clear Number_Random_Array of Memory");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(" Sort Memory LOT Another Array");
            Console.ForegroundColor = ConsoleColor.Green;

            for (long i = X_Axis.Length - 1;i>=0 ; i--)  
            {
                if (X_Axis[i] != 0)
                {
              //      Console.Write(" {0} ", X_Axis[i]);
                    Result_Sort_Array[index] = X_Axis[i];
                    index++;
                }
                else
                {
                    if (CountZero < Zero)
                    {
                    //    Console.Write(" {0} ", X_Axis[i]);
                        Result_Sort_Array[index] = X_Axis[i];
                        CountZero++;
                    }
                    
                }
                   


            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();
            X_Axis = null;
            GC.Collect();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Clear X_Axis Array of Memory");
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(" Sort Final Compact Array");
            Console.ForegroundColor = ConsoleColor.Green;

            CountZero = 0;
            for (long i = 0; i < Result_Sort_Array.Length; i++) 
            {
                /*
                if (Once)
                {
                    signNumber = Math.Sign(Result_Sort_Array[i]);

                    if (signNumber == 1 && Zero >= 1)
                    {
                        Console.Write("    0    ");
                        Once = false;
                    }

                }
                 */

                if (Result_Sort_Array[i] != 0)
                {
                    sum2 += Result_Sort_Array[i];
                 //   Console.Write(" {0} ", Result_Sort_Array[i]);
                }
                              

            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("  sum = {0}       sum2 = {1}       sum-sum2 = {2}", sum, sum2, Math.Abs(sum - sum2));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine(" Count Elements of Sort Array ");
            Console.ForegroundColor = ConsoleColor.Green;
            Once = true;
            for (long i = count_element_x_axis.Length - 1; i >= 0; i--) 
            {

                if (Once)
                {
                    signNumber = Math.Sign(Result_Sort_Array[index2]);

                    if (signNumber == 1 && Zero >= 1)
                    {
                        Console.WriteLine(" Number 0 : Count {0}    ", Zero);
                        Once = false;
                    }

                }



                if (count_element_x_axis[i] != 0 && Result_Sort_Array[index2]!=0)
                {

                    if (count_element_x_axis[i] >= 2)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine(" Number {0} : Count {1}    ", Result_Sort_Array[index2], count_element_x_axis[i]);
                    index2++;
                }

               
            }

           

            Console.WriteLine();
            Result_Sort_Array = null;
            GC.Collect();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Clear Result_Sort_Array of Memory");
            Console.WriteLine();
            Console.WriteLine();
            count_element_x_axis = null;
            GC.Collect();
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
