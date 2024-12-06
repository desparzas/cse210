using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Video 1", "Author 1", 60);

        video1.AddComment(new Comment("Commenter 1", "Comment 1"));
        video1.AddComment(new Comment("Commenter 2", "Comment 2"));
        video1.AddComment(new Comment("Commenter 3", "Comment 3"));
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Author 2", 120);

        video2.AddComment(new Comment("Commenter 4", "Comment 4"));
        video2.AddComment(new Comment("Commenter 5", "Comment 5"));
        video2.AddComment(new Comment("Commenter 6", "Comment 6"));
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Author 3", 180);

        video3.AddComment(new Comment("Commenter 7", "Comment 7"));
        video3.AddComment(new Comment("Commenter 8", "Comment 8"));
        video3.AddComment(new Comment("Commenter 9", "Comment 9"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine();
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}