
using HotelBookingSystem.Web.Configurations;
using HotelBookingSystem.Web.Middlewares;

namespace HotelBookingSystem.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddProblemDetails();

            // Add services to the container.
            builder.ConfigureSerilog();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.ConfigureDB();
            builder.ConfigureDI();
            builder.ConfigureJwtAuth();

            var app = builder.Build();

            app.UseGlobalExceptionHandling();
            app.UseMiddleware<RequestDurationMiddleware>();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
