using Blazorise;
using Blazorise.Animate;

public static class GlobalVariables {
	public static Action? OnPageJump;
	public static int PageAnimationSlideDirection = 0; // 1 if right, -1 if left
	public static IAnimation PageAnimation {
		get {
			switch (PageAnimationSlideDirection) {
				case > 0: return Animations.FadeLeft;
				case < 0: return Animations.FadeRight;
				default: return Animations.FadeIn;
			}
		}
	}

	// Theme switching
	public static Action? OnDarkModeToggled;
	public static bool DarkModeActivated { get; set; } = false;
	public static Theme CurTheme => (DarkModeActivated) ? darkTheme : lightTheme;
	public static int DarkModeColorInvertPercent { get { return (DarkModeActivated) ? 0 : 100; } }

	private static Theme lightTheme = new Theme {
		TextColorOptions = new ThemeTextColorOptions() {
			Primary = "#000000", // Heading text color
		},
		ColorOptions = new ThemeColorOptions() {
			Primary = "#ffffff", // Main background color
			Secondary = "#212121", // Main text color
			Light = "#ffffff", // Darker background color
			Info = "#424246", // Darker text color
		},
		BackgroundOptions = new ThemeBackgroundOptions() {
			Primary = "#ffffff", // Main background color
		},
	};
	private static Theme darkTheme = new Theme {
		TextColorOptions = new ThemeTextColorOptions() {
			Primary = "#ffffff", // Heading text color
		},
		ColorOptions = new ThemeColorOptions() {
			Primary = "#212121", // Main background color
			Secondary = "#f1f1f1", // Main text color
			Light = "#424246", // Lighter background color
			Info = "#d4d9dd", // Lighter text color
		},
		BackgroundOptions = new ThemeBackgroundOptions() {
			Primary = "#212121", // Main background color
		},
	};
}
