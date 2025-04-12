using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 200) throw new ArgumentException("Judul invalid");
        this.title = title;
        Random rnd = new Random();
        this.id = rnd.Next(10000, 99999);
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0 || count > 25000000) throw new ArgumentException("Play count tidak valid");
        checked
        {
            this.playCount += count;
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}, Title: {title}, Play Count: {playCount}");
    }

    public int GetPlayCount()
    {
        return this.playCount;
    }

    public string GetTitle()
    {
        return this.title;
    }
}
