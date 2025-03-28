using System.Collections.Generic;

namespace VideoProject
{
    public class VideoManager
    {
        
        private List<Video> videos;

        public VideoManager()
        {
            videos = new List<Video>();
        }

        public void AddVideo(Video video)
        {
            videos.Add(video);
        }

        public void RemoveVideo(Video video)
        {

            videos.Remove(video);
        }

        public Video GetVideoByTitle(string title)
        {
            foreach (Video video in videos)
            {

                if (video.Title == title)
                {
                    return video;
                }
            }
            return null;
        }

        public void DisplayAllVideos()
        {
            foreach (Video video in videos)
            {
                video.DisplayVideoDetails();
            }
        }
    }
}
