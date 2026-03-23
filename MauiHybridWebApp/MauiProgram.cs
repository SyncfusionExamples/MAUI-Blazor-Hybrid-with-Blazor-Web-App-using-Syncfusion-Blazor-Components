using MauiHybridWebApp.Services;
using MauiHybridWebApp.Shared.Services;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
namespace MauiHybridWebApp
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
          });

      // Add device-specific services used by the MauiHybridWebApp.Shared project
      builder.Services.AddSingleton<IFormFactor, FormFactor>();

      builder.Services.AddMauiBlazorWebView();
      builder.Services.AddSyncfusionBlazor();

#if DEBUG
      builder.Services.AddBlazorWebViewDeveloperTools();
          builder.Logging.AddDebug();
#endif

      return builder.Build();
    }
  }
}
