namespace Lab1
{
    partial class Form1
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
            send_button = new Button();
            weight_textbox = new TextBox();
            age_textbox = new TextBox();
            height_textbox = new TextBox();
            gender_label = new Label();
            weight_label = new Label();
            height_label = new Label();
            age_label = new Label();
            man_radio = new RadioButton();
            woman_radio = new RadioButton();
            maintain_weight = new RadioButton();
            more_weight = new RadioButton();
            less_weight = new RadioButton();
            groupBox1 = new GroupBox();
            days_textbox = new TextBox();
            newWeight_textbox = new TextBox();
            days_label = new Label();
            newWeight_label = new Label();
            result_label = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // send_button
            // 
            send_button.Location = new Point(513, 357);
            send_button.Name = "send_button";
            send_button.Size = new Size(150, 59);
            send_button.TabIndex = 0;
            send_button.Text = "отправить";
            send_button.UseVisualStyleBackColor = true;
            send_button.Click += send_button_Click;
            // 
            // weight_textbox
            // 
            weight_textbox.Location = new Point(235, 99);
            weight_textbox.Name = "weight_textbox";
            weight_textbox.Size = new Size(125, 27);
            weight_textbox.TabIndex = 2;
            // 
            // age_textbox
            // 
            age_textbox.Location = new Point(584, 99);
            age_textbox.Name = "age_textbox";
            age_textbox.Size = new Size(125, 27);
            age_textbox.TabIndex = 3;
            // 
            // height_textbox
            // 
            height_textbox.Location = new Point(403, 99);
            height_textbox.Name = "height_textbox";
            height_textbox.Size = new Size(125, 27);
            height_textbox.TabIndex = 4;
            // 
            // gender_label
            // 
            gender_label.AutoSize = true;
            gender_label.Location = new Point(97, 63);
            gender_label.Name = "gender_label";
            gender_label.Size = new Size(37, 20);
            gender_label.TabIndex = 5;
            gender_label.Text = "Пол";
            // 
            // weight_label
            // 
            weight_label.AutoSize = true;
            weight_label.Location = new Point(279, 63);
            weight_label.Name = "weight_label";
            weight_label.Size = new Size(33, 20);
            weight_label.TabIndex = 6;
            weight_label.Text = "Вес";
            // 
            // height_label
            // 
            height_label.AutoSize = true;
            height_label.Location = new Point(437, 63);
            height_label.Name = "height_label";
            height_label.Size = new Size(39, 20);
            height_label.TabIndex = 7;
            height_label.Text = "Рост";
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Location = new Point(620, 63);
            age_label.Name = "age_label";
            age_label.Size = new Size(64, 20);
            age_label.TabIndex = 8;
            age_label.Text = "Возраст";
            // 
            // man_radio
            // 
            man_radio.AutoSize = true;
            man_radio.Location = new Point(49, 102);
            man_radio.Name = "man_radio";
            man_radio.Size = new Size(93, 24);
            man_radio.TabIndex = 9;
            man_radio.TabStop = true;
            man_radio.Text = "Мужской";
            man_radio.UseVisualStyleBackColor = true;
            // 
            // woman_radio
            // 
            woman_radio.AutoSize = true;
            woman_radio.Location = new Point(49, 141);
            woman_radio.Name = "woman_radio";
            woman_radio.Size = new Size(92, 24);
            woman_radio.TabIndex = 10;
            woman_radio.TabStop = true;
            woman_radio.Text = "Женский";
            woman_radio.UseVisualStyleBackColor = true;
            // 
            // maintain_weight
            // 
            maintain_weight.AutoSize = true;
            maintain_weight.Location = new Point(6, 26);
            maintain_weight.Name = "maintain_weight";
            maintain_weight.Size = new Size(163, 24);
            maintain_weight.TabIndex = 11;
            maintain_weight.TabStop = true;
            maintain_weight.Text = "Поддержание веса";
            maintain_weight.UseVisualStyleBackColor = true;
            // 
            // more_weight
            // 
            more_weight.AutoSize = true;
            more_weight.Location = new Point(6, 56);
            more_weight.Name = "more_weight";
            more_weight.Size = new Size(149, 24);
            more_weight.TabIndex = 12;
            more_weight.TabStop = true;
            more_weight.Text = "Увеличение веса";
            more_weight.UseVisualStyleBackColor = true;
            more_weight.CheckedChanged += more_weight_CheckedChanged;
            // 
            // less_weight
            // 
            less_weight.AutoSize = true;
            less_weight.Location = new Point(5, 86);
            less_weight.Name = "less_weight";
            less_weight.Size = new Size(137, 24);
            less_weight.TabIndex = 13;
            less_weight.TabStop = true;
            less_weight.Text = "Снижение веса";
            less_weight.UseVisualStyleBackColor = true;
            less_weight.CheckedChanged += less_weight_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(days_textbox);
            groupBox1.Controls.Add(newWeight_textbox);
            groupBox1.Controls.Add(days_label);
            groupBox1.Controls.Add(newWeight_label);
            groupBox1.Controls.Add(maintain_weight);
            groupBox1.Controls.Add(less_weight);
            groupBox1.Controls.Add(more_weight);
            groupBox1.Location = new Point(235, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 125);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Цель";
            // 
            // days_textbox
            // 
            days_textbox.Location = new Point(334, 64);
            days_textbox.Name = "days_textbox";
            days_textbox.Size = new Size(125, 27);
            days_textbox.TabIndex = 17;
            days_textbox.Visible = false;
            // 
            // newWeight_textbox
            // 
            newWeight_textbox.Location = new Point(187, 64);
            newWeight_textbox.Name = "newWeight_textbox";
            newWeight_textbox.Size = new Size(125, 27);
            newWeight_textbox.TabIndex = 16;
            newWeight_textbox.Visible = false;
            // 
            // days_label
            // 
            days_label.AutoSize = true;
            days_label.Location = new Point(348, 41);
            days_label.Name = "days_label";
            days_label.Size = new Size(101, 20);
            days_label.TabIndex = 15;
            days_label.Text = "Срок (в днях)";
            days_label.Visible = false;
            // 
            // newWeight_label
            // 
            newWeight_label.AutoSize = true;
            newWeight_label.Location = new Point(231, 41);
            newWeight_label.Name = "newWeight_label";
            newWeight_label.Size = new Size(33, 20);
            newWeight_label.TabIndex = 14;
            newWeight_label.Text = "Вес";
            newWeight_label.Visible = false;
            // 
            // result_label
            // 
            result_label.AutoSize = true;
            result_label.Location = new Point(12, 316);
            result_label.MinimumSize = new Size(300, 100);
            result_label.Name = "result_label";
            result_label.Size = new Size(300, 100);
            result_label.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result_label);
            Controls.Add(groupBox1);
            Controls.Add(woman_radio);
            Controls.Add(man_radio);
            Controls.Add(age_label);
            Controls.Add(height_label);
            Controls.Add(weight_label);
            Controls.Add(gender_label);
            Controls.Add(height_textbox);
            Controls.Add(age_textbox);
            Controls.Add(weight_textbox);
            Controls.Add(send_button);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button send_button;
        private TextBox weight_textbox;
        private TextBox age_textbox;
        private TextBox height_textbox;
        private Label gender_label;
        private Label weight_label;
        private Label height_label;
        private Label age_label;
        private RadioButton man_radio;
        private RadioButton woman_radio;
        private RadioButton maintain_weight;
        private RadioButton more_weight;
        private RadioButton less_weight;
        private GroupBox groupBox1;
        private TextBox days_textbox;
        private TextBox newWeight_textbox;
        private Label days_label;
        private Label newWeight_label;
        private Label result_label;
        /////
        public Button Send_button
        {
            get { return send_button;}
        }
        public TextBox Weight_textbox
        {
            get { return weight_textbox;}
        }
        public TextBox Age_textbox
        { get { return age_textbox; } }
public TextBox Height_textbox {get{ return height_textbox;}}
public RadioButton Man_radio { get { return man_radio;} }
public RadioButton Woman_radio { get { return woman_radio; } }
public RadioButton Maintain_weight { get { return maintain_weight; } }
public RadioButton More_weight { get { return more_weight; } }
public RadioButton Less_weight { get { return less_weight; } }
public TextBox Days_textbox { get { return days_textbox; } }
public TextBox NewWeight_textbox { get { return newWeight_textbox; } }
public Label Result_label { get { return result_label; } }
    }
}