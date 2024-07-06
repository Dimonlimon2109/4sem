using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    [Serializable]
    public class Author
    {
        [RegularExpression(@"^[А-ЯЁ][а-яё]+\s[А-ЯЁ][а-яё]+\s[А-ЯЁ][а-яё]+$", ErrorMessage = "Неправильный формат ФИО")]
        [Required]
        public string Fio { get; set; }
        [Required]
        public string Country {  get; set; }

        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Неправильный формат ID")]
        [Required]
        public string Id { get; set; }
        public Author(string Fio, string Country, string Id)
        {
            this.Fio = Fio;
            this.Country = Country;
            this.Id = Id;
        }
        public override string ToString()
        {
            return $"{Fio}, {Country}, {Id}";
        }
    }
}
