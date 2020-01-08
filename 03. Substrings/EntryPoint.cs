using System;
using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
        //A substring is a part of a string 
        //A substring method is extracting the substring

        string fileDirectory = @"D:\01_Projects\The Thief And The Muse\0004_UnrealVersion\GameplayDemo2.mp4";
        Console.WriteLine(fileDirectory);

        //Challenge, using substrings, set up the extension, fileName, first and secondFolders
        string extension = fileDirectory.Substring(fileDirectory.LastIndexOf('.') + 1);
        string fileName = string.Empty;
        string firstFolder = string.Empty;
        string secondFolder = string.Empty;

        //The first way of doing the method involves creating a substring from whatever index you give it
        //And everything afterwards becomes part of it
        string firstWay = fileDirectory.Substring(40);
        Console.WriteLine(firstWay);

        //The second way (overload) gives you a starting index and a length
        string secondWay = fileDirectory.Substring(0, 15);
        Console.WriteLine(secondWay);

        //You can use an indexOf method to find an index of a specific character
        //This will cut off the length at the selected character. 
        //Add +1 to include the character
        string secondWayV2 = fileDirectory.Substring(0, fileDirectory.IndexOf('f') + 1);
        Console.WriteLine(secondWayV2);

        //You can display the indexed number of the string as well
        //This is also the code to fill the firstFolder
        int startIndex = fileDirectory.IndexOf('0');
        int length = fileDirectory.IndexOf('s') + 1 - startIndex;
        //(Note:) The LastIndexOf gets the last known use of a letter (for multiple iterations of the letter in the string
        firstFolder = fileDirectory.Substring(startIndex, length);
        Console.WriteLine(new string('=', 40));

        Console.WriteLine(firstFolder);

        //Code to fill the extension
        startIndex = fileDirectory.LastIndexOf('.') + 1;
        length = fileDirectory.Length - startIndex;
        extension = fileDirectory.Substring(startIndex, length);

        Console.WriteLine(extension);

        //To fill the filename
        startIndex = fileDirectory.LastIndexOf('\\') + 1;
        length = fileDirectory.LastIndexOf('.') - startIndex;
        fileName = fileDirectory.Substring(startIndex, length);

        Console.WriteLine(fileName);

        //To fill the secondFolder, you must use the IndexOf within itself
        //Check the first line of code: 
        startIndex = NIndexOf(fileDirectory, @"\", 2) + 1;
        length = NIndexOf(fileDirectory, @"\", 3) - startIndex;
        secondFolder = fileDirectory.Substring(startIndex, length);

        Console.WriteLine(secondFolder);

        Console.WriteLine();
    }
    static int NIndexOf(string input, string toFind, int occurence)
    {
        int index = 0;
        int startIndex = 0;

        if(!input.Contains(toFind))
        {
            index = -1;
            return index;
        }
        
            for (int i = 0; i < occurence; i++)
            {
                index = input.IndexOf(toFind, startIndex);
                startIndex = index + 1;

            if(startIndex > input.Length)
            {
                index = -1;
                return index;
            }
            }
        
        return index;
    }
    }
//(Note): The substring method was used in the new version of the splitting strings to create links from the Selenium QA testing links
