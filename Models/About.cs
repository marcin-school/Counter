using System.Windows.Input;

namespace Counter.Models
{
    internal class About
    {
        public String version { get; set; } = "0.1.0";
        public String authorName { get; set; } = "Marcin Morawiec";
        public String licenseName { get; set; } = "CC BY-NC-ND";
        public String licenseUrl { get; set; } = "https://creativecommons.org/licenses/by-nc-nd/4.0/";
        public ICommand OpenUrlCommand => new Command<String>( async (url) => await Launcher.OpenAsync(url));
    }
}
