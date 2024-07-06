using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Electronic_library : Form
    {

        private System.Windows.Forms.Timer _timer;

        public Operation operation = new Operation();

        private List<Book> searchBooks = new List<Book>();
        public List<Book> SearchBooks { get => searchBooks; set => searchBooks = value; }

        private List<Book> sortBooks = new List<Book>();

        public List<Book> SortBooks { get => sortBooks; set => sortBooks = value; }

        public Electronic_library()
        {
            InitializeComponent();
            _timer = new System.Windows.Forms.Timer() { Interval = 1000 };
            _timer.Start();
            _timer.Tick += CurrentTime_Tick;
            _timer.Tick += CurrentDate_Tick;
            _timer.Tick += BooksCount_Tick;
            _timer.Tick += LastOperation_Tick;
        }

        void CurrentTime_Tick(object sender, EventArgs e)
        {
            currentTime.Text = DateTime.Now.ToLongTimeString();
        }
        void CurrentDate_Tick(object sender, EventArgs e)
        {
            currentDate.Text = DateTime.Now.ToShortDateString();
        }
        void BooksCount_Tick(object sender, EventArgs e)
        {
            totalCount.Text = books.Count.ToString();
        }
        void LastOperation_Tick(object sender, EventArgs e)
        {
            lastOperation.Text = operation.GetString();
        }
        public bool ValidId(string id)
        {
            foreach (Author author in authorList)
            {
                if (author.Id == id)
                {
                    return false;
                }
            }
            return true;
        }

        public void ClearForm()
        {
            title_textbox.Clear();
            udk_textbox.Clear();
            publisher_textbox.Clear();
            size.Value = 1;
            year_trackBar.Value = DateTime.Now.Year;
            year_label.Text = DateTime.Now.Year.ToString();
            pages.Value = 1;
            date.Value = DateTime.Now.Date;
            authors_list.SelectedIndex = -1;
        }
        public void AddItemToListBox(Author author)
        {
            if (author != null)
            {
                authors_list.Items.Add(author.ToString());
            }
        }
        private void year_trackBar_Scroll(object sender, EventArgs e)
        {
            year_number.Text = Convert.ToString(year_trackBar.Value);
        }

        private void add_author_button_Click(object sender, EventArgs e)
        {
            new Author_form(this).Show();
            operation.OperationType = AllOperationType.AddAuthor;
        }

        private void Electronic_library_Load(object sender, EventArgs e)
        {
            this.ActiveControl = title_label;
            if (File.Exists("authors.json"))
            {
                string json = File.ReadAllText("authors.json");
                using (StreamReader file = File.OpenText("authors.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();

                    while (file.Peek() >= 0)
                    {
                        string jsonLine = file.ReadLine();
                        authorList.Add(JsonConvert.DeserializeObject<Author>(jsonLine));
                    }
                }
                foreach (Author author in authorList)
                {
                    authors_list.Items.Add(author.ToString());
                }
            }
            if (File.Exists("books.json"))
            {
                string json = File.ReadAllText("books.json");
                using (StreamReader file = File.OpenText("books.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();

                    while (file.Peek() >= 0)
                    {
                        string jsonLine = file.ReadLine();
                        books.Add(JsonConvert.DeserializeObject<Book>(jsonLine));
                    }
                }
                foreach (Book book in books)
                {
                    books_list.Items.Add(book.ToString());
                }
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {


            string format = "";
            if (fb2_button.Checked)
            {
                format = fb2_button.Text;
            }
            else if (docx_button.Checked)
            {
                format = docx_button.Text;
            }
            else if (pdf_button.Checked)
            {
                format = pdf_button.Text;
            }
            List<Author> chosen_authors = new List<Author>();
            foreach (int selectedIndex in authors_list.SelectedIndices)
            {
                chosen_authors.Add(authorList[selectedIndex]);
            }
            Book book = new Book(title_textbox.Text, format, Convert.ToDecimal(size.Value),
                Convert.ToDecimal(pages.Value), udk_textbox.Text, publisher_textbox.Text, year_trackBar.Value, chosen_authors, date.Value);
            ValidationContext validationContext = new ValidationContext(book);
            List<ValidationResult> results = new List<ValidationResult>();
            if (Validator.TryValidateObject(book, validationContext, results, true))
            {

                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter file = new StreamWriter("books.json", append: true))
                {
                    serializer.Serialize(file, book);
                    file.Write("\n");
                }
                books.Add(book);
                books_list.Items.Add(book.ToString());
                ClearForm();
                operation.OperationType = AllOperationType.Save;
            }
            else
            {
                MessageBox.Show("Ошибка");
                MessageBox.Show(results.First().ErrorMessage);
            }
        }

        private void download_button_Click(object sender, EventArgs e)
        {
            if (books_list.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну книгу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (int index in books_list.SelectedIndices)
                {
                    MessageBox.Show(books[index].BookInfo(), "Книга");
                }
            }
            operation.OperationType = AllOperationType.Load;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия: 1.0\nРазработчик: Страпко Вадим Юрьевич", "О программе");
            operation.OperationType = AllOperationType.AboutProgram;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operation.OperationType = AllOperationType.Save;
            if (sortBooks.Count == 0)
            {
                MessageBox.Show("Не обнаружено результатов сортировки!");
            }
            else
            {
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter file = new StreamWriter("sortBooks.json"))
                {
                    foreach (Book book in sortBooks)
                    {
                        serializer.Serialize(file, book);
                        file.Write("\n");
                    }
                }
                MessageBox.Show("Результаты сортировки записаны в файл!");
            }
            if (searchBooks.Count == 0)
            {
                MessageBox.Show("Не обнаружено результатов поиска!");
            }
            else
            {
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter file = new StreamWriter("searchBooks.json"))
                {
                    foreach (Book book in searchBooks)
                    {
                        serializer.Serialize(file, book);
                        file.Write("\n");
                    }
                }
                MessageBox.Show("Результаты поиска записаны в файл!");
            }
        }

        private void SaveData(string path)
        {

        }

        private void поИздательствуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FindForm(this, books, 1).Show();
            operation.OperationType = AllOperationType.Search;
        }

        private void поToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FindForm(this, books, 2).Show();
            operation.OperationType = AllOperationType.Search;
        }

        private void поДиапазонуСтраницToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FindForm(this, books, 3).Show();
            operation.OperationType = AllOperationType.Search;
        }

        private void поНазваниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operation.OperationType = AllOperationType.Sort;
            if (books.Count != 0)
            {
                sortBooks = books.OrderBy(a => a.title).ToList();
            }
            ReplaceListOfDisciplines();
        }

        private void поДатеЗагрузкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operation.OperationType = AllOperationType.Sort;
            if (books.Count != 0)
            {
                sortBooks = books.OrderBy(a => a.date).ToList();
            }
            ReplaceListOfDisciplines();
        }

        private void ReplaceListOfDisciplines()
        {
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter file = new StreamWriter("books.json"))
                {
                    foreach (Book book in sortBooks)
                    {
                        serializer.Serialize(file, book);
                        file.Write("\n");
                    }
                }
                MessageBox.Show("Данные успешно сохранены.");
                books_list.Items.Clear();
                foreach (Book book in sortBooks)
                    books_list.Items.Add(book.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла ошибка при сохранении данных!");
            }
        }

        private void instruments_button_CheckedChanged(object sender, EventArgs e)
        {
            if (instruments_button.Checked)
            {
                toolsMenu.Visible = true;
            }
            else
            {
                toolsMenu.Visible = false;
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            оПрограммеToolStripMenuItem_Click(sender, e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem_Click(sender, e);
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            поНазваниюToolStripMenuItem_Click(sender, e);
            поДатеЗагрузкиToolStripMenuItem_Click(sender, e);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            new FindForm(this, books, 0).Show();
            operation.OperationType = AllOperationType.Search;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (operation.OperationType == AllOperationType.Sort)
            {
                sortButton_Click(sender, e);
            }
            else if (operation.OperationType == AllOperationType.Search)
            {
                findButton_Click (sender, e);
            }
            else if (operation.OperationType == AllOperationType.Save)
            {
               saveButton_Click (sender, e);
            }
            else if (operation.OperationType == AllOperationType.Load)
            {
                ClearForm();
            }
            else if (operation.OperationType == AllOperationType.AboutProgram)
            {
                aboutButton_Click (sender, e);
            }
            else if (operation.OperationType == AllOperationType.AddAuthor) {
                add_author_button_Click(sender, e);
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
           if(operation.OperationType == AllOperationType.Load) {
            download_button_Click (sender, e);
            }
        }
    }
}