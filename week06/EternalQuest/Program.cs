using System;
using System.Collections;
using System.Formats.Asn1;
using System.Net.Http.Json;
using System.Xml.Serialization;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager g = ImportFromFile();
        Console.WriteLine("Welcome to the Goal Program!");
        bool running = true;
        while (running)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Add a new goal");
            Console.WriteLine("2) Record an Event (Goal completed?)");
            Console.WriteLine("3) Display current score");
            Console.WriteLine("4) List current goals");
            Console.WriteLine("5) Save and Quit your progress.");

            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    g.CreateGoal();
                    break;
                case "2":
                    g.RecordEvent();
                    break;
                case "3":
                    g.ShowPoints();
                    break;
                case "4":
                    g.ListGoalDetails();
                    break;
                case "5":
                    running = false;
                    break;
            }
        }
        ExportToFile(g);
    }
    
    static void ExportToFile(GoalManager manager){
    try
    {
        var settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        };

        string json = JsonConvert.SerializeObject(manager, settings);
        File.WriteAllText("GoalManager.json", json);
        Console.Write("File was exported to GoalManager.json. Press enter to exit\n");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Export failed: {ex.Message}");
    }
        Console.ReadLine();
    }

    static GoalManager ImportFromFile()
    {
        try
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };

            string jsonIn = File.ReadAllText("GoalManager.json");
            
            Console.Write("File was imported from GoalManager.json!\n");
            return JsonConvert.DeserializeObject<GoalManager>(jsonIn, settings);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error importing file, making new GoalManager: {ex.Message}.\n");
            return new GoalManager();
        }
    }
}