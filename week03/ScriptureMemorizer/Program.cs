using System;
using System.Collections;
using System.Xml.Serialization;
using Newtonsoft.Json;

class Program
{
    static List<Reference> _mastery = new List<Reference>();

    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu(){
        bool running = true;
        Console.Clear();
        Console.WriteLine("-- Welcome to Scripture Mastery Program -- \n");
        while(running){
            Console.WriteLine("What would you like to do?: \n");
            Console.WriteLine("1. Add a New Reference\n");
            Console.WriteLine("2. View a Reference to Practice\n");
            Console.WriteLine("3. Hide Words in a Reference\n");
            Console.WriteLine("4. Reset Hidden Words in a Reference\n");
            Console.WriteLine("5. Export References to a File\n");
            Console.WriteLine("6. Load References From a File\n");
            Console.WriteLine("7. Exit Program\n");
            Console.Write("Please select an Option: \n");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddReference();
                    break;
                case "2":
                    ViewReference();
                    break;
                case "3":
                    HideReference();
                    break;
                case "4":
                    ResetHidden();
                    break;
                case "5":
                    ExportToFile();
                    break;
                case "6":
                    ImportFromFile();
                    break;
                case "7":
                    running = false;
                    break;
            }
            Console.Clear();
        }
    }

    static void AddReference(){
        try{
            Console.Write("What Book is this reference in?\n");
            string book = Console.ReadLine();
            Console.Write("What Chapter is this reference in?\n");
            int chapter = int.Parse(Console.ReadLine());
            List<Scripture> verses = new List<Scripture>();
            Console.Write("FYI: You can add multiple verses in a reference.\n");
            while(true){
                Console.Write("What is the verse Number? If there are no more to add, enter 0.\n");
                int versenum = int.Parse(Console.ReadLine());
                if(versenum == 0){
                    break;
                }
                Console.Write("What is the text of this verse? \n");
                string verseContent = Console.ReadLine();
                Scripture newVerse = new Scripture(versenum);
                newVerse.SetScripture(verseContent);
                verses.Add(newVerse);
            }
            Reference newReference = new Reference(verses, book, chapter);
            _mastery.Add(newReference);
            Console.Write($"{newReference.GetReferenceName()} has been added! Press enter to continue\n");
            Console.ReadLine();
        }
        catch{
            Console.WriteLine("Error. Please enter a correct response! Press enter to Retry.\n");
            Console.ReadLine();
        }
    }
    static void ListAllReferences(){
        for(int i = 0; i < _mastery.Count; i++){
            Console.WriteLine($"{i+1}: {_mastery[i].GetReferenceName()}");
        }
    }
    //This method shows the reference choses to the user, then waits for them to continue to then clear the screen.
    static void ViewReference(){
        Console.WriteLine("Which Reference would you like to view? \n");
        ListAllReferences();
        Console.Write("");
        string strchoice = Console.ReadLine();
        try{
            Console.Clear();
            int choice = int.Parse(strchoice) - 1;
            _mastery[choice].GetDisplayText();
            Console.Write("\n Press enter when done viewing. \n");
            Console.ReadLine();
        }
        catch{
            Console.WriteLine("You must enter a valid number Press enter to retry.\n");
            Console.ReadLine();
        }
    }

    static void ExportToFile(){
        string json = JsonConvert.SerializeObject(_mastery);
        File.WriteAllText("masteryexport.json", json);   
        Console.Write("File was exported to masteryexport.json. Press enter to continue\n");
        Console.ReadLine();
    }

    static void ImportFromFile(){
        try {
            string jsonIn = File.ReadAllText("masteryexport.json");
            Console.Write("File was imported from masteryexport.json! Press enter to continue\n");
            Console.ReadLine();
            _mastery = JsonConvert.DeserializeObject<List<Reference>>(jsonIn);
        } catch (Exception ex) {
            Console.WriteLine($"Error importing file: {ex.Message}. Press enter to continue.\n");
            Console.ReadLine();
        }
    }

    static void HideReference(){
        Console.WriteLine("Which Reference would you like to hide words in?\n");
        ListAllReferences();
        Console.Write("");
        string strchoice = Console.ReadLine();
        try{
            int choice = int.Parse(strchoice) - 1;
            _mastery[choice].GetDisplayText();
            Console.Write("\n Above is the reference. How many words PER VERSE would you like to hide?\n");
            int numWords = int.Parse(Console.ReadLine());
            _mastery[choice].RandomizeHiddenWords(numWords);
            Console.Write($"Words in {_mastery[choice].GetReferenceName()} have been hidden. Press enter to continue\n");
            Console.ReadLine();
        }
        catch{
            Console.WriteLine("You must enter a valid number! Press enter to retry.\n");
            Console.ReadLine();
        }
    }

    static void ResetHidden(){
        Console.WriteLine("Which Reference would you like to reset the hidden words in?\n");
        ListAllReferences();
        Console.Write("");
        string strchoice = Console.ReadLine();
        try{
            int choice = int.Parse(strchoice) - 1;
            _mastery[choice].ResetHiddenWords();
            Console.Write($"Hidden words in {_mastery[choice].GetReferenceName()} have been reset. Press enter to continue\n");
            Console.ReadLine();
        }
        catch{
            Console.WriteLine("You must enter a valid number! Press enter to retry.\n");
            Console.ReadLine();
        }
    }

}