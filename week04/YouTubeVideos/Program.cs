using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to make a Cake", "HowToBasic", 300);
        video1.AddComment("User32", "What an informational video!");
        video1.AddComment("NileBlue", "I didnt know this was possible. Thank you");
        video1.AddComment("Scott", "What an unconventional way to bake a cake.");

        Video video2 = new Video("Todays Daily News!", "TrustworthyNews", 450);
        video2.AddComment("NewsExpert", "I sure do love the news");
        video2.AddComment("AverageGuy", "I didnt understand a word this guy said. 0 stars");
        video2.AddComment("Aging Wheels", "Hey look mom Im on the news!");
        video2.AddComment("OldMan85", "News today aint the same");

        Video video3 = new Video("Cooking with Fire!", "SpicyChef", 315);
        video3.AddComment("MomOf3", "Trying this tonight for dinner!");
        video3.AddComment("BurntToast", "I tried this and now my kitchen is on fire...");
        video3.AddComment("ChefRamsey", "Where's the lamb sauce?!");

        Video video4 = new Video("The Ultimate Cat Compilation", "PawsAndWhiskers", 202);
        video4.AddComment("CatLady99", "I watched this 10 times. Still not enough.");
        video4.AddComment("MrMeow", "I approve this as a cat");
        video4.AddComment("SleepySam", "Better than therapy.");
        video4.AddComment("GrumpyCatFan", "Not enough grumpiness, 3/10.");


        Console.WriteLine($"{video1.GetTitle()} by {video1.GetAuthor()}. Length of {video1.GetNiceLength()}. {video1.GetCommentCount()} comments.");
        video1.ListComments();
        Console.WriteLine();

        Console.WriteLine($"{video2.GetTitle()} by {video2.GetAuthor()}. Length of {video2.GetNiceLength()}. {video2.GetCommentCount()} comments.");
        video2.ListComments();
        Console.WriteLine();

        Console.WriteLine($"{video3.GetTitle()} by {video3.GetAuthor()}. Length of {video3.GetNiceLength()}. {video3.GetCommentCount()} comments.");
        video3.ListComments();
        Console.WriteLine();

        Console.WriteLine($"{video4.GetTitle()} by {video4.GetAuthor()}. Length of {video4.GetNiceLength()}. {video4.GetCommentCount()} comments.");
        video4.ListComments();
        Console.WriteLine();

    }
}