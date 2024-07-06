using System.Windows.Forms;

namespace Lab2
{
    partial class Electronic_library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Electronic_library));
            format_label = new Label();
            label1 = new Label();
            size_label = new Label();
            title_textbox = new TextBox();
            title_label = new Label();
            udk_label = new Label();
            label3 = new Label();
            publisher_label = new Label();
            autors_list_label = new Label();
            label4 = new Label();
            year_trackBar = new TrackBar();
            date = new DateTimePicker();
            publisher_textbox = new TextBox();
            save_button = new Button();
            download_button = new Button();
            pages = new NumericUpDown();
            year_number = new Label();
            books_list = new ListView();
            books_label = new Label();
            add_author_button = new Button();
            authors_list = new ListBox();
            udk_textbox = new TextBox();
            pdf_button = new RadioButton();
            docx_button = new RadioButton();
            fb2_button = new RadioButton();
            size = new NumericUpDown();
            year_label = new Label();
            title_error = new ErrorProvider(components);
            udk_error = new ErrorProvider(components);
            pub_error = new ErrorProvider(components);
            year_error = new ErrorProvider(components);
            menuStrip1 = new MenuStrip();
            поискToolStripMenuItem = new ToolStripMenuItem();
            поИздательствуToolStripMenuItem = new ToolStripMenuItem();
            поToolStripMenuItem = new ToolStripMenuItem();
            поДиапазонуСтраницToolStripMenuItem = new ToolStripMenuItem();
            сортировкаToolStripMenuItem = new ToolStripMenuItem();
            поНазваниюToolStripMenuItem = new ToolStripMenuItem();
            поДатеЗагрузкиToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            instruments_button = new CheckBox();
            currentDateLabel = new Label();
            currentTimeLabel = new Label();
            lastOperationLabel = new Label();
            currentDate = new Label();
            currentTime = new Label();
            lastOperation = new Label();
            totalCount = new Label();
            toolsMenu = new ToolStrip();
            backButton = new ToolStripButton();
            forwardButton = new ToolStripButton();
            findButton = new ToolStripButton();
            sortButton = new ToolStripButton();
            saveButton = new ToolStripButton();
            aboutButton = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)year_trackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)title_error).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udk_error).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pub_error).BeginInit();
            ((System.ComponentModel.ISupportInitialize)year_error).BeginInit();
            menuStrip1.SuspendLayout();
            toolsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // format_label
            // 
            format_label.AutoSize = true;
            format_label.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            format_label.Location = new Point(238, 161);
            format_label.Name = "format_label";
            format_label.Size = new Size(83, 24);
            format_label.TabIndex = 0;
            format_label.Text = "Формат";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 143);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // size_label
            // 
            size_label.AutoSize = true;
            size_label.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            size_label.Location = new Point(38, 211);
            size_label.Name = "size_label";
            size_label.Size = new Size(187, 24);
            size_label.TabIndex = 3;
            size_label.Text = "Размер файла(мб)";
            // 
            // title_textbox
            // 
            title_textbox.Location = new Point(155, 112);
            title_textbox.Name = "title_textbox";
            title_textbox.Size = new Size(232, 27);
            title_textbox.TabIndex = 4;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            title_label.Location = new Point(38, 115);
            title_label.Name = "title_label";
            title_label.Size = new Size(102, 24);
            title_label.TabIndex = 5;
            title_label.Text = "Название";
            // 
            // udk_label
            // 
            udk_label.AutoSize = true;
            udk_label.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            udk_label.Location = new Point(19, 161);
            udk_label.Name = "udk_label";
            udk_label.Size = new Size(50, 24);
            udk_label.TabIndex = 6;
            udk_label.Text = "УДК";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(38, 315);
            label3.Name = "label3";
            label3.Size = new Size(168, 24);
            label3.TabIndex = 7;
            label3.Text = "Коль-во страниц";
            // 
            // publisher_label
            // 
            publisher_label.AutoSize = true;
            publisher_label.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            publisher_label.Location = new Point(38, 363);
            publisher_label.Name = "publisher_label";
            publisher_label.Size = new Size(142, 24);
            publisher_label.TabIndex = 8;
            publisher_label.Text = "Издательство";
            // 
            // autors_list_label
            // 
            autors_list_label.AutoSize = true;
            autors_list_label.Font = new Font("Roboto", 10F);
            autors_list_label.Location = new Point(666, 112);
            autors_list_label.Name = "autors_list_label";
            autors_list_label.Size = new Size(71, 20);
            autors_list_label.TabIndex = 9;
            autors_list_label.Text = "Авторы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(38, 412);
            label4.Name = "label4";
            label4.Size = new Size(144, 24);
            label4.TabIndex = 10;
            label4.Text = "Дата загрузки";
            // 
            // year_trackBar
            // 
            year_trackBar.Location = new Point(227, 254);
            year_trackBar.Maximum = 2024;
            year_trackBar.Minimum = 1;
            year_trackBar.Name = "year_trackBar";
            year_trackBar.Size = new Size(130, 56);
            year_trackBar.TabIndex = 13;
            year_trackBar.Value = 2024;
            year_trackBar.Scroll += year_trackBar_Scroll;
            // 
            // date
            // 
            date.CalendarFont = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            date.Location = new Point(197, 412);
            date.MaxDate = new DateTime(2024, 3, 15, 0, 0, 0, 0);
            date.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            date.Name = "date";
            date.Size = new Size(190, 27);
            date.TabIndex = 14;
            date.Value = new DateTime(2024, 3, 15, 0, 0, 0, 0);
            // 
            // publisher_textbox
            // 
            publisher_textbox.Location = new Point(197, 360);
            publisher_textbox.Name = "publisher_textbox";
            publisher_textbox.Size = new Size(218, 27);
            publisher_textbox.TabIndex = 15;
            // 
            // save_button
            // 
            save_button.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            save_button.Location = new Point(18, 470);
            save_button.Name = "save_button";
            save_button.Size = new Size(188, 51);
            save_button.TabIndex = 16;
            save_button.Text = "Сохранить";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // download_button
            // 
            download_button.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            download_button.Location = new Point(227, 470);
            download_button.Name = "download_button";
            download_button.Size = new Size(188, 51);
            download_button.TabIndex = 17;
            download_button.Text = "Загрузить";
            download_button.UseVisualStyleBackColor = true;
            download_button.Click += download_button_Click;
            // 
            // pages
            // 
            pages.Location = new Point(254, 316);
            pages.Maximum = new decimal(new int[] { 22000, 0, 0, 0 });
            pages.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            pages.Name = "pages";
            pages.Size = new Size(81, 27);
            pages.TabIndex = 18;
            pages.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // year_number
            // 
            year_number.AutoSize = true;
            year_number.Font = new Font("Roboto", 9F);
            year_number.Location = new Point(343, 274);
            year_number.MaximumSize = new Size(30, 30);
            year_number.MinimumSize = new Size(50, 15);
            year_number.Name = "year_number";
            year_number.Size = new Size(50, 18);
            year_number.TabIndex = 19;
            year_number.Text = "2024";
            // 
            // books_list
            // 
            books_list.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            books_list.Location = new Point(933, 143);
            books_list.Name = "books_list";
            books_list.Size = new Size(654, 404);
            books_list.TabIndex = 20;
            books_list.UseCompatibleStateImageBehavior = false;
            books_list.View = View.List;
            // 
            // books_label
            // 
            books_label.AutoSize = true;
            books_label.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            books_label.Location = new Point(1318, 112);
            books_label.Name = "books_label";
            books_label.Size = new Size(67, 24);
            books_label.TabIndex = 21;
            books_label.Text = "Книги";
            // 
            // add_author_button
            // 
            add_author_button.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            add_author_button.Location = new Point(594, 553);
            add_author_button.Name = "add_author_button";
            add_author_button.Size = new Size(188, 51);
            add_author_button.TabIndex = 22;
            add_author_button.Text = "Добавить автора";
            add_author_button.UseVisualStyleBackColor = true;
            add_author_button.Click += add_author_button_Click;
            // 
            // authors_list
            // 
            authors_list.Font = new Font("Roboto", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            authors_list.FormattingEnabled = true;
            authors_list.Location = new Point(503, 143);
            authors_list.Name = "authors_list";
            authors_list.SelectionMode = SelectionMode.MultiExtended;
            authors_list.Size = new Size(412, 404);
            authors_list.TabIndex = 23;
            // 
            // udk_textbox
            // 
            udk_textbox.Location = new Point(84, 161);
            udk_textbox.Name = "udk_textbox";
            udk_textbox.Size = new Size(122, 27);
            udk_textbox.TabIndex = 24;
            // 
            // pdf_button
            // 
            pdf_button.AutoSize = true;
            pdf_button.Checked = true;
            pdf_button.Location = new Point(327, 164);
            pdf_button.Name = "pdf_button";
            pdf_button.Size = new Size(53, 24);
            pdf_button.TabIndex = 25;
            pdf_button.TabStop = true;
            pdf_button.Text = "pdf";
            pdf_button.UseVisualStyleBackColor = true;
            // 
            // docx_button
            // 
            docx_button.AutoSize = true;
            docx_button.Location = new Point(377, 164);
            docx_button.Name = "docx_button";
            docx_button.Size = new Size(62, 24);
            docx_button.TabIndex = 26;
            docx_button.TabStop = true;
            docx_button.Text = "docx";
            docx_button.UseVisualStyleBackColor = true;
            // 
            // fb2_button
            // 
            fb2_button.AutoSize = true;
            fb2_button.Location = new Point(445, 164);
            fb2_button.Name = "fb2_button";
            fb2_button.Size = new Size(52, 24);
            fb2_button.TabIndex = 27;
            fb2_button.TabStop = true;
            fb2_button.Text = "fb2";
            fb2_button.UseVisualStyleBackColor = true;
            // 
            // size
            // 
            size.DecimalPlaces = 3;
            size.Location = new Point(254, 212);
            size.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            size.Name = "size";
            size.Size = new Size(81, 27);
            size.TabIndex = 28;
            size.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // year_label
            // 
            year_label.AutoSize = true;
            year_label.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            year_label.Location = new Point(99, 271);
            year_label.Name = "year_label";
            year_label.Size = new Size(41, 24);
            year_label.TabIndex = 29;
            year_label.Text = "Год";
            // 
            // title_error
            // 
            title_error.ContainerControl = this;
            // 
            // udk_error
            // 
            udk_error.ContainerControl = this;
            // 
            // pub_error
            // 
            pub_error.ContainerControl = this;
            // 
            // year_error
            // 
            year_error.ContainerControl = this;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { поискToolStripMenuItem, сортировкаToolStripMenuItem, сохранитьToolStripMenuItem, оПрограммеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1593, 30);
            menuStrip1.TabIndex = 30;
            menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            поискToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поИздательствуToolStripMenuItem, поToolStripMenuItem, поДиапазонуСтраницToolStripMenuItem });
            поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            поискToolStripMenuItem.Size = new Size(76, 26);
            поискToolStripMenuItem.Text = "Поиск";
            // 
            // поИздательствуToolStripMenuItem
            // 
            поИздательствуToolStripMenuItem.Name = "поИздательствуToolStripMenuItem";
            поИздательствуToolStripMenuItem.Size = new Size(280, 26);
            поИздательствуToolStripMenuItem.Text = "по издательству";
            поИздательствуToolStripMenuItem.Click += поИздательствуToolStripMenuItem_Click;
            // 
            // поToolStripMenuItem
            // 
            поToolStripMenuItem.Name = "поToolStripMenuItem";
            поToolStripMenuItem.Size = new Size(280, 26);
            поToolStripMenuItem.Text = "по году издания";
            поToolStripMenuItem.Click += поToolStripMenuItem_Click;
            // 
            // поДиапазонуСтраницToolStripMenuItem
            // 
            поДиапазонуСтраницToolStripMenuItem.Name = "поДиапазонуСтраницToolStripMenuItem";
            поДиапазонуСтраницToolStripMenuItem.Size = new Size(280, 26);
            поДиапазонуСтраницToolStripMenuItem.Text = "по диапазону страниц";
            поДиапазонуСтраницToolStripMenuItem.Click += поДиапазонуСтраницToolStripMenuItem_Click;
            // 
            // сортировкаToolStripMenuItem
            // 
            сортировкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поНазваниюToolStripMenuItem, поДатеЗагрузкиToolStripMenuItem });
            сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            сортировкаToolStripMenuItem.Size = new Size(124, 26);
            сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поНазваниюToolStripMenuItem
            // 
            поНазваниюToolStripMenuItem.Name = "поНазваниюToolStripMenuItem";
            поНазваниюToolStripMenuItem.Size = new Size(236, 26);
            поНазваниюToolStripMenuItem.Text = "по названию";
            поНазваниюToolStripMenuItem.Click += поНазваниюToolStripMenuItem_Click;
            // 
            // поДатеЗагрузкиToolStripMenuItem
            // 
            поДатеЗагрузкиToolStripMenuItem.Name = "поДатеЗагрузкиToolStripMenuItem";
            поДатеЗагрузкиToolStripMenuItem.Size = new Size(236, 26);
            поДатеЗагрузкиToolStripMenuItem.Text = "по дате загрузки";
            поДатеЗагрузкиToolStripMenuItem.Click += поДатеЗагрузкиToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(114, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(134, 26);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // instruments_button
            // 
            instruments_button.AutoSize = true;
            instruments_button.Checked = true;
            instruments_button.CheckState = CheckState.Checked;
            instruments_button.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            instruments_button.Location = new Point(589, 60);
            instruments_button.Name = "instruments_button";
            instruments_button.Size = new Size(148, 26);
            instruments_button.TabIndex = 31;
            instruments_button.Text = "Инструменты";
            instruments_button.UseVisualStyleBackColor = true;
            instruments_button.CheckedChanged += instruments_button_CheckedChanged;
            // 
            // currentDateLabel
            // 
            currentDateLabel.AutoSize = true;
            currentDateLabel.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            currentDateLabel.Location = new Point(0, 553);
            currentDateLabel.Name = "currentDateLabel";
            currentDateLabel.Size = new Size(57, 22);
            currentDateLabel.TabIndex = 32;
            currentDateLabel.Text = "Дата:";
            // 
            // currentTimeLabel
            // 
            currentTimeLabel.AutoSize = true;
            currentTimeLabel.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            currentTimeLabel.Location = new Point(4, 589);
            currentTimeLabel.Name = "currentTimeLabel";
            currentTimeLabel.Size = new Size(145, 22);
            currentTimeLabel.TabIndex = 33;
            currentTimeLabel.Text = "Текущее время:";
            // 
            // lastOperationLabel
            // 
            lastOperationLabel.AutoSize = true;
            lastOperationLabel.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lastOperationLabel.Location = new Point(4, 625);
            lastOperationLabel.Name = "lastOperationLabel";
            lastOperationLabel.Size = new Size(192, 22);
            lastOperationLabel.TabIndex = 34;
            lastOperationLabel.Text = "Последняя операция:";
            // 
            // currentDate
            // 
            currentDate.AutoSize = true;
            currentDate.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            currentDate.Location = new Point(63, 553);
            currentDate.Name = "currentDate";
            currentDate.Size = new Size(0, 22);
            currentDate.TabIndex = 35;
            // 
            // currentTime
            // 
            currentTime.AutoSize = true;
            currentTime.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            currentTime.Location = new Point(155, 589);
            currentTime.Name = "currentTime";
            currentTime.Size = new Size(0, 22);
            currentTime.TabIndex = 36;
            // 
            // lastOperation
            // 
            lastOperation.AutoSize = true;
            lastOperation.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lastOperation.Location = new Point(202, 625);
            lastOperation.Name = "lastOperation";
            lastOperation.Size = new Size(0, 22);
            lastOperation.TabIndex = 37;
            // 
            // totalCount
            // 
            totalCount.AutoSize = true;
            totalCount.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            totalCount.Location = new Point(1140, 553);
            totalCount.Name = "totalCount";
            totalCount.Size = new Size(0, 22);
            totalCount.TabIndex = 38;
            // 
            // toolsMenu
            // 
            toolsMenu.ImageScalingSize = new Size(20, 20);
            toolsMenu.Items.AddRange(new ToolStripItem[] { backButton, forwardButton, findButton, sortButton, saveButton, aboutButton });
            toolsMenu.Location = new Point(0, 30);
            toolsMenu.Name = "toolsMenu";
            toolsMenu.Size = new Size(1593, 27);
            toolsMenu.TabIndex = 39;
            toolsMenu.Text = "toolStrip1";
            // 
            // backButton
            // 
            backButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.ImageTransparentColor = Color.Magenta;
            backButton.Name = "backButton";
            backButton.Size = new Size(29, 24);
            backButton.Text = "toolStripButton1";
            backButton.Click += backButton_Click;
            // 
            // forwardButton
            // 
            forwardButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            forwardButton.Image = (Image)resources.GetObject("forwardButton.Image");
            forwardButton.ImageTransparentColor = Color.Magenta;
            forwardButton.Name = "forwardButton";
            forwardButton.Size = new Size(29, 24);
            forwardButton.Text = "toolStripButton2";
            forwardButton.Click += forwardButton_Click;
            // 
            // findButton
            // 
            findButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            findButton.Image = (Image)resources.GetObject("findButton.Image");
            findButton.ImageTransparentColor = Color.Magenta;
            findButton.Name = "findButton";
            findButton.Size = new Size(29, 24);
            findButton.Text = "toolStripButton3";
            findButton.Click += findButton_Click;
            // 
            // sortButton
            // 
            sortButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            sortButton.Image = (Image)resources.GetObject("sortButton.Image");
            sortButton.ImageTransparentColor = Color.Magenta;
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(29, 24);
            sortButton.Text = "toolStripButton4";
            sortButton.Click += sortButton_Click;
            // 
            // saveButton
            // 
            saveButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveButton.Image = (Image)resources.GetObject("saveButton.Image");
            saveButton.ImageTransparentColor = Color.Magenta;
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(29, 24);
            saveButton.Text = "toolStripButton5";
            saveButton.Click += saveButton_Click;
            // 
            // aboutButton
            // 
            aboutButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            aboutButton.Image = (Image)resources.GetObject("aboutButton.Image");
            aboutButton.ImageTransparentColor = Color.Magenta;
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(29, 24);
            aboutButton.Text = "toolStripButton6";
            aboutButton.Click += aboutButton_Click;
            // 
            // Electronic_library
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(1593, 656);
            Controls.Add(toolsMenu);
            Controls.Add(totalCount);
            Controls.Add(lastOperation);
            Controls.Add(currentTime);
            Controls.Add(currentDate);
            Controls.Add(lastOperationLabel);
            Controls.Add(currentTimeLabel);
            Controls.Add(currentDateLabel);
            Controls.Add(instruments_button);
            Controls.Add(year_label);
            Controls.Add(size);
            Controls.Add(fb2_button);
            Controls.Add(docx_button);
            Controls.Add(pdf_button);
            Controls.Add(udk_textbox);
            Controls.Add(authors_list);
            Controls.Add(add_author_button);
            Controls.Add(books_label);
            Controls.Add(books_list);
            Controls.Add(year_number);
            Controls.Add(pages);
            Controls.Add(download_button);
            Controls.Add(save_button);
            Controls.Add(publisher_textbox);
            Controls.Add(date);
            Controls.Add(year_trackBar);
            Controls.Add(label4);
            Controls.Add(autors_list_label);
            Controls.Add(publisher_label);
            Controls.Add(label3);
            Controls.Add(udk_label);
            Controls.Add(title_label);
            Controls.Add(title_textbox);
            Controls.Add(size_label);
            Controls.Add(label1);
            Controls.Add(format_label);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Electronic_library";
            Text = "Библиотека";
            Load += Electronic_library_Load;
            ((System.ComponentModel.ISupportInitialize)year_trackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pages).EndInit();
            ((System.ComponentModel.ISupportInitialize)size).EndInit();
            ((System.ComponentModel.ISupportInitialize)title_error).EndInit();
            ((System.ComponentModel.ISupportInitialize)udk_error).EndInit();
            ((System.ComponentModel.ISupportInitialize)pub_error).EndInit();
            ((System.ComponentModel.ISupportInitialize)year_error).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolsMenu.ResumeLayout(false);
            toolsMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private List<Author> authorList = new List<Author>();
        private List<Book> books = new List<Book>();
        private Label format_label;
        private Label label1;
        private Label size_label;
        private TextBox title_textbox;
        private Label title_label;
        private Label udk_label;
        private Label label3;
        private Label publisher_label;
        private Label autors_list_label;
        private Label label4;
        private TrackBar year_trackBar;
        private DateTimePicker date;
        private TextBox publisher_textbox;
        private Button save_button;
        private Button download_button;
        private NumericUpDown pages;
        private Label year_number;
        private ListView books_list;
        private Label books_label;
        private Button add_author_button;
        private ListBox authors_list;
        private TextBox udk_textbox;
        private RadioButton pdf_button;
        private RadioButton docx_button;
        private RadioButton fb2_button;
        private NumericUpDown size;
        private Label year_label;
        private ErrorProvider title_error;
        private ErrorProvider udk_error;
        private ErrorProvider pub_error;
        private ErrorProvider year_error;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripMenuItem сортировкаToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private CheckBox instruments_button;
        private ToolStripMenuItem поИздательствуToolStripMenuItem;
        private ToolStripMenuItem поToolStripMenuItem;
        private ToolStripMenuItem поДиапазонуСтраницToolStripMenuItem;
        private ToolStripMenuItem поНазваниюToolStripMenuItem;
        private ToolStripMenuItem поДатеЗагрузкиToolStripMenuItem;
        private Label lastOperationLabel;
        private Label currentTimeLabel;
        private Label currentDateLabel;
        private Label currentDate;
        private Label currentTime;
        private Label totalCount;
        private Label lastOperation;
        private ToolStrip toolsMenu;
        private ToolStripButton backButton;
        private ToolStripButton forwardButton;
        private ToolStripButton findButton;
        private ToolStripButton sortButton;
        private ToolStripButton saveButton;
        private ToolStripButton aboutButton;

        public List<Author> AuthorList { get => authorList; set => authorList = value; }
    }
}
