using System;

class DoorMachine
{
    private enum State { Terkunci, Terbuka }
    private State state;

    public DoorMachine()
    {
        state = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void Unlock()
    {
        if (state == State.Terkunci)
        {
            state = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    public void Lock()
    {
        if (state == State.Terbuka)
        {
            state = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}
