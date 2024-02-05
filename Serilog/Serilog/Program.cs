using System;
using Serilog;
class Program
{
    static void Main()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File(@"C:\Users\hp\Desktop\Work\Serilog\Logfile.txt")
            .CreateLogger();

        Log.Information("Hello, Serilog!");

        int a = 10, b = 0;
        try
        {
            Log.Debug("Dividing {A} by {B}", a, b);
            Console.WriteLine(a / b);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Something went wrong");
        }
        finally
        {
            Log.CloseAndFlush();
        }

    }
}