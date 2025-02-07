class VisualizationActivity : Activity
{
    private List<string> scenarios = new List<string>
    {
        "Imagine yourself on a peaceful beach, feeling the warm sand beneath your feet and hearing the gentle waves.",
        "Visualize walking through a quiet forest, smelling the fresh pine trees and listening to birds singing.",
        "Picture yourself in a beautiful garden, surrounded by colorful flowers and a soft breeze on your face.",
        "Imagine lying on a grassy hill at night, gazing at a sky full of bright stars."
    };

    public VisualizationActivity()
    {
        name = "Visualization Exercise";
        description = "This activity will help you relax by guiding you through a peaceful mental visualization.";
    }

    protected override void Run()
    {
        Random random = new Random();
        string scenario = scenarios[random.Next(scenarios.Count)];

        Console.WriteLine(scenario);
        Thread.Sleep(3000);
        
        Console.WriteLine("Close your eyes and immerse yourself in this place...");
        Thread.Sleep(5000);
        
        Console.WriteLine("Take a deep breath in... and slowly breathe out...");
        Thread.Sleep(3000);

        Console.WriteLine("Stay in this peaceful place for a moment...");
        Thread.Sleep(duration * 1000);

        Console.WriteLine("Now, slowly bring your awareness back to the present moment and open your eyes.");
        Thread.Sleep(3000);
    }
}
