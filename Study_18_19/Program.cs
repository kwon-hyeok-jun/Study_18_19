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


/*
class ReturnValue
{
    static string GetString()
    {
        return "반환값(Return Value)";
    }

    static void Main()
    {
        string returnValue = GetString();
        Console.WriteLine(returnValue);
    }
}
*/

/*
class FunctionReturnValue
{
    static int SquareFunction(int x)
    {
        return x * x;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(SquareFunction(2));
    }
}
*/

/*
class FunctionAddNumbers
{
    /// <summary>
    /// 두 수를 더하여 그 결괏값을 반환시켜 주는 함수
    /// </summary>
    /// <param name="a">첫 번째 매개변수</param>
    /// <param name="b">두 번째 매개변수</param>
    /// <returns>a + b 결과</returns>
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        int a = 3;
        int b = 5;
        int c = AddNumbers(3, 5);
        Console.WriteLine($"{a} + {b} = {c} ");
    }
}
*/

/*
class NamedParameter
{
    static void Main()
    {
        Sum(10, 20);
        Sum(first: 10, second: 20);
        Sum(second: 10, first: 20);

    }

    static void Sum(int first, int second)
    {
        Console.WriteLine(first - second);
    }
}
*/

/*
class FunctionOverload
{
    static void Main()
    {
        Multi();
        Multi("반갑습니다.");
        Multi("잘지내", 3);
    }

    static void Multi()
    {
        Console.WriteLine("안녕하세요.");
    }

    static void Multi(string message)
    {
        Console.WriteLine(message);
    }

    static void Multi(string message, int count)
    {
        for(int i = 0; i < count; i++)
        {
            Console.WriteLine("{0}", message);
        }
    }
}
*/

class CommandLineArgument
{
    static void Main(string[] args)
    {
        foreach(string arg in args)
        {
            Console.WriteLine(arg);
        }    
    }
}