using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CurrencyConvertor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            //using (var newScope = host.Services.CreateScope())
            //{
            //    var context = newScope.ServiceProvider.GetRequiredService<ExchangeRatesDBContext>();
            //    //DBInitializer.Initialize(context);
            //}

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
