using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using Color = System.Drawing.Color;
using Image = SixLabors.ImageSharp.Image;

namespace PixelColorReplacer
{
    public class ColorEntry
    {
        public Color Original { get; set; }
        public Color Replacement { get; set; }
        public int Tolerance { get; set; }
    }

    internal class Functions
    {
        public static string ColorToHex(Color c) => $"#{c.R:X2}{c.G:X2}{c.B:X2}";

        public static List<ColorEntry> colorEntries = new List<ColorEntry>();

        public static void ExchangeColors()
        {
            var inputFiles = Directory.GetFiles(Config.InputPath, "*.png", SearchOption.AllDirectories);

            foreach (var path in inputFiles)
            {
                string relativePath = Path.GetRelativePath(Config.InputPath, path);
                string dest = Path.Combine(Config.OutputPath, relativePath);
                Directory.CreateDirectory(Path.GetDirectoryName(dest));

                try
                {
                    using var image = Image.Load<Rgba32>(path);
                    image.ProcessPixelRows(accessor =>
                    {
                        for (int y = 0; y < accessor.Height; y++)
                        {
                            var row = accessor.GetRowSpan(y);
                            for (int x = 0; x < row.Length; x++)
                            {
                                ref Rgba32 pixel = ref row[x];
                                foreach (var entry in colorEntries)
                                {
                                    if (Math.Abs(pixel.R - entry.Original.R) <= entry.Tolerance &&
                                        Math.Abs(pixel.G - entry.Original.G) <= entry.Tolerance &&
                                        Math.Abs(pixel.B - entry.Original.B) <= entry.Tolerance)
                                    {
                                        pixel.R = entry.Replacement.R;
                                        pixel.G = entry.Replacement.G;
                                        pixel.B = entry.Replacement.B;
                                        break;
                                    }
                                }
                            }
                        }
                    });
                    image.Save(dest);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"[ERROR] {path}: {ex.Message}");
                }
            }
        }
    }
}
