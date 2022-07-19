//using System;
/*
class ArrayTotalAvg
{
    static void Main(string[] args)
    {
        int[] kor = new int[3];
        int sum = 0;
        float avg = 0;

        kor[0] = 100;
        kor[1] = 90;
        kor[2] = 80;

        sum = kor[0] + kor[1] + kor[2];
        avg = (kor[0] + kor[1] + kor[2]) / (float)kor.Length;

        Console.WriteLine($"합계 : {sum} , 평균 : {avg:0.00}");

        int[] students = new int[3];
        int total = 0;
        for (int i = 0; i < students.Length; i++)
        {
            students[i] = Convert.ToInt32(Console.ReadLine()); 
            total = total + students[i];
        }
        Console.WriteLine($"총 합계 : {total}");
    }
}
*/

/*
class ArratTwo2
{
    static void Main(string[] args)
    {
        int[,] intArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        for (int i = 0; i < intArray.GetLength(0); i++)
        {
            for(int j = 0; j < intArray.GetLength(1); j++)
            {
                Console.Write($"{intArray[i,j]}\t");
            }
            Console.WriteLine();
        }

        int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.WriteLine($"arr[{i},{j}] = {arr[i,j]}");
            }
        }
    }
}
*/

/*
class ArrayThree
{
    static void Main(string[] args)
    {
        int[,,] iArray = {
                                { { 1, 2, 3, 4 }, { 5,6,7,8}, { 9, 10, 11, 12 } },
                                {{13,14,15,16 },{17,18,19,20 },{21,22,23,24 } }
                        };

        for (int i = 0; i < iArray.GetLength(0); i++)
        {
            for(int j = 0; j < iArray.GetLength(1); j++)
            {
                for(int k = 0; k < iArray.GetLength(2); k++)
                {
                    Console.Write("{0,2}\t", iArray[i,j,k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
                    
    }
}
*/

//Study_19
using System;
