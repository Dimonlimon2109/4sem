using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab2
{
    public partial class FindForm : Form
    {

        private int choose;
        private Electronic_library lib;
        private List<Book> list;
        public FindForm(Electronic_library lib, List<Book> list, int choose = 0)
        {
            this.lib = lib;
            this.list = list;
            InitializeComponent();
            this.choose = choose;
            publisherFindTextbox.Enabled = false;
            fromPages.Enabled = false;
            toPages.Enabled = false;
            yearTrackBar.Enabled = false;
            if (choose == 0)
            {
                publisherCheckbox.Checked = true;
                PagesCheckbox.Checked = true;
                yearCheckbox.Checked = true;
            }
            else if (choose == 1)
            {
                publisherCheckbox.Checked = true;
            }
            else if (choose == 2)
            {
                yearCheckbox.Checked = true;
            }
            else if (choose == 3)
            {
                PagesCheckbox.Checked = true;
            }

        }

        private void yearTrackBar_Scroll(object sender, EventArgs e)
        {
            yearFindLabel.Text = Convert.ToString(yearTrackBar.Value);
        }

        private void publisherCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (publisherCheckbox.Checked)
            {
                publisherFindTextbox.Enabled = true;
            }
            else
                publisherFindTextbox.Enabled = false;
        }

        private void yearCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (yearCheckbox.Checked)
            {
                yearTrackBar.Enabled = true;
            }
            else
                yearTrackBar.Enabled = false;
        }

        private void PagesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PagesCheckbox.Checked)
            {
                fromPages.Enabled = true;
                toPages.Enabled = true;
            }
            else
            {
                fromPages.Enabled = false;
                toPages.Enabled = false;
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (!PagesCheckbox.Checked && !publisherCheckbox.Checked && !yearCheckbox.Checked)
            {
                MessageBox.Show("Ни один параметр поиска не выбран!");
            }
            else if (Regex.IsMatch(publisherFindTextbox.Text, @"^\\w+( \\w+)*$"))
            {
                MessageBox.Show("Неправильный формат издательства!");
            }
            else if(fromPages.Value > toPages.Value)
            {
                MessageBox.Show("Число страниц от не может превышать до");
            }
            else
            {
                List<Book> res_list = new List<Book>();
                if (!yearCheckbox.Checked && !publisherCheckbox.Checked)
                    res_list = list.Where(a => (a.pages >= fromPages.Value && a.pages <= toPages.Value)).ToList();
                else if (!yearCheckbox.Checked && publisherCheckbox.Checked && RegExpCheckbox.Checked)
                    res_list = list.Where(a => Regex.IsMatch(a.publisher, ConvertToRegex(publisherFindTextbox.Text)) && (a.pages >= fromPages.Value && a.pages <= toPages.Value)).ToList();
                else if (!yearCheckbox.Checked && publisherCheckbox.Checked && !RegExpCheckbox.Checked)
                    res_list = list.Where(a => a.publisher == publisherFindTextbox.Text && (a.pages >= fromPages.Value && a.pages <= toPages.Value)).ToList();
                else if (yearCheckbox.Checked && !publisherCheckbox.Checked)
                    res_list = list.Where(a => (a.year == yearTrackBar.Value) && (a.pages >= fromPages.Value && a.pages <= toPages.Value)).ToList();
                else
                    res_list = list.Where(a => a.publisher == publisherFindTextbox.Text && (a.year == yearTrackBar.Value) && (a.pages >= fromPages.Value && a.pages <= toPages.Value)).ToList();
                if (res_list.Count > 0)
                {
                    lib.SearchBooks = res_list;
                    foreach (Book book in res_list)
                    {
                        MessageBox.Show(book.BookInfo());
                    }
                }
                else
                {
                    MessageBox.Show("Не найдено");
                }
            }
        }
        public static string ConvertToRegex(string input)
        {
            string escapedInput = Regex.Escape(input);
            string regex = escapedInput;
            return regex;
        }
    }
}
