using System;

namespace VideoProject
{
    
    public class Comment
    {
        private string commenterName;
        private string commentText;

        public Comment(string commenterName, string commentText)
        {

            this.commenterName = commenterName;
            this.commentText = commentText;
        }

        public void DisplayComment()
        {
            Console.WriteLine($"{commenterName}: {commentText}");
        }
    }
}
