using System;
using System.Collections.Generic;
using static System.Console;


public class MainClass
{
    public static void Main()
    {
        char choice;

        for (;;)
        {
            do
            {

                WriteLine("------------------------------");
                WriteLine();
                WriteLine(" Video Menu ");
                WriteLine();
                WriteLine("Choose one (q to quit): ");
                WriteLine();


                string[] menuItems =
                {
                    "Show all Videos",
                    "Create a Video",
                    "Edit a Video",
                    "Search Videos",
                    "Delete a Video"
                };

                for (int i = 0; i < menuItems.Length; i++)
                {
                    WriteLine((i + 1) + ": " + menuItems[i]);
                }


                do
                {
                    choice = (char)Read();
                }
                while (choice == '\n' | choice == '\r');
            }
            while (choice < '1' | choice > '5' & choice != 'q');

            if (choice == 'q')
            {
                break;
            }


            WriteLine("\n");

            switch (choice)
            {
                case '1':

                    List<string> videos = new List<string>()
                    {
                            "The Ring",
                            "The Shining",
                            "I Kina spise de hunde",
                            "Frozen"

                    };
                    var i = 0;
                    while (i < videos.Count)
                    {
                        WriteLine((i + 1) + ". " + videos[i]);
                        i++;
                    }

                    break;
                case '2':
                    WriteLine("This will Create a Video");
                    break;
                case '3':
                    WriteLine("This will edit a Video");
                    break;
                case '4':
                    WriteLine("This will search for Videos");
                    break;
                case '5':
                    WriteLine("This will delete a Video");
                    break;

            }

        }
    }
}