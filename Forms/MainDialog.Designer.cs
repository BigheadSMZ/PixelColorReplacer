namespace PixelColorReplacer
{
    partial class Form_MainDialog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainDialog));
            MainControl_ListView = new ListView();
            SourceColor = new ColumnHeader();
            TargetColor = new ColumnHeader();
            Tolerance = new ColumnHeader();
            button_SourceColor = new Button();
            button_ReplaceColor = new Button();
            numBox_Tolerance = new NumericUpDown();
            button_AddColors = new Button();
            button_Start = new Button();
            button_Exit = new Button();
            button_Clear = new Button();
            textBox_InputPath = new TextBox();
            button_InputPath = new Button();
            label_InputPath = new Label();
            label_OutputPath = new Label();
            button_OutputPath = new Button();
            textBox_OutputPath = new TextBox();
            MainTooltip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)numBox_Tolerance).BeginInit();
            SuspendLayout();
            // 
            // MainControl_ListView
            // 
            MainControl_ListView.Columns.AddRange(new ColumnHeader[] { SourceColor, TargetColor, Tolerance });
            MainControl_ListView.FullRowSelect = true;
            MainControl_ListView.GridLines = true;
            MainControl_ListView.Location = new Point(12, 103);
            MainControl_ListView.Name = "MainControl_ListView";
            MainControl_ListView.OwnerDraw = true;
            MainControl_ListView.Size = new Size(304, 252);
            MainControl_ListView.TabIndex = 0;
            MainControl_ListView.UseCompatibleStateImageBehavior = false;
            MainControl_ListView.View = View.Details;
            MainControl_ListView.SelectedIndexChanged += MainControl_ListView_SelectedIndexChanged;
            // 
            // SourceColor
            // 
            SourceColor.Text = "Source Color";
            SourceColor.Width = 100;
            // 
            // TargetColor
            // 
            TargetColor.Text = "Target Color";
            TargetColor.TextAlign = HorizontalAlignment.Center;
            TargetColor.Width = 100;
            // 
            // Tolerance
            // 
            Tolerance.Text = "Tolerance";
            Tolerance.TextAlign = HorizontalAlignment.Center;
            Tolerance.Width = 100;
            // 
            // button_SourceColor
            // 
            button_SourceColor.Location = new Point(11, 362);
            button_SourceColor.Name = "button_SourceColor";
            button_SourceColor.Size = new Size(72, 25);
            button_SourceColor.TabIndex = 1;
            button_SourceColor.Text = "Source";
            MainTooltip.SetToolTip(button_SourceColor, "Selects the color to replace.");
            button_SourceColor.UseVisualStyleBackColor = true;
            button_SourceColor.Click += button_SourceColor_Click;
            // 
            // button_ReplaceColor
            // 
            button_ReplaceColor.Location = new Point(87, 362);
            button_ReplaceColor.Name = "button_ReplaceColor";
            button_ReplaceColor.Size = new Size(72, 25);
            button_ReplaceColor.TabIndex = 2;
            button_ReplaceColor.Text = "Target";
            MainTooltip.SetToolTip(button_ReplaceColor, "Selects the replacement color.");
            button_ReplaceColor.UseVisualStyleBackColor = true;
            button_ReplaceColor.Click += button_ReplaceColor_Click;
            // 
            // numBox_Tolerance
            // 
            numBox_Tolerance.Location = new Point(166, 363);
            numBox_Tolerance.Name = "numBox_Tolerance";
            numBox_Tolerance.Size = new Size(72, 23);
            numBox_Tolerance.TabIndex = 3;
            MainTooltip.SetToolTip(numBox_Tolerance, "The threshold to replace a color. If a pixel\r\nRGB value is 230/220/30 for example, then\r\nthe search range is 228-232/218-222/28-32.");
            numBox_Tolerance.ValueChanged += numBox_Tolerance_ValueChanged;
            // 
            // button_AddColors
            // 
            button_AddColors.Location = new Point(245, 362);
            button_AddColors.Name = "button_AddColors";
            button_AddColors.Size = new Size(72, 25);
            button_AddColors.TabIndex = 4;
            button_AddColors.Text = "Add";
            MainTooltip.SetToolTip(button_AddColors, "Adds an entry to the list \r\nor updates selected color.");
            button_AddColors.UseVisualStyleBackColor = true;
            button_AddColors.Click += button_AddColors_Click;
            // 
            // button_Start
            // 
            button_Start.Location = new Point(11, 392);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(98, 30);
            button_Start.TabIndex = 6;
            button_Start.Text = "Start";
            MainTooltip.SetToolTip(button_Start, "Starts replacing colors for\r\nimages found in InputPath.");
            button_Start.UseVisualStyleBackColor = true;
            button_Start.Click += buttonStart_Click;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(219, 392);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(98, 30);
            button_Exit.TabIndex = 7;
            button_Exit.Text = "Exit";
            MainTooltip.SetToolTip(button_Exit, "Closes the program.");
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // button_Clear
            // 
            button_Clear.Location = new Point(116, 392);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(98, 30);
            button_Clear.TabIndex = 8;
            button_Clear.Text = "Clear";
            MainTooltip.SetToolTip(button_Clear, "Clears the entire list of colors \r\nor removes the selected color.");
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            // 
            // textBox_InputPath
            // 
            textBox_InputPath.AllowDrop = true;
            textBox_InputPath.Location = new Point(12, 22);
            textBox_InputPath.Name = "textBox_InputPath";
            textBox_InputPath.Size = new Size(272, 23);
            textBox_InputPath.TabIndex = 9;
            textBox_InputPath.DragDrop += textBox_InputPath_DragDrop;
            textBox_InputPath.DragEnter += textBox_InputPath_DragEnter;
            textBox_InputPath.Leave += textBox_InputPath_Leave;
            // 
            // button_InputPath
            // 
            button_InputPath.Location = new Point(289, 22);
            button_InputPath.Name = "button_InputPath";
            button_InputPath.Size = new Size(28, 25);
            button_InputPath.TabIndex = 10;
            button_InputPath.Text = "...";
            button_InputPath.UseVisualStyleBackColor = true;
            button_InputPath.Click += button_InputPath_Click;
            // 
            // label_InputPath
            // 
            label_InputPath.AutoSize = true;
            label_InputPath.Location = new Point(15, 5);
            label_InputPath.Name = "label_InputPath";
            label_InputPath.Size = new Size(62, 15);
            label_InputPath.TabIndex = 11;
            label_InputPath.Text = "Input Path";
            MainTooltip.SetToolTip(label_InputPath, "Path to PNG images.");
            // 
            // label_OutputPath
            // 
            label_OutputPath.AutoSize = true;
            label_OutputPath.Location = new Point(15, 49);
            label_OutputPath.Name = "label_OutputPath";
            label_OutputPath.Size = new Size(72, 15);
            label_OutputPath.TabIndex = 14;
            label_OutputPath.Text = "Output Path";
            MainTooltip.SetToolTip(label_OutputPath, "Path where output files will go.");
            // 
            // button_OutputPath
            // 
            button_OutputPath.Location = new Point(289, 66);
            button_OutputPath.Name = "button_OutputPath";
            button_OutputPath.Size = new Size(28, 25);
            button_OutputPath.TabIndex = 13;
            button_OutputPath.Text = "...";
            button_OutputPath.UseVisualStyleBackColor = true;
            button_OutputPath.Click += button_OutputPath_Click;
            // 
            // textBox_OutputPath
            // 
            textBox_OutputPath.AllowDrop = true;
            textBox_OutputPath.Location = new Point(12, 66);
            textBox_OutputPath.Name = "textBox_OutputPath";
            textBox_OutputPath.Size = new Size(272, 23);
            textBox_OutputPath.TabIndex = 12;
            textBox_OutputPath.DragDrop += textBox_OutputPath_DragDrop;
            textBox_OutputPath.DragEnter += textBox_OutputPath_DragEnter;
            textBox_OutputPath.Leave += textBox_OutputPath_Leave;
            // 
            // Form_MainDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 429);
            Controls.Add(label_OutputPath);
            Controls.Add(button_OutputPath);
            Controls.Add(textBox_OutputPath);
            Controls.Add(label_InputPath);
            Controls.Add(button_InputPath);
            Controls.Add(textBox_InputPath);
            Controls.Add(button_Clear);
            Controls.Add(button_Exit);
            Controls.Add(button_Start);
            Controls.Add(button_AddColors);
            Controls.Add(numBox_Tolerance);
            Controls.Add(button_ReplaceColor);
            Controls.Add(button_SourceColor);
            Controls.Add(MainControl_ListView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(345, 468);
            MinimizeBox = false;
            MinimumSize = new Size(345, 468);
            Name = "Form_MainDialog";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pixel Color Replacer v1.0.0";
            ((System.ComponentModel.ISupportInitialize)numBox_Tolerance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView MainControl_ListView;
        private ColumnHeader SourceColor;
        private ColumnHeader TargetColor;
        private ColumnHeader Tolerance;
        private Button button_SourceColor;
        private Button button_ReplaceColor;
        private NumericUpDown numBox_Tolerance;
        private Button button_AddColors;
        private Button button_Start;
        private Button button_Exit;
        private Button button_Clear;
        private TextBox textBox_InputPath;
        private Button button_InputPath;
        private Label label_InputPath;
        private Label label_OutputPath;
        private Button button_OutputPath;
        private TextBox textBox_OutputPath;
        private ToolTip MainTooltip;
    }
}
