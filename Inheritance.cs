public class Animal
{
    // Virtual method that can be overridden by derived classes
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Dog : Animal
{
    // Override the base class method to provide specific behavior for Dog
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}
