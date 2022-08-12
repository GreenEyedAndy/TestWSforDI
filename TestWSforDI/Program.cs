using TestWSforDI;

class Program
{
    public static async Task Main(string[] args)
    {
        IHost host = Host.CreateDefaultBuilder(args)
            .ConfigureServices(services => { services.AddHostedService<Worker>(); })
            .Build();

        await host.RunAsync();
    }
}