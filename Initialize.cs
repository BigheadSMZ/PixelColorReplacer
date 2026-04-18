namespace PixelColorReplacer
{
    internal static class Initialize
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Config.Initialize();
            Forms.Initialize();
            Forms.MainDialog.ShowDialog();
        }
    }
}