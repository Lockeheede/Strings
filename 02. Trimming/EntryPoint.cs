using System;
using System.Collections.Generic;

class EntryPoint
    {
        static void Main()
        {
        string name = "  PJ  ";
        ///To trim both spaces try:
        ///name = name.Trim();

        string name2 = "  blahblargJaime  ";

        //You can trim the start of spaces
        name = name.TrimStart();
        //Or the end of spaces with name = name.TrimEnd();

        //You can trim seperate characters of the name with the new char[] { } function
        name2 = name2.Trim(new char[] { ' ', 'b', 'l', 'a', 'h', 'r', 'g'} );


        //In order to go through each character of a string, you would need to use a nested loop
        //One that uses a character array to loop in the inner portion while the string itself is the outer loop 

        string stringToTrim = "abcPrescottabc";
       
        char[] charactersToRemove = { 'a', 'b', 'c' };

        stringToTrim = Trimming(stringToTrim, charactersToRemove);
        
        Console.WriteLine(stringToTrim);
      
        }
    static string Trimming(string stringToTrim, char[] charactersToRemove)
    {
        string trimmedString = string.Empty;
        List<int> indexesToSkip = new List<int>();
        int counter = 0;

        for (int i = 0; i < stringToTrim.Length; i++)
        {
            for (int j = 0; j < charactersToRemove.Length; j++)
            {
                if (stringToTrim[i] == charactersToRemove[j])
                {
                    indexesToSkip.Add(i);
                    break;
                }
                else
                {
                    counter++;
                }
            }
            if (counter == charactersToRemove.Length)
            {
                break;
            }
            counter = 0;
        }
        //The code above takes care of the first part of the string
        //The code below takes care of the second part of the string
        for (int i = stringToTrim.Length - 1; i >= 0; i--)
        {
            for (int j = 0; j < charactersToRemove.Length; j++)
            {
                if (stringToTrim[i] == charactersToRemove[j])
                {
                    indexesToSkip.Add(i);
                    break;
                }
                else
                {
                    counter++;
                }
            }
            if (counter == charactersToRemove.Length)
            {
                break;
            }
            counter = 0;
        }
        Console.WriteLine(stringToTrim);
        Console.WriteLine(string.Join(",", indexesToSkip));

        for (int i = 0; i < stringToTrim.Length; i++)
        {
            if (indexesToSkip.Contains(i))
            {
                trimmedString += stringToTrim[i];
            }

        }

        return trimmedString;
    }
    }

