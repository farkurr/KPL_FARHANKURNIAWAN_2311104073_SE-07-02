using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== TESTING DESIGN BY CONTRACT ===\n");

        // TEST 1: Judul video null → error
        try
        {
            SayaTubeVideo v1 = new SayaTubeVideo(null);
        }
        catch (Exception e)
        {
            Console.WriteLine("TEST 1 ERROR: " + e.Message);
        }

        // TEST 2: Judul video terlalu panjang → error
        try
        {
            string longTitle = new string('A', 201);
            SayaTubeVideo v2 = new SayaTubeVideo(longTitle);
        }
        catch (Exception e)
        {
            Console.WriteLine("TEST 2 ERROR: " + e.Message);
        }

        // TEST 3: Play count negatif → error
        try
        {
            SayaTubeVideo v3 = new SayaTubeVideo("Video Negatif");
            v3.IncreasePlayCount(-10);
        }
        catch (Exception e)
        {
            Console.WriteLine("TEST 3 ERROR: " + e.Message);
        }

        // TEST 4: Overflow test → error
        try
        {
            SayaTubeVideo v4 = new SayaTubeVideo("Video Overflow");
            for (int i = 0; i < 1000; i++)
            {
                v4.IncreasePlayCount(25000000);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("TEST 4 ERROR: " + e.Message);
        }

        // TEST 5: Username null → error
        try
        {
            SayaTubeUser userNull = new SayaTubeUser(null);
        }
        catch (Exception e)
        {
            Console.WriteLine("TEST 5 ERROR: " + e.Message);
        }

        // TEST 6: Username terlalu panjang → error
        try
        {
            string longName = new string('B', 101);
            SayaTubeUser userLong = new SayaTubeUser(longName);
        }
        catch (Exception e)
        {
            Console.WriteLine("TEST 6 ERROR: " + e.Message);
        }

        // TEST 7: Tambah video null → error
        try
        {
            SayaTubeUser user = new SayaTubeUser("Farhan");
            user.AddVideo(null);
        }
        catch (Exception e)
        {
            Console.WriteLine("TEST 7 ERROR: " + e.Message);
        }

        // TEST 8: Postcondition - print hanya 8 video dari 10
        SayaTubeUser userFarhan = new SayaTubeUser("Farhan");

        for (int i = 1; i <= 10; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo($"Review Film {i} oleh Farhan");
            video.IncreasePlayCount(1000000);
            userFarhan.AddVideo(video);
        }

        Console.WriteLine("\n=== MENAMPILKAN VIDEO MILIK FARHAN (maks. 8) ===");
        userFarhan.PrintAllVideoPlaycount();

        Console.WriteLine("\nTotal Play Count Semua Video: " + userFarhan.GetTotalVideoPlayCount());
    }
}
