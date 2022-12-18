using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Drawing;
using System.Text;

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
