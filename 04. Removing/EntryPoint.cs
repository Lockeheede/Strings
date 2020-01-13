using System;
using System.Collections.Generic;
    class EntryPoint
    {
        static void Main()
        {
        string filePath = @"D:\01_Projects\The Thief And The Muse\0003_UnityVersion\ThiefAndMuse2020Unity\ThiefAndMuse2020Unity.sln";

        string newPath = filePath.Remove(filePath.LastIndexOf("\\") + 1);

        Console.WriteLine(newPath);

        int startIndex = NIndexOf(filePath, @"\", 2) + 1;
        int length = NIndexOf(filePath, @"\", 3) - startIndex + 1;
        string folderExtraction = filePath.Remove(startIndex, length);
        string folderExtractionV2 = Removing(filePath, startIndex, length);

        Console.WriteLine(folderExtractionV2);

        Console.WriteLine(folderExtraction);
        }
    static int NIndexOf(string input, string toFind, int occurence)
    {
        int index = 0;
        int startIndex = 0;

        if (!input.Contains(toFind))
        {
            index = -1;
            return index;
        }

        for (int i = 0; i < occurence; i++)
        {
            index = input.IndexOf(toFind, startIndex);
            startIndex = index + 1;

            if (startIndex > input.Length)
            {
                index = -1;
                return index;
            }
        }

        return index;
    }

    static string Removing(string input, int startIndex, int length)
    {
        string modifiedString = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            if (!(i >= startIndex && i < length + startIndex))
            {
                modifiedString += input[i];
            }
        }

        return modifiedString;
    }
}
