namespace GymTracker.Backend.Api;

internal static class Program
{
    public static void Main(string[] args)
    {
        WebApplication.CreateBuilder(args)
            .ConfigureServices()
            .Build()
            .ConfigureApp()
            .Run(); 
    }
}