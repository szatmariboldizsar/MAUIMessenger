using MAUIMessenger.Pages;
using MAUIMessenger.Services;
using MAUIMessenger.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DAL;
using DAL.Services;

namespace MAUIMessenger
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if WINDOWS
            Microsoft.Maui.Handlers.SwitchHandler.Mapper.AppendToMapping("NoLabel", (handler, view) =>
            {
                handler.PlatformView.OnContent = null;
                handler.PlatformView.OffContent = null;

                handler.PlatformView.MinWidth = 0;
            });
#endif

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var conn = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conn));

            builder.Services.AddSingleton<UserService>();
            builder.Services.AddSingleton<UserConnectionService>();
            builder.Services.AddSingleton<AuthService>();
            builder.Services.AddSingleton<MessageService>();

            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<LoginViewModel>();
            builder.Services.AddSingleton<RegisterPage>();
            builder.Services.AddSingleton<RegisterViewModel>();
            builder.Services.AddTransient<UsersPage>();
            builder.Services.AddTransient<UsersViewModel>();
            builder.Services.AddTransient<MessagePage>();
            builder.Services.AddTransient<MessageViewModel>();

            return builder.Build();
        }
    }
}
