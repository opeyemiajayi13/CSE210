using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first video
        Video video1 = new Video(
            "How to Become Successful",
            "John Smith",
            600
        );

        video1.AddComment(new Comment("David", "Very helpful video!"));
        video1.AddComment(new Comment("Sarah", "I learned something new."));
        video1.AddComment(new Comment("Michael", "Thank you for sharing."));
        video1.AddComment(new Comment("Grace", "I enjoyed watching this."));

        // Create the second video
        Video video2 = new Video(
            "Learning C# Programming",
            "Tech Academy",
            850
        );

        video2.AddComment(new Comment("James", "Great programming tutorial."));
        video2.AddComment(new Comment("Mary", "Please make more videos."));
        video2.AddComment(new Comment("Daniel", "This helped me understand C#."));
        video2.AddComment(new Comment("Peter", "Excellent explanation."));

        // Create the third video
        Video video3 = new Video(
            "Five Ways to Save Money",
            "Money Mentor",
            720
        );

        video3.AddComment(new Comment("Esther", "Excellent financial advice."));
        video3.AddComment(new Comment("Peter", "I will start saving today."));
        video3.AddComment(new Comment("Grace", "Very informative!"));
        video3.AddComment(new Comment("Samuel", "Thanks for these tips."));

        // Create the fourth video
        Video video4 = new Video(
            "The Importance of Education",
            "Learning Channel",
            900
        );

        video4.AddComment(new Comment("Alice", "Education changes lives."));
        video4.AddComment(new Comment("David", "Wonderful presentation."));
        video4.AddComment(new Comment("Mary", "I completely agree."));
        video4.AddComment(new Comment("John", "Keep up the good work."));

        // Store all videos in a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        // Display each video and its comments
        foreach (Video video in videos)
        {
            Console.WriteLine("==================================");
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}