using Microsoft.Extensions.Logging;
using Rice_DanContact_List_Application.ViewModels;
using Rice_DanContact_List_Application.Views;

namespace Rice_DanContact_List_Application;

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
            });

        builder.Services.AddSingleton<ContactViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<ContactsPage>();
        builder.Services.AddSingleton<ContactDetailsPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
