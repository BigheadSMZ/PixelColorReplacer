namespace PixelColorReplacer
{
    internal class Forms
    {
        public static Form_MainForm  MainDialog;
        public static Form_OkayForm  OkayDialog; 

        public static void Initialize()
        {
            MainDialog  = new Form_MainForm();
            OkayDialog  = new Form_OkayForm();

            MainDialog.Text = "Pixel Color Replacer v" + Config.Version;
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
