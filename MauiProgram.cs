using CallaciProjektMaui.Helpers;
using CallaciProjektMaui.Repositories;
using CallaciProjektMaui.ViewModels;
using Microsoft.Extensions.Logging;

namespace CallaciProjektMaui;

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

        string dbPath = FileAccessHelper.GetLocalFilePath("quizapp.db3");
        builder.Services.AddSingleton<QuestionRepository>(s => ActivatorUtilities.CreateInstance<QuestionRepository>(s, dbPath));
        builder.Services.AddSingleton<QuestionViewModel>();

        return builder.Build();
	}
}
