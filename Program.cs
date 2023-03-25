using System.Security.Cryptography;

public class SayaTubeVideo
{
    private int id;
    private string tittle;
    private int playCount;

    public SayaTubeVideo(string tittle)
    {
        this.tittle = tittle;
        this.playCount = 0;
        Random random = new Random();
        this.id = random.Next(100000);
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount = this.playCount + playCount;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Judul video " + this.tittle + " Jumlah di putar " + this.playCount + " ID Video " + this.id);
    }

    public static void Main(string[] args)
    {
        SayaTubeVideo Video = new SayaTubeVideo("Tutorial Design By Contract - [Iqnaz_Nadhif]");
        Video.PrintVideoDetails();
        Video.IncreasePlayCount(1);
        Video.PrintVideoDetails();
        Video.IncreasePlayCount(2);
        Video.PrintVideoDetails();
    }
}
