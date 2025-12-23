using Avalonia.Markup.Xaml;
using Avalonia.Styling;
using System;

namespace DryRock.Themes.Cold
{
    /// <summary>
    /// Includes the cold theme in an application.
    /// </summary>
    public class ColdTheme : Styles
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColdTheme"/> class.
        /// </summary>
        /// <param name="sp">The parent's service provider.</param>
        public ColdTheme(IServiceProvider? sp = null)
        {
            AvaloniaXamlLoader.Load(sp, this);
        }
    }
}