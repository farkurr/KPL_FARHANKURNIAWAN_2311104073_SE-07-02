class Program
{
    static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Farhan");

        for (int i = 1; i <= 10; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo($"Review Film Ke-{i} oleh Farhan");
            video.IncreasePlayCount(1000000); // aman karena < 25 juta
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
        Console.WriteLine($"Total View Count: {user.GetTotalVideoPlayCount()}");
    }
}
