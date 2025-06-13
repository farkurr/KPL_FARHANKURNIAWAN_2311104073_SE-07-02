public class DoorMachine
{
    private bool terkunci = true;

    public void buka()
    {
        if (terkunci)
        {
            terkunci = false;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    public void kunci()
    {
        if (!terkunci)
        {
            terkunci = true;
            Console.WriteLine("Pintu terkunci");
        }
    }
}
