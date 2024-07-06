namespace Lab2
{
    partial class FindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            findLabel = new Label();
            findButton = new Button();
            yearTrackBar = new TrackBar();
            forTrackBarLabel = new Label();
            publisherFindTextbox = new TextBox();
            fromPages = new NumericUpDown();
            label1 = new Label();
            toPages = new NumericUpDown();
            RegExpCheckbox = new CheckBox();
            publisherCheckbox = new CheckBox();
            yearCheckbox = new CheckBox();
            PagesCheckbox = new CheckBox();
            yearFindLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)yearTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fromPages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toPages).BeginInit();
            SuspendLayout();
            // 
            // findLabel
            // 
            findLabel.AutoSize = true;
            findLabel.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            findLabel.Location = new Point(22, 62);
            findLabel.Name = "findLabel";
            findLabel.Size = new Size(101, 24);
            findLabel.TabIndex = 0;
            findLabel.Text = "Поиск по:";
            // 
            // findButton
            // 
            findButton.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            findButton.Location = new Point(216, 347);
            findButton.Name = "findButton";
            findButton.Size = new Size(94, 29);
            findButton.TabIndex = 5;
            findButton.Text = "Найти";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // yearTrackBar
            // 
            yearTrackBar.Location = new Point(173, 145);
            yearTrackBar.Name = "yearTrackBar";
            yearTrackBar.Size = new Size(130, 56);
            yearTrackBar.TabIndex = 6;
            yearTrackBar.Scroll += yearTrackBar_Scroll;
            yearTrackBar.Minimum = 1; yearTrackBar.Maximum = Convert.ToInt32(DateTime.Now.Year);
            // 
            // forTrackBarLabel
            // 
            forTrackBarLabel.AutoSize = true;
            forTrackBarLabel.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            forTrackBarLabel.Location = new Point(310, 176);
            forTrackBarLabel.Name = "forTrackBarLabel";
            forTrackBarLabel.Size = new Size(0, 24);
            forTrackBarLabel.TabIndex = 7;
            // 
            // publisherFindTextbox
            // 
            publisherFindTextbox.Location = new Point(173, 112);
            publisherFindTextbox.Name = "publisherFindTextbox";
            publisherFindTextbox.Size = new Size(156, 27);
            publisherFindTextbox.TabIndex = 8;
            // 
            // fromPages
            // 
            fromPages.Location = new Point(248, 203);
            fromPages.Maximum = new decimal(new int[] { 22000, 0, 0, 0 });
            fromPages.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            fromPages.Name = "fromPages";
            fromPages.Size = new Size(81, 27);
            fromPages.TabIndex = 19;
            fromPages.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(335, 206);
            label1.Name = "label1";
            label1.Size = new Size(33, 24);
            label1.TabIndex = 20;
            label1.Text = "до";
            // 
            // toPages
            // 
            toPages.Location = new Point(374, 202);
            toPages.Maximum = new decimal(new int[] { 22000, 0, 0, 0 });
            toPages.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            toPages.Name = "toPages";
            toPages.Size = new Size(81, 27);
            toPages.TabIndex = 21;
            toPages.Value = new decimal(new int[] { 22000, 0, 0, 0 });
            // 
            // RegExpCheckbox
            // 
            RegExpCheckbox.AutoSize = true;
            RegExpCheckbox.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegExpCheckbox.Location = new Point(22, 274);
            RegExpCheckbox.Name = "RegExpCheckbox";
            RegExpCheckbox.Size = new Size(336, 26);
            RegExpCheckbox.TabIndex = 22;
            RegExpCheckbox.Text = "Поддержка регулярных выражений";
            RegExpCheckbox.UseVisualStyleBackColor = true;
            // 
            // publisherCheckbox
            // 
            publisherCheckbox.AutoSize = true;
            publisherCheckbox.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            publisherCheckbox.Location = new Point(12, 112);
            publisherCheckbox.Name = "publisherCheckbox";
            publisherCheckbox.Size = new Size(154, 26);
            publisherCheckbox.TabIndex = 23;
            publisherCheckbox.Text = "Издательству:";
            publisherCheckbox.UseVisualStyleBackColor = true;
            publisherCheckbox.CheckedChanged += publisherCheckbox_CheckedChanged;
            // 
            // yearCheckbox
            // 
            yearCheckbox.AutoSize = true;
            yearCheckbox.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            yearCheckbox.Location = new Point(12, 155);
            yearCheckbox.Name = "yearCheckbox";
            yearCheckbox.Size = new Size(138, 26);
            yearCheckbox.TabIndex = 24;
            yearCheckbox.Text = "Год издания:";
            yearCheckbox.UseVisualStyleBackColor = true;
            yearCheckbox.CheckedChanged += yearCheckbox_CheckedChanged;
            // 
            // PagesCheckbox
            // 
            PagesCheckbox.AutoSize = true;
            PagesCheckbox.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PagesCheckbox.Location = new Point(12, 203);
            PagesCheckbox.Name = "PagesCheckbox";
            PagesCheckbox.Size = new Size(224, 26);
            PagesCheckbox.TabIndex = 25;
            PagesCheckbox.Text = "Диапазону страниц: от";
            PagesCheckbox.UseVisualStyleBackColor = true;
            PagesCheckbox.CheckedChanged += PagesCheckbox_CheckedChanged;
            // 
            // yearFindLabel
            // 
            yearFindLabel.AutoSize = true;
            yearFindLabel.Location = new Point(308, 176);
            yearFindLabel.Name = "yearFindLabel";
            yearFindLabel.Size = new Size(0, 20);
            yearFindLabel.TabIndex = 26;
            // 
            // FindForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 450);
            Controls.Add(yearFindLabel);
            Controls.Add(PagesCheckbox);
            Controls.Add(yearCheckbox);
            Controls.Add(publisherCheckbox);
            Controls.Add(RegExpCheckbox);
            Controls.Add(toPages);
            Controls.Add(label1);
            Controls.Add(fromPages);
            Controls.Add(publisherFindTextbox);
            Controls.Add(forTrackBarLabel);
            Controls.Add(yearTrackBar);
            Controls.Add(findButton);
            Controls.Add(findLabel);
            Name = "FindForm";
            Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)yearTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)fromPages).EndInit();
            ((System.ComponentModel.ISupportInitialize)toPages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label findLabel;
        private Label pagesFindLabel;
        private Label withRegLabel;
        private Button findButton;
        private TrackBar yearTrackBar;
        private Label forTrackBarLabel;
        private TextBox publisherFindTextbox;
        private NumericUpDown fromPages;
        private Label label1;
        private NumericUpDown toPages;
        private CheckBox RegExpCheckbox;
        private CheckBox publisherCheckbox;
        private CheckBox yearCheckbox;
        private CheckBox PagesCheckbox;
        private Label yearFindLabel;
    }
}