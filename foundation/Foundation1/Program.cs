using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# Programming", "Matias Gutierrez", 1200);
        Video video2 = new Video("Learning Prompting for AI", "Fabricio Romano", 900);
        Video video3 = new Video("Intro to Python", "Erling Haaland", 1500);

        video1.AddComment(new Comment("JohnHalton", "Great tutorial, thanks!", DateTime.Now));
        video1.AddComment(new Comment("RickySmith", "Very informative video!", DateTime.Now));
        video1.AddComment(new Comment("JulianArias", "This really helped me!", DateTime.Now));

        video2.AddComment(new Comment("CarolaJordan", "AI is awesome!", DateTime.Now));
        video2.AddComment(new Comment("RosaJones", "I learned a lot, thanks!", DateTime.Now));
        video2.AddComment(new Comment("JacobS", "Clear and concise!", DateTime.Now));

        video3.AddComment(new Comment("KiraJohns", "Amazing introduction!", DateTime.Now));
        video3.AddComment(new Comment("SamuelSosa", "Thanks for the tips!", DateTime.Now));
        video3.AddComment(new Comment("BraianG", "Can't wait for more!", DateTime.Now));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            video.DisplayComment();
        }
    }
}