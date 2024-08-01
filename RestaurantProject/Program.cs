using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RestaurantProject.BLL;
using RestaurantProject.DAL;

namespace RestaurantProject {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //register DbContext
            builder.Services.AddDbContext<RestaurantProjectContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefualtConnection")));

            //Add Identity Services
            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<RestaurantProjectContext>()
                .AddDefaultUI();

            //register DAL and BLL services
            builder.Services.AddScoped<AppetizerDAL>();
            builder.Services.AddScoped<AppetizerService>();

            builder.Services.AddScoped<DesertDAL>();
            builder.Services.AddScoped<DesertService>();

            builder.Services.AddScoped<DrinkDAL>();
            builder.Services.AddScoped<DrinkService>();

            builder.Services.AddScoped<EntreeDAL>();
            builder.Services.AddScoped<EntreeService>();

            builder.Services.AddScoped<LocationDAL>();
            builder.Services.AddScoped<LocationService>();

            builder.Services.AddScoped<PromotionDAL>();
            builder.Services.AddScoped<PromotionService>();

            builder.Services.AddScoped<ReservationDAL>();
            builder.Services.AddScoped<ReservationService>();

            builder.Services.AddScoped<TestimonialDAL>();
            builder.Services.AddScoped<TestimonialService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment()) {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
