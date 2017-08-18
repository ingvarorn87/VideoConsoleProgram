﻿using System;
using System.Collections.Generic;
using VideoConsoleProgram;
using static System.Console;


public class MainClass

{

    static List<Video> videos = new List<Video>();
    private static int id = 1;



    public static void Main()
    {

        Video vid1 = new Video()
        {
            Genre = "Horror",
            Year = 1977,
            VideoName = "Cujo",
            Id = id++
        };
        
        videos.Add(vid1);
       
        char choice;

        for (;;)
        {
            do
            {

                WriteLine("------------------------------\n");
                WriteLine(" Video Menu \n");
                WriteLine("Choose one (q to quit):\n ");



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

                    ListVideos();

                    break;
                case '2':


                    CreateVideo();

                    break;
                case '3':
                    WriteLine("This will edit a Video");
                    break;
                case '4':
                    WriteLine("This will search for Videos");
                    break;
                case '5':
                    DeleteVideo();
                    break;

            }

        }
    }

    private static void DeleteVideo()
    {
        Clear();
        //WriteLine("Enter a Video Id: ");
        int id;
        while (!int.TryParse(ReadLine(), out id))
        {
            WriteLine("Please insert a Id");
        }

        Video videoFound;

        foreach (var Video in videos)
        {
            if (Video.Id == id)      
            {
                WriteLine(Video.VideoName);
            }
        }


    }

    private static void CreateVideo()
    {
        Clear();
        WriteLine("Input Name of Video: ");
        //The first ReadLine is skipped because I'm using Console.Read for a Char as my menu choice. Line 82.
        ReadLine();
        string vName = ReadLine(); 
        WriteLine("Input Genre of Video: ");
        var vGenre = ReadLine();
        WriteLine("Input Year of Video: ");
        int vYear = Convert.ToInt32(ReadLine());


        videos.Add(new Video() {
            VideoName = vName,
            Genre = vGenre,
            Year = vYear,
            Id = id++

        });
    }

    private static void ListVideos()
    {
        Console.Clear();
        WriteLine("List of Videos");
        foreach (var Video in videos)
        {
            WriteLine($"Name: {Video.VideoName}   Genre: {Video.Genre}   Year: {Video.Year}   Id:{Video.Id}");
        }
        WriteLine("");
    }
}