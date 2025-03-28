using System;
using System.Collections.Generic;

namespace VideoProject
{
    public class Video
    {
        private string title;
        private string author;
        private int length;
        private List<Comment> comments;

        public Video(string title, string author, int length)
        {

            this.title = title;
            this.author = author;
            
            this.length = length;
            this.comments = new List<Comment>();
        }

        public string Title { get { return title; } }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return comments.Count;
        }

        public void DisplayVideoDetails()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");

            Console.WriteLine($"Length: {length} secounds");
            Console.WriteLine($"Nummber of comments: {GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in comments)
            {
                comment.DisplayComment();
            }
            Console.WriteLine("------------ -----------------------");
        }
    }
}
