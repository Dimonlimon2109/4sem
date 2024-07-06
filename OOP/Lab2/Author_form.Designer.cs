namespace Lab2
{
    partial class Author_form
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
            components = new System.ComponentModel.Container();
            fio_label = new Label();
            fio_textbox = new TextBox();
            country_label = new Label();
            id_label = new Label();
            id_textbox = new TextBox();
            add_button = new Button();
            fio_error = new ErrorProvider(components);
            country_error = new ErrorProvider(components);
            id_error = new ErrorProvider(components);
            country_textbox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)fio_error).BeginInit();
            ((System.ComponentModel.ISupportInitialize)country_error).BeginInit();
            ((System.ComponentModel.ISupportInitialize)id_error).BeginInit();
            SuspendLayout();
            // 
            // fio_label
            // 
            fio_label.AutoSize = true;
            fio_label.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fio_label.Location = new Point(121, 37);
            fio_label.Name = "fio_label";
            fio_label.Size = new Size(53, 24);
            fio_label.TabIndex = 10;
            fio_label.Text = "ФИО";
            // 
            // fio_textbox
            // 
            fio_textbox.Location = new Point(12, 73);
            fio_textbox.Name = "fio_textbox";
            fio_textbox.Size = new Size(287, 27);
            fio_textbox.TabIndex = 11;
            // 
            // country_label
            // 
            country_label.AutoSize = true;
            country_label.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            country_label.Location = new Point(121, 118);
            country_label.Name = "country_label";
            country_label.Size = new Size(78, 24);
            country_label.TabIndex = 12;
            country_label.Text = "Страна";
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            id_label.Location = new Point(146, 197);
            id_label.Name = "id_label";
            id_label.Size = new Size(28, 24);
            id_label.TabIndex = 14;
            id_label.Text = "ID";
            // 
            // id_textbox
            // 
            id_textbox.Location = new Point(12, 224);
            id_textbox.Name = "id_textbox";
            id_textbox.Size = new Size(287, 27);
            id_textbox.TabIndex = 15;
            // 
            // add_button
            // 
            add_button.BackColor = SystemColors.Highlight;
            add_button.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            add_button.Location = new Point(99, 263);
            add_button.Name = "add_button";
            add_button.Size = new Size(120, 34);
            add_button.TabIndex = 16;
            add_button.Text = "Добавить";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
            // 
            // fio_error
            // 
            fio_error.ContainerControl = this;
            // 
            // country_error
            // 
            country_error.ContainerControl = this;
            // 
            // id_error
            // 
            id_error.ContainerControl = this;
            // 
            // country_textbox
            // 
            country_textbox.DropDownStyle = ComboBoxStyle.DropDownList;
            country_textbox.FormattingEnabled = true;
            country_textbox.Items.AddRange(new object[] { "Афганистан", "Албания", "Алжир", "Андорра", "Ангола", "Антигуа и Барбуда", "Аргентина", "Армения", "Австралия", "Австрия", "Азербайджан", "Багамы", "Бахрейн", "Бангладеш", "Барбадос", "Беларусь", "Белиз", "Бенин", "Бутан", "Боливия", "Босния и Герцеговина", "Ботсвана", "Бразилия", "Бруней", "Болгария", "Буркина-Фасо", "Бурунди", "Кабо-Верде", "Камбоджа", "Камерун", "Канада", "Центральноафриканская Республика", "Чад", "Чили", "Китай", "Колумбия", "Коморы", "Конго (Демократическая Республика)", "Конго (Республика)", "Коста-Рика", "Хорватия", "Куба", "Кипр", "Чехия", "Дания", "Джибути", "Доминика", "Доминиканская Республика", "Восточный Тимор", "Эквадор", "Египет", "Сальвадор", "Экваториальная Гвинея", "Эритрея", "Эстония", "Эфиопия", "Фиджи", "Финляндия", "Франция", "Габон", "Гамбия", "Грузия", "Германия", "Гана", "Греция", "Гренада", "Гватемала", "Гвинея", "Гвинея-Бисау", "Гайана", "Гаити", "Гондурас", "Венгрия", "Исландия", "Индия", "Индонезия", "Иран", "Ирак", "Ирландия", "Израиль", "Италия", "Ямайка", "Япония", "Иордания", "Казахстан", "Кения", "Кирибати", "Корея (Северная)", "Корея (Южная)", "Кувейт", "Киргизия", "Лаос", "Латвия", "Ливан", "Лесото", "Либерия", "Ливия", "Лихтенштейн", "Литва", "Люксембург", "Македония", "Мадагаскар", "Малави", "Малайзия", "Мальдивы", "Мали", "Мальта", "Маршалловы Острова", "Мавритания", "Маврикий", "Мексика", "Микронезия", "Молдавия", "Монако", "Монголия", "Черногория", "Марокко", "Мозамбик", "Мьянма (Бирма)", "Намибия", "Науру", "Непал", "Нидерланды", "Новая Зеландия", "Никарагуа", "Нигер", "Нигерия", "Норвегия", "Оман", "Пакистан", "Палау", "Панама", "Папуа-Новая Гвинея", "Парагвай", "Перу", "Филиппины", "Польша", "Португалия", "Катар", "Румыния", "Россия", "Руанда", "Сент-Китс и Невис", "Сент-Люсия", "Сент-Винсент и Гренадины", "Самоа", "Сан-Марино", "Сан-Томе и Принсипи", "Саудовская Аравия", "Сенегал", "Сербия", "Сейшельские Острова", "Сьерра-Леоне", "Сингапур", "Словакия", "Словения", "Соломоновы Острова", "Сомали", "Южная Африка" });
            country_textbox.Location = new Point(65, 154);
            country_textbox.Name = "country_textbox";
            country_textbox.Size = new Size(192, 28);
            country_textbox.TabIndex = 17;
            // 
            // Author_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(321, 318);
            Controls.Add(country_textbox);
            Controls.Add(add_button);
            Controls.Add(id_textbox);
            Controls.Add(id_label);
            Controls.Add(country_label);
            Controls.Add(fio_textbox);
            Controls.Add(fio_label);
            Name = "Author_form";
            Text = "Author";
            ((System.ComponentModel.ISupportInitialize)fio_error).EndInit();
            ((System.ComponentModel.ISupportInitialize)country_error).EndInit();
            ((System.ComponentModel.ISupportInitialize)id_error).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fio_label;
        private TextBox fio_textbox;
        private Label country_label;
        private Label id_label;
        private TextBox id_textbox;
        private Button add_button;
        private ErrorProvider fio_error;
        private ErrorProvider country_error;
        private ErrorProvider id_error;
        private ComboBox country_textbox;
    }
}