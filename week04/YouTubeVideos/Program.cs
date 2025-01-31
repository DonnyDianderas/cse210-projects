using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C# Tutorial for Beginners | Learn the Basics of C# programming 🖥️ Csharp Tutorial for Beginners", "TutorialsEU", 16768);
        Video video2 = new Video("What is abstraction", "OOP Channel", 130);
        Video video3 = new Video("Encapsulation in C#", "NET Programmer", 151);

        video1.AddComment(new Comment("@elisamonoroe6810", "So nice when u explain Something IT Listen so easy and everybody Unserstand. But ist so hard Work to do"));
        video1.AddComment(new Comment("@StygianStyle", "You don't need a computer science degree when stuff like this is on YouTube. Amazing"));
        video1.AddComment(new Comment("@yema8319", "Is this good for beginners"));

        video2.AddComment(new Comment("@mindfulnessrock", "How is it any different from encapsulation then?"));
        video2.AddComment(new Comment("@java_Marcelo-xx5nw", "Thank you for share!"));
        video2.AddComment(new Comment("@jeffreylukebrunett3932", "Excellent quick explanation!  Thank you!"));

        video3.AddComment(new Comment("@officiallypaula510", "Thanks for sharing"));
        video3.AddComment(new Comment("@kuzco7061", "so good thank you!!"));
        video3.AddComment(new Comment("@EduardMalxa", "Thanks"));

        List<Video> videos = new List<Video> { video1, video2, video3 };
        
        foreach (var video in videos)
        {
            Console.WriteLine(video.getDisplayContent());
            
        }
    }
}