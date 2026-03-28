using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Левицкий
{
    public partial class Form1 : Form
    {
        private string fileText;

        public Form1()
        {
            InitializeComponent();
            comboBoxWork.Items.AddRange(new string[]
            {
                    "Слова",
                    "Числа",
                    "Даты"
            });
            progressBar3.Visible = true;
            progressBar4.Visible = false;
            progressBar5.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = ofd.FileName;
                fileText = File.ReadAllText(ofd.FileName);
            }
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileText))
            {
                MessageBox.Show("Выберите файл");
                return;
            }


            var words = Regex.Matches(fileText, @"\b[А-Яа-яA-Za-z]+\b");
            textBoxWords.Text = words.Count.ToString();


            var numbers = Regex.Matches(fileText, @"\b\d+\b");
            textBoxNumbers.Text = numbers.Count.ToString();


            var dates = Regex.Matches(fileText, @"\b\d{2}\.\d{2}\.\d{4}\b");
            textBoxDates.Text = dates.Count.ToString();
        }

        private void comboBoxWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressBar3.Visible = false;
            progressBar4.Visible = false;
            progressBar5.Visible = false;

            if (comboBoxWork.SelectedItem.ToString() == "Слова")
                progressBar3.Visible = true;

            if (comboBoxWork.SelectedItem.ToString() == "Числа")
                progressBar4.Visible = true;

            if (comboBoxWork.SelectedItem.ToString() == "Даты")
                progressBar5.Visible = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (comboBoxWork.SelectedItem == null)
                return;
        }

        private object Average()
        {
            var numbers = Regex.Matches(fileText, @"\b\d+\b")
                       .Cast<Match>()
                       .Select(m => int.Parse(m.Value))
                       .ToList();
            return numbers.Count > 0 ? numbers.Average() : 0;
        }

        private object Min()
        {
            var numbers = Regex.Matches(fileText, @"\b\d+\b")
                        .Cast<Match>()
                        .Select(m => int.Parse(m.Value))
                        .ToList();
            return numbers.Count > 0 ? numbers.Min() : 0;
        }

        private object Max()
        {
            var numbers = Regex.Matches(fileText, @"\b\d+\b")
                         .Cast<Match>()
                         .Select(m => int.Parse(m.Value))
                         .ToList();
            return numbers.Count > 0 ? numbers.Max() : 0;
        }

        private void ToggleCheckBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total = 0;

            foreach (Control c in progressBar3.Controls)
            {
                if (c is CheckBox cb && cb.Checked)
                {
                    string letter = cb.Text;
                    total += Regex.Matches(fileText, letter, RegexOptions.IgnoreCase).Count;
                }
            }

            textBoxWordInfo.Text = total.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxMax.Text = Max().ToString();
            textBoxMin.Text = Min().ToString();
            textBoxAvg.Text = Average().ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           var matches = Regex.Matches(fileText, @"\b\d{2}\.\d{2}\.\d{4}\b");
            List<DateTime> dates = new List<DateTime>();

            foreach (Match m in matches)
            {
                if (DateTime.TryParseExact(
                    m.Value,
                    "dd.MM.yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime dt))
                {
                    dates.Add(dt);
                }
            }

            if (dates.Count == 0) return;

            textBoxOldest.Text = dates.Min().ToShortDateString();
            textBoxNewest.Text = dates.Max().ToShortDateString();

            monthCalendar1.BoldedDates = dates.ToArray();
            }
    }
}
