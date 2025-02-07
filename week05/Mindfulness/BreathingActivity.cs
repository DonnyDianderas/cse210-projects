class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        name = "Breathing Activity";
        description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void Run()
    {
        int remainingTime = duration;
        Random random = new Random();

        while (remainingTime > 0)
        {
            int breatheInTime = random.Next(4, 5); 
            int breatheOutTime = random.Next(4, 6); 

            if (remainingTime < breatheInTime + breatheOutTime)
            {
                
                breatheInTime = remainingTime / 2;
                breatheOutTime = remainingTime - breatheInTime;
            }

            Console.Write("Breathe in... ");
            ShowCountdown(breatheInTime);
            remainingTime -= breatheInTime;

            if (remainingTime <= 0) break;

            Console.Write("Now breathe out... ");
            ShowCountdown(breatheOutTime);
            remainingTime -= breatheOutTime;
        }
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " "); 
            Thread.Sleep(1000); 
            Console.Write("\b\b"); 
        }
        Console.WriteLine(); 
    }
}
