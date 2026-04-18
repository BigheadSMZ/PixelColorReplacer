using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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

        public static void UpdateInputPath(string path)
        {
            InputPath = path;
        }

        public static void UpdateOutputPath(string path)
        {
            OutputPath = Path.Combine(path, "~Output");
        }
    }
}
