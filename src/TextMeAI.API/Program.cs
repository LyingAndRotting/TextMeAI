
using TextMeAI.Infrastructure;

namespace TextMeAI;

internal static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var configuration = builder.Configuration;
        builder.Services.AddControllers();

        builder.Services.AddInfrastructure(configuration);

        builder.Services.AddAuthorization();
        builder.Services.AddAuthentication();
        builder.Services.AddEndpointsApiExplorer();
    }
}