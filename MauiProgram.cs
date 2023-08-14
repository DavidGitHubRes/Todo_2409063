using Microsoft.Extensions.Logging;
using Todo_2409063.Data;
using Todo_2409063.Views;

namespace Todo_2409063;

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
		builder.Services.AddSingleton<TodoListPage>();
        builder.Services.AddSingleton<TodoItemPage>();
        builder.Services.AddSingleton<TodoItemDatabase>();


        return builder.Build();
	}
}
