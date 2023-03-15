// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;



    internal class program{
      public class getkodeBuah
    {
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
  
        public static string getkode(kodeBuah input)
        {
            string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };
            return kodeBuah[(int)input];
        }
    };

    public static void Main(string[] args)
    {
       
        string kodeB = getkodeBuah.getkode(getkodeBuah.kodeBuah.Apel);
        Console.WriteLine("kodeBuah : "+ kodeB + "\ndengan Buah :"+ getkodeBuah.kodeBuah.Apel);
        }
    }



