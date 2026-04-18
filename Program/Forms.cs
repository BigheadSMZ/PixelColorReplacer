namespace PixelColorReplacer
{
    internal class Forms
    {
        public static Form_MainDialog  MainDialog;

        public static void Initialize()
        {
            MainDialog  = new Form_MainDialog();
        }
        public static string CreateFolderSelectDialog(string initialPath = "")
        {
            var dialog = new FolderBrowserDialog();
            dialog.UseDescriptionForTitle = true;
            dialog.Description = "Select a folder";
            dialog.InitialDirectory = initialPath;
            dialog.ShowNewFolderButton = true;

            if (dialog.ShowDialog() == DialogResult.OK)
                return dialog.SelectedPath;

            return "";
        }
    }
}
