namespace Blazor_Portfolio_Site.Shared;

public partial class MainLayout {
	public string CurPageClassName {
		get {
			switch (GlobalVariables.CurPageName) {
				case "Home": return "home-class";
				case "Games": return "games-class";
				default: return "base-class";
			}
		}
	}
}
