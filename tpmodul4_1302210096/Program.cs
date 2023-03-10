// See https://aka.ms/new-console-template for more information
using static KodePos;

public class KodePos
{
    public enum Kelurahan
    {
        BATUNUNGGAL,
        A_KUJANGSARI,
        MENGGER,
        WATES,
        CIJAURA,
        JATISARI,
        MARGASARI,
        SEKEJATI,
        KEBONWARU,
        MALEER,
        SAMOJA
    }
    public class getkodepos
    {
        public static int GetKodePos(Kelurahan kelurahan)
        {
            int[] kodeposList = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            return kodeposList[(int)kelurahan];
        }
    }

}


class Program
{
    static void Main(string[] args)
    {
        getkodepos KODEPOS = new getkodepos();
        Kelurahan kota = Kelurahan.BATUNUNGGAL;
        int kode = getkodepos.GetKodePos(kota);
        Console.WriteLine(kota + kode);
    }
}
