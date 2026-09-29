using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Classes & OOP Tutorial", "Code Academy", 600);
        video1.AddComment(new Comment("Alice", "Great explanation of abstraction!"));
        video1.AddComment(new Comment("Bob", "This cleared up my confusion with constructors."));
        video1.AddComment(new Comment("Charlie", "Can you cover inheritance next?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 Piano Tips for Beginners", "Music Lounge", 450);
        video2.AddComment(new Comment("David", "Loved tip #3 about hand placement."));
        video2.AddComment(new Comment("Eva", "Which keyboard is best to start with?"));
        video2.AddComment(new Comment("Frank", "Super clear and concise video!"));
        video2.AddComment(new Comment("Grace", "Subscribed! Keep them coming."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("FL Studio Beatmaking Masterclass", "Producer Corner", 900);
        video3.AddComment(new Comment("Hannah", "The mixing section was top notch."));
        video3.AddComment(new Comment("Ian", "What plugin did you use for the synth lead?"));
        video3.AddComment(new Comment("Jack", "Helped me fix my sidechain compression issue!"));
        videos.Add(video3);

        // Display video details and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetName()}: \"{comment.GetText()}\"");
            }

            Console.WriteLine("==================================================\n");
        }
    }
}