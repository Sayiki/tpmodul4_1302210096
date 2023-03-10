// See https://aka.ms/new-console-template for more information
using static KodePos;

public class KodePos
{
    public enum Kelurahan
    {
        Batununggal,
        AKujangsari,
        Mengger,
        Wates,
        Cijaura,
        Jatisari,
        Margasari,
        Sekejati,
        Kebonwaru,
        Maleer,
        Samoja
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

public class DoorMachine
{
    private enum State
    {
        Terkunci,
        Terbuka
    }

    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void OpenDoor()
    {
        if (currentState == State.Terkunci)
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    public void CloseDoor()
    {
        if (currentState == State.Terbuka)
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}



class Program
{
    static void Main(string[] args)
    {
        getkodepos KODEPOS = new getkodepos();
        Kelurahan kota = Kelurahan.Batununggal;
        int kode = getkodepos.GetKodePos(kota);
        Console.WriteLine(kota + kode);

        DoorMachine door = new DoorMachine();
        door.OpenDoor();
        door.CloseDoor();
    }
}
