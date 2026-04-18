namespace PixelColorReplacer
{
    public partial class Form_MainDialog : Form
    {
        ColorDialog _colorDialog = new ColorDialog();
        Color? _original;
        Color? _replace;
        int _tolerance;
        string _inputPath;
        string _outputPath;
        int _selectedIndex = -1;

        public Form_MainDialog()
        {
            InitializeComponent();
            MainControl_ListView.DrawColumnHeader += (s, e) => e.DrawDefault = true;
            MainControl_ListView.DrawSubItem += MainControl_ListView_DrawSubItem;
        }


        /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                CUSTOM DRAW LISTBOX CELL

        -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/


        private void MainControl_ListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
            {
                ColorEntry entry = (ColorEntry)e.Item.Tag;
                Color color = e.ColumnIndex == 0 ? entry.Original : entry.Replacement;

                using var brush = new SolidBrush(color);
                e.Graphics.FillRectangle(brush, e.Bounds);

                Color textColor = (color.R * 0.299 + color.G * 0.587 + color.B * 0.114) > 128
                    ? Color.Black : Color.White;
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.Item.Font, e.Bounds, textColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                GAME PATH

        -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

        private void textBox_InputPath_TextChanged(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;
            if (text.TestPath())
            {
                _inputPath = text;
                Config.UpdateInputPath(_inputPath);
            }
        }
        private void textBox_InputPath_Leave(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;
            if (text != "" && text.TestPath())
            {
                _inputPath = text;
                Config.UpdateInputPath(_inputPath);
            }
            else
                this.textBox_InputPath.Text = _inputPath;
        }
        private void textBox_InputPath_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void textBox_InputPath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] DroppedPath = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (DroppedPath[0] != "" && DroppedPath[0].TestPath())
                {
                    _inputPath = DroppedPath[0];
                    Config.UpdateInputPath(_inputPath);
                    this.textBox_InputPath.Text = _inputPath;
                }
            }
        }
        private void button_InputPath_Click(object sender, EventArgs e)
        {
            string selectedPath = Forms.CreateFolderSelectDialog(Config.BaseFolder);

            if (selectedPath != "" && selectedPath.TestPath())
            {
                _inputPath = selectedPath;
                Config.UpdateInputPath(_inputPath);
                this.textBox_InputPath.Text = _inputPath;
            }
        }

        /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                OUTPUT PATH

        -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

        private void textBox_OutputPath_TextChanged(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;
            if (text.TestPath())
            {
                _outputPath = text;
                Config.UpdateOutputPath(_outputPath);
            }
        }
        private void textBox_OutputPath_Leave(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;
            if (text != "" && text.TestPath())
            {
                _outputPath = text;
                Config.UpdateOutputPath(_outputPath);
            }
            else
                this.textBox_OutputPath.Text = _outputPath;
        }
        private void textBox_OutputPath_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void textBox_OutputPath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] DroppedPath = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (DroppedPath[0] != "" && DroppedPath[0].TestPath())
                {
                    _outputPath = DroppedPath[0];
                    Config.UpdateOutputPath(_outputPath);
                    this.textBox_OutputPath.Text = _outputPath;
                }
            }
        }
        private void button_OutputPath_Click(object sender, EventArgs e)
        {
            string selectedPath = Forms.CreateFolderSelectDialog(Config.BaseFolder);

            if (selectedPath != "" && selectedPath.TestPath())
            {
                _outputPath = selectedPath;
                Config.UpdateOutputPath(_outputPath);
                this.textBox_OutputPath.Text = _outputPath;
            }
        }

        /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                CONTROLS

        -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

        private void ClearButtons()
        {
            _original = null;
            _replace = null;
            _tolerance = 0;

            button_SourceColor.Text = "Source";
            button_ReplaceColor.Text = "Target";
            button_AddColors.Text = "Add";
            button_Clear.Text = "Clear";
            numBox_Tolerance.Value = 0;

            button_SourceColor.BackColor = SystemColors.Window;
            button_ReplaceColor.BackColor = SystemColors.Window;
        }

        private Color? GetColor(Button button)
        {
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                button.BackColor = _colorDialog.Color;
                button.Text = "";
                return _colorDialog.Color;
            }
            return null;
        }

        private void button_SourceColor_Click(object sender, EventArgs e)
        {
            var color = GetColor(sender as Button);
            if (color != null) _original = color;
        }

        private void button_ReplaceColor_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            _replace = GetColor(button);
        }

        private void numBox_Tolerance_ValueChanged(object sender, EventArgs e)
        {
            var value = (int)numBox_Tolerance.Value;
            _tolerance = value;
        }

        private void button_AddColors_Click(object sender, EventArgs e)
        {
            if (_original == null || _replace == null)
                return;

            if (_selectedIndex < 0)
            {
                ColorEntry newEntry = new ColorEntry();
                newEntry.Original = _original.Value;
                newEntry.Replacement = _replace.Value;
                newEntry.Tolerance = _tolerance;
                Functions.colorEntries.Add(newEntry);

                var item = new ListViewItem();
                item.Text = Functions.ColorToHex(newEntry.Original);
                item.SubItems.Add(Functions.ColorToHex(newEntry.Replacement));
                item.SubItems.Add(newEntry.Tolerance.ToString());
                item.Tag = newEntry;

                MainControl_ListView.Items.Add(item);
            }
            else
            {
                ColorEntry entry = Functions.colorEntries[_selectedIndex];
                entry.Original = _original.Value;
                entry.Replacement = _replace.Value;
                entry.Tolerance = _tolerance;

                ListViewItem item = MainControl_ListView.Items[_selectedIndex];
                item.Text = Functions.ColorToHex(entry.Original);
                item.SubItems[1].Text = Functions.ColorToHex(entry.Replacement);
                item.SubItems[2].Text = entry.Tolerance.ToString();
                item.Tag = entry;
            }
            ClearButtons();
            MainControl_ListView.SelectedItems.Clear();
            _selectedIndex = -1;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Functions.ExchangeColors();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            if (_selectedIndex < 0)
            {
                ClearButtons();
                MainControl_ListView.Items.Clear();
                Functions.colorEntries.Clear();
            }
            else
            {
                int indexToRemove = _selectedIndex;
                MainControl_ListView.Items.RemoveAt(indexToRemove);
                Functions.colorEntries.RemoveAt(indexToRemove);
                _selectedIndex = -1;
                ClearButtons();
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainControl_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;
            if (listView.SelectedItems.Count == 0)
            {
                _selectedIndex = -1;
                ClearButtons();
                return;
            }
            ListViewItem item = listView.SelectedItems[0];
            _original = ColorTranslator.FromHtml(item.Text);
            _replace = ColorTranslator.FromHtml(item.SubItems[1].Text);
            _tolerance = Convert.ToInt32(item.SubItems[2].Text);

            button_SourceColor.BackColor = _original.Value;
            button_ReplaceColor.BackColor = _replace.Value;
            numBox_Tolerance.Value = _tolerance;

            button_SourceColor.Text = "";
            button_ReplaceColor.Text = "";
            button_AddColors.Text = "Replace";
            button_Clear.Text = "Remove";

            _selectedIndex = listView.SelectedItems[0].Index;
        }
    }
}
