using System;

class PosisiKarakterGame
{
    private string state;

    public PosisiKarakterGame()
    {
        this.state = "Berdiri";
    }

    public void TekanTombol(string tombol)
    {
        switch (tombol)
        {
            case "W":
                Console.WriteLine("Tombol arah atas ditekan");
                break;
            case "S":
                Console.WriteLine("Tombol arah bawah ditekan");
                break;
            case "Berdiri":
                Console.WriteLine("Posisi standby");
                this.state = "Berdiri";
                break;
            case "Tengkurap":
                Console.WriteLine("Posisi istirahat");
                this.state = "Tengkurap";
                break;
            case "Terbang":
                Console.WriteLine("Posisi take off");
                this.state = "Terbang";
                break;
            case "Jongkok":
                Console.WriteLine("Posisi landing");
                this.state = "Jongkok";
                break;
            default:
                Console.WriteLine("Perintah tidak dikenali");
                break;
        }
    }
}
