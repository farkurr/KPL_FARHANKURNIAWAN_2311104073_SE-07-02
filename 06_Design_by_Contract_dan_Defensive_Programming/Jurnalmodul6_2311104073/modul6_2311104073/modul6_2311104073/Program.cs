using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            SayaTubeUser user = new SayaTubeUser("Farhan");

            // Menambahkan 10 video
            for (int i = 1; i <= 10; i++)
            {
                string judul = $"Review Film ke-{i} oleh Farhan";
                SayaTubeVideo video = new SayaTubeVideo(judul);
                video.IncreasePlayCount(1000000); // Aman
                user.AddVideo(video);
            }

            user.PrintAllVideoPlaycount();
            Console.WriteLine("Total play count semua video: " + user.GetTotalVideoPlayCount());

            // Uji Precondition: judul null
            try
            {
                SayaTubeVideo errorVideo = new SayaTubeVideo(null);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception (judul null): " + e.Message);
            }

            // Uji Precondition: jumlah playCount melebihi batas
            try
            {
                SayaTubeVideo testOverflow = new SayaTubeVideo("Uji Overflow");
                for (int i = 0; i < 1000; i++) // Overflow cepat
                {
                    testOverflow.IncreasePlayCount(25000000);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception (overflow play count): " + e.Message);
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception umum: " + ex.Message);
        }
    }
}
