using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Services.Data;
using EmployeeManagementSystem.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            string connectionString = builder.Configuration.GetConnectionString("Default");

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<EmployeeManagementDbContext>
                (cfg => cfg.UseSqlServer(connectionString));
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            using var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider
                .GetRequiredService<EmployeeManagementDbContext>();
            await db.Database.MigrateAsync();

            await app.RunAsync();
        }
    }
}