using BL;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Services

            #region DefaultServices
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            #endregion

            #region DataBase
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<AppDbContext>(option=>option.UseSqlServer(connectionString));
            #endregion

            #region AutoMapper
            builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
            #endregion

            #region Repos
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
            }
            #region MiddleWares

            app.UseMiddleware<ExceptionMiddleWare>();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
            #endregion
        }
    }
}