using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;

public class SayaTubeVideo
{
    private int id;
    private string tittle;
    private int playCount;

    public SayaTubeVideo(string tittle)
    {
        //prekondisi
        Contract.Requires(tittle.Length <= 100 && tittle != null);
        
        this.tittle = tittle;
        this.playCount = 0;
        Random random = new Random();
        this.id = random.Next(100000);
    }

    public void IncreasePlayCount(int playCount)
    {
        //prekondisi
        Contract.Requires(playCount <= 10000000);

        //exceptions
        try
        {
            checked
            {
                this.playCount = this.playCount + playCount;
            }
        }
        catch (OverflowException OverExcept) 
        { 
            Console.WriteLine("jumlah penambahan playcount melebihi batas " + OverExcept);
            //throw new OverflowException("jumlah penambahan playcount melebihi batas " + OverExcept);
        }
        
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Judul video " + this.tittle + " Jumlah di putar " + this.playCount + " ID Video " + this.id);
    }

    public static void Main(string[] args)
    {
        SayaTubeVideo Video = new SayaTubeVideo("Tutorial Design By Contract - [Iqnaz_Nadhif]");
        Video.PrintVideoDetails();
        Video.IncreasePlayCount(1123);
        Video.PrintVideoDetails() ; 
        for(int i = 0; i < 1000000000;)
        {
            Video.IncreasePlayCount(i);
            i = i + 100000000;
        }
    }
}
