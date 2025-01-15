using System;

public class Resume
{
    public string _name;
    public List<Job>_jobs = new List<Job>();

    public void DisplayJob()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job history in _jobs)
        {
            history.DisplayJob();
        }
    }
}

