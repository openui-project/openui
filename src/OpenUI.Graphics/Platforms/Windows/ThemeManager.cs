using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace OpenUI {
	public enum Theme
	{
    Light,
    Dark,
    System
	}

	public partial class GameWindow {
		public void SetTheme(Theme theme) 
		{
			Graphics.ThemeManager.ApplyTheme(form, theme);
		}
	}
}

namespace OpenUI.Graphics {
	public static class ThemeManager {
    public static Theme CurrentTheme { get; private set; } = Theme.System;
    
    public static void ApplyTheme(Form form, Theme theme)
    {
        CurrentTheme = theme;
        Color backColor, foreColor;

        if (theme == Theme.System)
        {
            theme = DetectSystemTheme();
        }
        
        if (theme == Theme.Dark)
        {
            backColor = Color.FromArgb(18, 18, 18);
            foreColor = Color.White;
        }
        else // Light Theme
        {
            backColor = Color.White;
            foreColor = Color.Black;
        }
        
        form.BackColor = backColor;
        form.ForeColor = foreColor;
    }
    
    private static Theme DetectSystemTheme()
    {
        int value = (int)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", 1);
        return value == 0 ? Theme.Dark : Theme.Light;
		}
	}
}
