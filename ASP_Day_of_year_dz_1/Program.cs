using System.Text;

namespace ASP_Day_of_year_dz_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", context =>
            {
                StringBuilder sb = new StringBuilder();
                string dayOfYear = DateTime.Now.DayOfYear.ToString();
                sb.AppendLine($"<div style = 'font-size: 50px'>Current day of year: {dayOfYear}</div>");
                return context.Response.WriteAsync( sb.ToString() );
            });

            app.Run();
        }
    }
}