using System;
using System.Collections;
using System.Formats.Asn1;
using System.Xml.Serialization;
using Newtonsoft.Json;

//Dallen Harmon
//CSE210

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
        ImportFromFile();
        Console.WriteLine("-- Welcome to Scripture Mastery Program -- \n");
        while(running){
            Console.WriteLine("What would you like to do?: \n");
            Console.WriteLine("1. Add a New Reference\n");
            Console.WriteLine("2. View a Reference to Practice!\n");
            Console.WriteLine("3. View a Random number of hidden words in a Reference\n");
            Console.WriteLine("6. Exit Program and Save References to File\n");
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
                    ExportToFile();
                    break;
                case "5":
                    ImportFromFile();
                    break;
                case "6":
                    running = false;
                    break;
            }
            
            Console.Clear();
        }
        ExportToFile();
    }

    //Adds a reference to the main list of references stored in memory
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
            int wordcount = 0;
            int choice = int.Parse(strchoice) - 1;
            bool isFullyHidden = false;
            ResetHidden(choice);
            while (isFullyHidden == false){
                Console.Clear();
                _mastery[choice].GetDisplayText();
                Console.Write("\n Press enter to remove some words.\n");
                Console.ReadLine();
                ResetHidden(choice);
                wordcount++;
                isFullyHidden = _mastery[choice].RandomizeHiddenWords(wordcount);
            }
            Console.Clear();
            _mastery[choice].GetDisplayText();
            Console.Write("\n The word is now fully hidden! Press enter to go back.\n");
            Console.ReadLine();
        }
        catch{
            Console.WriteLine("You must enter a valid number Press enter to retry.\n");
            Console.ReadLine();
        }
    }
    
    //Exports the stored References in a json file, so it can be imported in later. 
    static void ExportToFile(){
        string json = JsonConvert.SerializeObject(_mastery);
        File.WriteAllText("masteryexport.json", json);   
        Console.Write("File was exported to masteryexport.json. Press enter to exit\n");
        Console.ReadLine();
    }

    //Imports the json file with the stored references, if it is there. 
    static void ImportFromFile(){
        try {
            string jsonIn = File.ReadAllText("masteryexport.json");
            Console.Write("File was imported from masteryexport.json!\n");
            _mastery = JsonConvert.DeserializeObject<List<Reference>>(jsonIn);
        } catch (Exception ex) {
            Console.WriteLine($"Error importing file: {ex.Message}.\n");
        }
    }

    //Will hide a certain amount of words in a reference dependent on the users request
    static void HideReference(){
        Console.WriteLine("Which Reference would you like to hide words in?\n");
        ListAllReferences();
        Console.Write("");
        string strchoice = Console.ReadLine();
        try{
            int choice = int.Parse(strchoice) - 1;
            ResetHidden(choice);
            _mastery[choice].GetDisplayText();
            Console.Write("\n Above is the reference. How many words PER VERSE would you like to hide?\n");
            int numWords = int.Parse(Console.ReadLine());
            ResetHidden(choice);
            _mastery[choice].RandomizeHiddenWords(numWords);
            Console.Clear();
            _mastery[choice].GetDisplayText();
            Console.Write($"\n\nPress enter to continue\n");
            Console.ReadLine();
        }
        catch{
            Console.WriteLine("You must enter a valid number! Press enter to retry.\n");
            Console.ReadLine();
        }
    }

    //Resets all the hidden words in a reference
    static void ResetHidden(int choice){
        _mastery[choice].ResetHiddenWords();
    }

}