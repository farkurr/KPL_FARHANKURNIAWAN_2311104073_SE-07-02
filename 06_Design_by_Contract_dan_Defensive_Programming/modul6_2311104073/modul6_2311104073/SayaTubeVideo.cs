using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 200)
            throw new ArgumentException("Judul video tidak boleh kosong/null dan maksimal 200 karakter");

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0 || count > 25000000)
            throw new ArgumentException("Jumlah play count harus 0 - 25.000.000");

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException e)
        {
            Console.WriteLine("ERROR: Play count overflow! " + e.Message);
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Video Details:");
        Console.WriteLine("ID       : " + this.id);
        Console.WriteLine("Title    : " + this.title);
        Console.WriteLine("PlayCount: " + this.playCount);
        Console.WriteLine();
    }

    // Getter tambahan untuk keperluan akses dari SayaTubeUser
    public int GetPlayCount()
    {
        return this.playCount;
    }

    public string GetTitle()
    {
        return this.title;
    }
}
