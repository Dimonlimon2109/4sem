namespace Lab1
{
    public partial class Form1 : Form
    {
        Calculator calculator_calories = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            try
            {
                bool isMan = man_radio.Checked;
                double weight = Convert.ToDouble(weight_textbox.Text);
                int height = Convert.ToInt32(height_textbox.Text);
                int age = Convert.ToInt32(age_textbox.Text);
                int days = Convert.ToInt32(days_textbox.Text);
                double targetWeight = Convert.ToDouble(newWeight_textbox.Text);
                if (age < 18 || height < 140 || height > 251 || weight < 28 || weight > 1000 || age > 120 || days <= 0 || targetWeight < 28 || targetWeight > 1000)
                {
                    throw new FormatException("Введите корректные данные в поля");
                }
                int target = 0;
                if ((!man_radio.Checked && !woman_radio.Checked) || (!maintain_weight.Checked && !more_weight.Checked && !less_weight.Checked))
                {
                    MessageBox.Show("Выберите один из нескольких вариантов");
                    return;
                }
                if (maintain_weight.Checked)
                    target = 0;
                else if (more_weight.Checked)
                    target = 1;
                else if (less_weight.Checked)
                    target = -1;
                calculator_calories.analyze_weight(isMan, weight, height, age, target, targetWeight, days, ref result_label);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (UncorrectChooseException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void more_weight_CheckedChanged(object sender, EventArgs e)
        {
            if (more_weight.Checked)
            {
                newWeight_label.Visible = true;
                newWeight_textbox.Visible = true;
                days_label.Visible = true;
                days_textbox.Visible = true;
            }
            if (!more_weight.Checked)
            {
                newWeight_label.Visible = false;
                newWeight_textbox.Visible = false;
                days_label.Visible = false;
                days_textbox.Visible = false;
            }
        }

        private void less_weight_CheckedChanged(object sender, EventArgs e)
        {
            if (less_weight.Checked)
            {
                newWeight_label.Visible = true;
                newWeight_textbox.Visible = true;
                days_label.Visible = true;
                days_textbox.Visible = true;
            }
            if (!less_weight.Checked)
            {
                newWeight_label.Visible = false;
                newWeight_textbox.Visible = false;
                days_label.Visible = false;
                days_textbox.Visible = false;
            }
        }
    }
}