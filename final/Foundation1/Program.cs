using System;
using System.Collections.Generic;

class Video {
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> comments = new List<Comment>();
    public void AddComment(Comment comment) {
        comments.Add(comment);
    }
    public int NumComments() {
        return comments.Count;
    }
    public List<Comment> GetComments() {
        return comments;
    }
}

class Comment {
    public string Name { get; set; }
    public string Text { get; set; }
}

class Program {
    static void Main(string[] args) {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1.Title = "My First YouTube Video";
        video1.Author = "John Doe";
        video1.Length = 120;
        video1.AddComment(new Comment { Name = "Alice", Text = "Great video!" });
        video1.AddComment(new Comment { Name = "Bob", Text = "Thanks for sharing!" });
        video1.AddComment(new Comment { Name = "Charlie", Text = "I learned a lot." });

        Video video2 = new Video();
        video2.Title = "Funny Cat Videos";
        video2.Author = "Jane Smith";
        video2.Length = 180;
        video2.AddComment(new Comment { Name = "David", Text = "So cute!" });
        video2.AddComment(new Comment { Name = "Emma", Text = "I can't stop watching." });
        video2.AddComment(new Comment { Name = "Frank", Text = "More please." });

        Video video3 = new Video();
        video3.Title = "Cooking with Jamie Oliver";
        video3.Author = "Jamie Oliver";
        video3.Length = 300;
        video3.AddComment(new Comment { Name = "Grace", Text = "Yummy!" });
        video3.AddComment(new Comment { Name = "Henry", Text = "I'm making this tonight." });
        video3.AddComment(new Comment { Name = "Isabella", Text = "Can't wait to try this." });

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos) {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length);
            Console.WriteLine("Number of Comments: " + video.NumComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments()) {
                Console.WriteLine("- " + comment.Name + ": " + comment.Text);
            }
            Console.WriteLine();
        }
    }
}
