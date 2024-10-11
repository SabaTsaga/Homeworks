using System;
using System.Text;

class Program
{
    static void Main()
    {


        /*
        
        //task1
        Console.WriteLine("kalkulatori:");
        Console.WriteLine("Number N1");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Number N2");
        int y = int.Parse(Console.ReadLine());
        string action;
        Console.WriteLine("sheiyvanet operacia. (+) - mimateba, (-) - gamokleba, (*) - gamravleba, (/) - gayofa");
        action = Console.ReadLine();
        int result;

        if(action == "+")
        {
            result = x + y;
            Console.WriteLine(result);
        }
        else if(action == "-")
        {
            result = x - y;
            Console.WriteLine(result);
        }
        else if(action == "*")
        {
            result = x * y;
            Console.WriteLine(result);
        }
        else if (action == "/" )
        {
            if (y != 0)
            {
                result = x / y;
                int remainder = x % y;
                Console.WriteLine("mteli: " + result);
                Console.WriteLine("nashti: " + remainder);
            }
            else
            {
                Console.WriteLine("ar sheidzleba nulze gayofa.");
            }
        }
        else
        {
            Console.WriteLine("araswori aritmetikuli operacia");
        }








        //task2

        //cvladebi float, double, and decimal is typebi
        float floatValue = 1.0f / 7.0f;     
        double doubleValue = 1.0 / 7.0;     
        decimal decimalValue = 1.0m / 7.0m;  

        //titoeuli cvladi 7ze gavamravlot 
        float floatResult = floatValue * 7;
        double doubleResult = doubleValue * 7;
        decimal decimalResult = decimalValue * 7;

        Console.WriteLine("Float Result: " + floatResult);
        Console.WriteLine("Double Result: " + doubleResult);
        Console.WriteLine("Decimal Result: " + decimalResult);

        //shedegis shedareba:
        Console.WriteLine("\nComparison:");
        Console.WriteLine($"Float precision: {floatValue}, Float result: {floatResult}");
        Console.WriteLine($"Double precision: {doubleValue}, Double result: {doubleResult}");
        Console.WriteLine($"Decimal precision: {decimalValue}, Decimal result: {decimalResult}");


        //task 3
        //cvladebis gamocxadeba da matze mnishvnelobis minicheba
        int intValue = 10;                   
        double doubleValue1 = 15.75;           
        float floatValue1 = 20.5f;             
        decimal decimalValue1 = 100.25m;      

        //  impplicit konversiebi  ----
        // int -> double
        double implicitDouble = intValue;
        Console.WriteLine("Implicit Conversion (int to double): " + implicitDouble);

        // float -> double
        double implicitFloatToDouble = floatValue1;
        Console.WriteLine("Implicit Conversion (float to double): " + implicitFloatToDouble);

        // explicit konversiebi
        // double -> int 
        int explicitInt = (int)doubleValue1;
        Console.WriteLine("Explicit Conversion (double to int): " + explicitInt);

        //decimal -> float 
        float explicitFloat = (float)decimalValue1;
        Console.WriteLine("Explicit Conversion (decimal to float): " + explicitFloat);

        //int -> decimal
        decimal implicitDecimal = intValue;
        Console.WriteLine("Implicit Conversion (int to decimal): " + implicitDecimal);

        // pirdapiri konversia 
        // double -> decimal
        decimal explicitDecimal = (decimal)doubleValue;
        Console.WriteLine("Explicit Conversion (double to decimal): " + explicitDecimal);
        */


        //task 4
        int k = 5;
        int b = 10;

        Console.WriteLine("Before swapping:");
        Console.WriteLine("k = " + k);
        Console.WriteLine("b = " + b);

        k = k + b;
        b = k - b;
        k = k - b;

        //cvlilebis shemdeg:
        Console.WriteLine("\nAfter swapping:");
        Console.WriteLine("k = " + k);
        Console.WriteLine("b = " + b);

        /*
        //task 5
        Console.WriteLine("mogesalmebit BMI calculatorshi");
        Console.WriteLine("Gtxovt sheiyvanot tkveni wona KG-ebshi");
        int weight = int.Parse(Console.ReadLine());
        Console.WriteLine("Gtxovt sheiyvanot simagle m-ebshi");
        double height = double.Parse(Console.ReadLine());

        double result1 = weight / (height * height);

        if (result1 <= 18)
        {
            Console.WriteLine("Tkven gakvt naklebi cximovani masa,umjobesia meti kaloriebi miigot");
        }
        else if (result1 > 18 && result1 <= 25)
        {
            Console.WriteLine("tqven gaqvt sashualo cximovani masa, rac nishnavs rom tanafardoba simaglis da wonis idealurad gaqvt");
        }
        else if (result1 > 25 && result1 <= 35)
        {
            Console.WriteLine("tqven gaqvt sashualoze meti cximovani masa, shesabamisad umjoebisa naklebi kaloria miigot dgiurad");
        }
        else if (result1 > 35)
        {
            Console.WriteLine("tqven gaqvt magali cximovani masa, shesabamisad aucilebelia naklebi kaloriis migeba dgiurad tqveni janmrtelobistvis");
        }
        else
        {
            Console.WriteLine("Tkven arasworad sheiyvanet wonis an simaglis monacemebi");
        }

        */
    }

}


