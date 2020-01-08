using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;

class EntryPoint
    {
        static void Main()
        {
        char[] charactersToSplitBy = {',',' '};
        string characters = "TheThief TheMuse TheRat TheSage TheTroll TheMoney TheCoder ThePresident " +
            "TheLame TheHustler TheChain TheMusic";
        string creatures = "TangTangila, Flaunchy, Hemogoblin, FlyingRat, DirtyDog, BlueSnake";
        
        string[] splitCharacters = characters.Split(' ');//The split command seperates the information by a character
        string[] splitCreatures = creatures.Split(charactersToSplitBy, StringSplitOptions.RemoveEmptyEntries);
       

        foreach (var creature in splitCreatures)
        {
            Console.WriteLine(creature);
        }

        //Remember to install the selenium webdriver and selenium webdriver chromedriver to use the following:
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://testing.todvachev.com/sitemap-posttype-post.xml");

        string[] pageSource = driver.PageSource.Split('>');

        foreach (var line in pageSource)
        {
            Console.WriteLine(line);
        }

        int startIndex = 0;
        int length = 0;
        List<string> links = new List<string>();

        foreach (var link in pageSource)
        {
            if (link.Contains(@"""http://testing.todvachev.com"))
            {
                startIndex = link.IndexOf('"') + 1;
                length = link.LastIndexOf('"') - startIndex;
                links.Add(link.Substring(startIndex, length));
            
            }
        }

        foreach (var link in links)
        {
            Console.WriteLine(link);

        }
        }
    }

