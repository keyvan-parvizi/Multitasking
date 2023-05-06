namespace AvoidingDeadlocks;

public static class SharedObjects
{
    public static Random Random = new();
    public static string? Message; // a shared resource
    public static object Conch = new();
}