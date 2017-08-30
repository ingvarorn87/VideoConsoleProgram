using System;
using System.Collections.Generic;
using VideoConsoleBLL;
using VideoConsoleProgram;
using static System.Console;


public class MainClass

{
    static BLLFacade bllFacade = new BLLFacade();

    public static void Main()
    {

        Video vid1 = new Video()
        {
            Genre = "Horror",
            Year = 1977,
            VideoName = "Cujo",
            
        };
        Video vid2 = new Video()
        {
            Genre = "Thriller",
            Year = 1996,
            VideoName = "Jurassic Park",
         
        };

        bllFacade.VideoService.Create(vid1);
        bllFacade.VideoService.Create(vid2);

        char choice;

        for (;;)
        {
            do
            {

                string[] menuItems =
                {
                    "Show all Videos",
                    "Create a Video",
                    "Edit a Video",
                    "Search Videos",
                    "Delete a Video",
                    "Add Videos"
                };

                WriteLine("------------------------------\n");
                WriteLine(" Video Menu \n");
                WriteLine("Choose one (q to quit):\n ");

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
            while (choice < '1' | choice > '6' & choice != 'q');

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
                    EditVideo();
                    break;
                case '4':
                    FindVideoById();
                    break;
                case '5':
                    DeleteVideo();
                    break;
                case '6':
                    CreateManyVideos();
                    break;

            }

        }
    }

    private static void CreateManyVideos()
    {
        Clear();
        WriteLine("Add Videos");

         bool GetYorN()
        {
            ConsoleKey response; 

            do
            {
                while (Console.KeyAvailable) 
                    Console.ReadKey();

                Console.Write("Y or N? "); 
                response = Console.ReadKey().Key; 
                Console.WriteLine(); 
            } while (response != ConsoleKey.Y && response != ConsoleKey.N);

            
            return response == ConsoleKey.Y;
        }

        GetYorN();

    }

    private static void EditVideo()
    {
        Clear();
        var Video = FindVideoById();
        if (Video != null)
        {
            WriteLine("Input Name of Video: ");
            Video.VideoName = ReadLine();
            WriteLine("Input Genre of Video: ");
            Video.Genre = ReadLine();
            WriteLine("Input Year of Video: ");
            Video.Year = Convert.ToInt32(ReadLine());
            bllFacade.VideoService.Update(Video);
        }
       else
        {
            WriteLine("Video not Found");
            WriteLine("");
        }
  
    }

    private static void DeleteVideo()
    {

        var videoFound = FindVideoById();
        if (videoFound != null)
        {
            bllFacade.VideoService.Delete(videoFound.Id);
        }
        
        var delResponse = videoFound == null ?
            "Video not Found" : $"Video {"" + videoFound.VideoName } was deleted";
        WriteLine(delResponse);


    }

    private static void CreateVideo()
    {
        Clear();
        WriteLine("Input Name of Video: ");
        ReadLine();
        string vName = ReadLine(); 
        WriteLine("Input Genre of Video: ");
        var vGenre = ReadLine();
        WriteLine("Input Year of Video: ");
        int vYear = Convert.ToInt32(ReadLine());


       bllFacade.VideoService.Create(new Video() {

       VideoName = vName,
       Genre = vGenre,
       Year = vYear,
     

       });
    }

    private static void ListVideos()
    {
        Console.Clear();
        WriteLine("List of Videos");
        foreach (var Video in bllFacade.VideoService.GetAll())
        {
            WriteLine($" Id:{Video.Id}  Year: {Video.Year}  Name: {Video.VideoName}   Genre: {Video.Genre} ");
        }
        WriteLine("");
    }

    private static Video FindVideoById()
    {
        Clear();
        int id;
        while (!int.TryParse(ReadLine(), out id))
        {
            WriteLine("Please insert a Id");
        }

        

       
        return bllFacade.VideoService.Get(id);
        WriteLine("");
    }
}