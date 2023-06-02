public abstract class Vehicle
{
    // Abstract methods that must be implemented by derived classes
    public abstract void Start();
    public abstract void Stop();
}

public class Car : Vehicle
{
    // Implement the Start method specific to a car
    public override void Start()
    {
        Console.WriteLine("Car started.");
    }

    // Implement the Stop method specific to a car
    public override void Stop()
    {
        Console.WriteLine("Car stopped.");
    }
}
