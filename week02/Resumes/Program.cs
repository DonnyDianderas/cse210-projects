using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Industrial Engineer";
        job1._company = "Quimpac";
        job1._startYear = 2015;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Control Room Panelist";
        job2._company = "Cooperativa Naranjillo";
        job2._startYear = 2013;
        job2._endYear = 2015;

        //Console.WriteLine(job1._company);
        //Console.WriteLine(job2._company);

        //job1.DisplayJob();
        //Job2.DisplayJob();

        Resume resume = new Resume();
        resume._name = "Donny Dianderas";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayJob();
    }
    
}