namespace GymTracker.Backend.Api;

internal static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args); 
        builder.Services.ConfigureServices();
        builder.Build().ConfigureApp().Run();
    }
}