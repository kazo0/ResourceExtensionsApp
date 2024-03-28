using Uno.Toolkit.UI;

namespace ResourcesExtensionApp;

public sealed partial class MainPage : Page
{
	public MainPage()
	{
		this.InitializeComponent();

		Loaded += OnLoaded;
		
	}

	private void OnLoaded(object sender, RoutedEventArgs e)
	{
		ThemeToggle.IsOn = !SystemThemeHelper.IsRootInDarkMode(XamlRoot);

		ThemeToggle.Toggled += ToggleSwitch_Toggled;
	}

	private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
	{
		if (sender is not ToggleSwitch toggle) return;

		SystemThemeHelper.SetRootTheme(toggle.XamlRoot, darkMode: !toggle.IsOn);
	}
}
