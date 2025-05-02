using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._title = "Retail Associate";
        job1._company = "Walmart";
        job1._startyear = 2014;
        job1._endyear = 2016;

        Job job2 = new Job();
        job2._title = "IT Technician";
        job2._company = "Apple";
        job2._startyear = 2016;
        job2._endyear = 2018;

        Job job3 = new Job();
        job3._title = "Software Developer";
        job3._company = "Amazon";
        job3._startyear = 2018;
        job3._endyear = 2020;

        Resume myresume = new Resume("Joe Shmoe", [job1, job2, job3]);
        myresume.Display();
    }
}