using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lab1
{

    public class UncorrectChooseException : Exception
    {
        // Конструктор класса, принимающий сообщение об ошибке
        public UncorrectChooseException(string message) : base(message)
        {
        }
    }


    interface ICalculator
    {
        void analyze_weight(bool isMan, double weight, int height, int age, int target, double target_weight, int days, ref Label result_label);
        double norm_calories(double weight, int height, int age, bool isMan);
        double weight_change(double currentWeight, double targetWeight, int days);
            }
    internal class Calculator:ICalculator
    {
        public Calculator() { }

        public double norm_calories(double weight, int height, int age, bool isMan)
        {
            if (isMan) return 10 * weight + 6.25 * height - 5 * age - 161;
            return 10 * weight + 6.25 * height - 5 * age + 5;
        }

        public double weight_change(double currentWeight, double targetWeight, int days)
        {
            double caloriesPerKilogram = 7700;

            double weightLossPerDay = Math.Abs(currentWeight - targetWeight) / days;

            double totalCaloricDeficit = weightLossPerDay * caloriesPerKilogram;

            double dailyCaloricDeficit = totalCaloricDeficit / days;

            return dailyCaloricDeficit;
        }

        public void analyze_weight(bool isMan, double weight, int height, int age, int target, double target_weight, int days, ref Label result_label)
        {
            double calories = 0;
            double normal_weight = 0;
            if(isMan)
            {
                normal_weight = (height - 100) * 0.9;
            }
            else {
                normal_weight = (height - 100) * 0.85;
            }
            if(age < 30)
            {
                normal_weight *= 0.89;
            }
            else if(age > 50)
            {
                normal_weight *= 1.06;
            }
            if(normal_weight == weight)
            {
                result_label.Text = "Ваш вес в норме";
            }
            else if(normal_weight < weight)
            {
                result_label.Text = "У вас присутствует лишний вес";
            }
            else
            {
                result_label.Text = "У вас недостаток веса";
            }
            calories = norm_calories(weight, height, age, isMan);
            if (target == 0)
            {
                result_label.Text += "\nНорма калорий: " + calories + " ккал";
            }

            if(target == -1)
            {
                if (target_weight > weight)
                {
                    throw new UncorrectChooseException("Для похудения ваш целевой вес должен быть меньше текущего");
                }
                calories = calories - weight_change(weight, target_weight, days);
                result_label.Text += "\nНорма калорий для похудения: " + calories + " ккал";
            }
            if(target == 1)
            {
                if (target_weight < weight)
                {
                    throw new UncorrectChooseException("Для набора ваш целевой вес должен быть больше текущего");
                }
                calories = calories + weight_change(weight, target_weight, days);
                result_label.Text += "\nНорма калорий для набора веса: " + calories + " ккал";
            }
        }

    }
}
