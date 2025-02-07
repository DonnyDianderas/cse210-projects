class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public void Start()
{
    Console.Clear();
    Console.WriteLine("Starting " + name);
    Console.WriteLine(description);
    Console.Write("How long, in seconds, would you like for your session?: ");
    duration = int.Parse(Console.ReadLine());
    Console.WriteLine("Prepare to begin...");

    ShowLoadingAnimation(); 

    Run();
    Console.WriteLine("Well done!!");

    ShowLoadingAnimation(); 

    Console.WriteLine("You completed " + duration + " seconds of " + name + "!");

    Thread.Sleep(3000); 
}


    protected virtual void Run() { }

    private void ShowLoadingAnimation() 
    {
        for (int i = 0; i < 2; i++)
        {
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}