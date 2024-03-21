using MauiApp2.ViewModel;
using Microsoft.Extensions.Logging;

namespace MauiApp2;

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

#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();
        // AddSingleton: 애플리케이션 전체에서 하나의 인스턴스만 생성됨
        // 싱글톤 수명 서비스(AddSingleton)는 처음 요청할 때 인스턴스 생성. 모든 후속 요청에서는 같은 인스턴스를 사용.

        return builder.Build();
    }
}
