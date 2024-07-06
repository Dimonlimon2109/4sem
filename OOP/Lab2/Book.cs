using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Book
    {
        [RegularExpression(@"^[А-ЯA-Z][а-яa-z\-]*(\s[А-ЯA-Zа-яa-z][а-яa-z\-]*)*$", ErrorMessage = "Неправильный формат названия книги")]
        [Required]
        public string title { get; set; }

        [Required]
        public string format { get; set; }

        [Required]
        public decimal size { get; set; }

        [Required]
        public decimal pages { get; set; }

        [Udk]
        public string udk { get; set; }

        [RegularExpression(@"^\w+( \w+)*$", ErrorMessage = "Неправильный формат издательства")]
        [Required]
      public string publisher { get; set; }

        [Required]
      public int year { get; set; }


        [Authors]
      public List<Author> authors { get; set; }

        [Required]
      public DateTime date { get; set; }

        public Book(string title, string format, decimal size, decimal pages, string udk, string publisher, int year, List<Author> authors, DateTime date)
        {
            this.title = title;
            this.format = format;
            this.size = size;
            this.pages = pages;
            this.udk = udk;
            this.publisher = publisher;
            this.year = year;
            this.authors = authors;
            this.date = date;
        }
        public override string ToString()
        {
            string result_string = $"{title}, {year}, ";
            foreach (Author author in authors)
            {
                result_string += author.Fio + ", ";
            }
            return result_string;
        }
        public string BookInfo()
        {
            string result_string = $"Название: {title}\nГод: {year}\nАвторы: ";
            foreach (Author author in authors)
            {
                result_string += author.Fio + ", ";
            }
            return result_string + $"\nФормат: {format}\nРазмер файла: {size}мб\nКольво страниц: {(int)pages}\n" +
                $"УДК: {udk}\nИздатель: {publisher}\n Дата загрузки: {date.ToString("dd.MM.yyyy")}";
        }
    }
}
