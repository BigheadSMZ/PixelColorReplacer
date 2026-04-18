using System.Reflection;

namespace PixelColorReplacer
{
    internal class Config
    {
        public static string AppPath;
        public static string BaseFolder;
        public static string InputPath;
        public static string OutputPath;

        public static void Initialize()
        {
            AppPath       = Assembly.GetExecutingAssembly().Location;
            BaseFolder    = AppContext.BaseDirectory;;
        }
    }
}