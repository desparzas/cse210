using System;

class Video {
    public string title { get; set; }
    public string author { get; set; }
    public int length { get; set; }
    public List<Comment> comments { get; set; }

    public Video(string title, string author, int length) {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = new List<Comment>();
    }

    public void AddComment(Comment comment) {
        comments.Add(comment);
    }

    public int GetCommentCount() {
        return comments.Count;
    }

    public void DisplayVideoDetails() {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {length}");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        foreach (var comment in comments) {
            Console.WriteLine(comment.text);
        }
    }
}