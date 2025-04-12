using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (title == null || title.Length > 200)
            throw new ArgumentException("Judul video tidak boleh null dan maksimal 200 karakter");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0 || count > 25000000)
            throw new ArgumentOutOfRangeException("Jumlah play count harus 0 - 25.000.000");

        checked
        {
            playCount += count;
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("======== VIDEO DETAILS ========");
        Console.WriteLine($"ID        : {id}");
        Console.WriteLine($"Title     : {title}");
        Console.WriteLine($"PlayCount : {playCount}");
        Console.WriteLine();
    }

    public int GetPlayCount() => playCount;
    public string GetTitle() => title;
}
