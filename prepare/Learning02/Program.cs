using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._company = "The Piano Place";
        job1._jobTitle = "Piano Teacher";
        job1._startYear = "2021";
        job1._endYear = "current";


        Job job2 = new Job();
        job2._company = "The Megaplex";
        job2._jobTitle = "Concessions Team Member";
        job2._startYear = "2018";
        job2._endYear = "2019";


        Resume myResume = new Resume();
        myResume._name = "Madison Loutensock";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}