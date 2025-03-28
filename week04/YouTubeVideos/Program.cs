using System;

namespace VideoProject
{
    class Program
        {
        static void Main(string[] args)
        {
            VideoManager videoManager = new VideoManager();

            Video video1 = new Video("First Video", "James johnson", 184) ;
            video1.AddComment(new Comment("Anna", "Great video!"));

            video1.AddComment(new Comment("Bernd", "Very informative."));
            video1.AddComment(new  Comment("Clara", "Thanks for  the tips."));
            videoManager.AddVideo(video1);


            Video video2 = new Video("Second Video", "Marie SMith", 248);
            video2.AddComment(new Comment("Dieter", "Great explenation!"));
            video2.AddComment(new Comment("Eva", "More of that please."));
            videoManager.AddVideo(video2);

            Video video3 = new Video("Third Video", "Will Stevenson", 311);

            video3.AddComment(new Comment("Fritz", "Not my type."));
            video3.AddComment(new Comment("Gabi", "Interesting content."));
            video3.AddComment(new Comment("Heinz", "Well structured.") );
            videoManager.AddVideo(video3);

            videoManager.DisplayAllVideos();
        }
    }
    
}
