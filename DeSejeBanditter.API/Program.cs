
using DeSejeBanditter.DAL.Interfaces;
using DeSejeBanditter.DAL.Models;
using DeSejeBanditter.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DeSejeBanditter.API
{
    /// <summary>
    /// Autogenerer vores controller
    /// Hvis I vil skrive kode er det GET og POST
    /// Databaseopsætning
    /// DI - Dependency Injection
    /// 
    /// 1) API og DAL opsætning - packages....
    /// 2) Models i DAL
    /// 3) Interfaces i DAL
    /// 4) Classes til at håndtere data adgang (her er der en del kode)
    /// 
    /// 5) DI skal registreres
    /// 6) Controller skal genereres (virker sikkert ikke første gang)
    /// 7) Method skal kodes i Controller
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


            string conStr = @"Server=TEC-8220-LA0025;Database=OnsdagH2;
            Trusted_Connection=true; Trust Server Certificate=true; Integrated Security=true; Encrypt=True; ";
            builder.Services.AddDbContext<DatabaseContext>(obj => obj.UseSqlServer(conStr));
            //builder.Services.AddDbContext<DatabaseContext>(obj => obj.MySQL(conStr));
            builder.Services.AddScoped<ISamurai, SamuraiRepository>();

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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
