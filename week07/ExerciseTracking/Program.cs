using System;

class Program
{
    static void Main(string[] args)
    {
         List<Activity> _activities = new List<Activity>
        {
            new Running(new DateTime(2025, 02, 17), 60, 10.0),
            new Cycling(new DateTime(2025, 02, 17), 30, 15.0),
            new Swimming(new DateTime(2025, 02, 17), 30, 20)
        };

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}