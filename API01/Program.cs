
using API01.Controllers;
using Microsoft.Extensions.Options;

namespace API01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var builder = WebApplication.CreateBuilder(args);
        
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("MyPolicy", policy => { 
                  policy.WithOrigins("http://127.0.0.1:5500/index.html", "http://127.0.0.1:5500") // Replace with your React app's URL
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });


      
            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddControllersWithViews();

            
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors("MyPolicy");

            app.UseAuthorization();

            app.MapControllers();

            //app.MapPost("/Cuenta/PostUsers")

            app.Run();
        }
    }
}
