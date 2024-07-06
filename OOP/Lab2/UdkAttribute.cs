using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab2
{
    public class UdkAttribute :ValidationAttribute
    {
        private string pattern_udk = @"^\d+\.\d+(\.\d+)*$";
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string string_value = (string)value;
            if(Regex.IsMatch(string_value, pattern_udk))
            {
                return ValidationResult.Success;
            }
            else
                return new ValidationResult("Недопустимый формат УДК");
        }
    }

    public class AuthorsAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            List<Author> new_value = (List<Author>)value; 
            if(new_value.Count == 0)
            {
                return new ValidationResult("Выберите автора!");
            }
            return ValidationResult.Success;
        }
    }
}