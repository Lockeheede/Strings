using System;
using System.Text;

    class EntryPoint
    {
        static void Main()
        {
        //Use DateTime.Now to determine a start and end point between operations
        DateTime start = DateTime.Now;
        string TestOne = Concatenator('a', 1000);
        DateTime end = DateTime.Now;

        Console.WriteLine(end - start);

        //StringBuilder Method (see below). Make sure to use StringBuilder data type and to include System.Text
        DateTime startTwo = DateTime.Now;
        StringBuilder TestTwo = ConcatenatorSB('a', 1000000);//SB is faster than normal concatenation. 
        DateTime endTwo = DateTime.Now;

        Console.WriteLine(endTwo - startTwo);

        string TestThree = TestTwo.ToString(); //SB can be converted to a string with no problem
    }

        static string Concatenator(char characterToConcatenate, int count)
        {
        string concatenatedString = string.Empty;

        for (int i = 0; i < count; i++)
        {
            concatenatedString += characterToConcatenate;
        }
        return concatenatedString;
        }

        static StringBuilder ConcatenatorSB(char characterToConcatenate, int count)
        {
        StringBuilder concatenatedString = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            concatenatedString.Append(characterToConcatenate);
        }

        return concatenatedString;
        }
    }

