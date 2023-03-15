// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;

namespace MOD4
{
    internal class program
    public enum kodeBuah
    {
        Apel,
        Aprikot,
        Alpukat,
        Pisang,
        Paprika,
        Blackberry,
        Ceri,
        Kelapa,
        Jagung,
    };
    public class getkodeBuah
    {
        public static string getkode(kodeBuah)
        {
            string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };
            return kodeBuah[(int)kodeBuah];
        }
    };

    public static void Main(string[] args)
    {
        kodeBuah = kodeBuah.Apel;
        string kode = getkodeBuah.getkode(kode);
        Console.WriteLine("kodeBuah : "+ kodeBuah + "\ndengan kodeBuah :"+ kodeBuah);
        }
    }
    

