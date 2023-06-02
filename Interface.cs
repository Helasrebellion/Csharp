public interface IPlayable
{
    void Play();
    void Pause();
    void Stop();
}

public class MusicPlayer : IPlayable
{
    // Implement the Play method from the IPlayable interface
    public void Play()
    {
        Console.WriteLine("Playing music.");
    }

    // Implement the Pause method from the IPlayable interface
    public void Pause()
    {
        Console.WriteLine("Pausing music.");
    }

    // Implement the Stop method from the IPlayable interface
    public void Stop()
    {
        Console.WriteLine("Stopping music.");
    }
}
