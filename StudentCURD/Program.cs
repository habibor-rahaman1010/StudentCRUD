using Core.Interface;
using Infrastructure.Data;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Core.Entities;
using Serilog;
using Serilog.Events;
using Autofac.Extensions.DependencyInjection;
using Autofac;


namespace StudentCURD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Configuration for bootstarp logger...
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configurationBuilder).CreateBootstrapLogger();

            try
            {
                Log.Information("Application Starting...");
                var builder = WebApplication.CreateBuilder(args);

                //Serilog configuration...
                IHostBuilder hostBuilder = builder.Host.UseSerilog((context, loggerConfig) =>
                   loggerConfig.MinimumLevel.Debug()
                   .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                   .Enrich.FromLogContext()
                   .ReadFrom.Configuration(builder.Configuration)
                );

                // Database connectiong here...
                builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection")));

                builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>();

                //Autofac dependency injection configuration 
                builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
                builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
                {
                    containerBuilder.RegisterType<UserManager<ApplicationUser>>().InstancePerLifetimeScope();
                    containerBuilder.RegisterType<RoleManager<IdentityRole>>().InstancePerLifetimeScope();
                    containerBuilder.RegisterType<SignInManager<ApplicationUser>>().InstancePerLifetimeScope();
                    containerBuilder.RegisterModule(new WebModule());
                });

                // Add services to the container.
                builder.Services.AddControllersWithViews();
                builder.Services.AddTransient<IUnitOfWork, UnitOfWorkService>();
                builder.Services.AddTransient<IStudentInfo, StudentInfoService>();
                builder.Services.AddTransient<IBlogPost, BlogPostService>();
                builder.Services.AddTransient<ICategory, CategoryService>();


                var app = builder.Build();

                // Configure the HTTP request pipeline.
                if (!app.Environment.IsDevelopment())
                {
                    app.UseExceptionHandler("/Home/Error");
                    app.UseHsts();
                }

                app.UseHttpsRedirection();
                app.UseStaticFiles();

                app.UseRouting();
                app.UseAuthentication();

                app.UseAuthorization();

                app.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=StudentList}/{id?}");
                app.MapRazorPages();

                app.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex.ToString(), "Faild to start application!");
            }
            finally 
            {
                Log.CloseAndFlush();
            }
        }
    }
}