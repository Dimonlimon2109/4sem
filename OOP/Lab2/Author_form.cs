using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Lab2
{
    public partial class Author_form : Form
    {
        Electronic_library lib;
        public Author_form(Electronic_library lib)
        {
            InitializeComponent();
            this.lib = lib;

        }

        private void add_button_Click(object sender, EventArgs e)
        {
                Author author = new Author(Convert.ToString(fio_textbox.Text), Convert.ToString(country_textbox.Text), Convert.ToString(id_textbox.Text));
                ValidationContext validationContext = new ValidationContext(author);
                List<ValidationResult> results = new List<ValidationResult>();
                if (Validator.TryValidateObject(author, validationContext, results, true))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    using (StreamWriter file = new StreamWriter("authors.json", append: true))
                    {
                        serializer.Serialize(file, author);
                        file.Write("\n");
                    }
                    lib.AddItemToListBox(author);
                    lib.AuthorList.Add(author);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка");
                    MessageBox.Show(results.First().ErrorMessage);
                }
        }
    }
}
