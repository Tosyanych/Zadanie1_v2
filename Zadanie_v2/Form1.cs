using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Zadanie_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 1;
            int sum = 0;
            int result = 0;
            if(numericUpDown1.Value == 1)
            {
                FiboTextNum.Text = $"{a}, {b}";
                FiboTextSum.Text = $"{a + b}";
            }
            if(numericUpDown1.Value > 1)
            {
                FiboTextNum.Text = $"{a}, {b}";
                result = a + b;
                for (int i = 2; i <= numericUpDown1.Value; i++)
                {
                    sum = a + b;
                    FiboTextNum.Text += $", {sum}";
                    a = b;
                    b = sum;
                    result += sum;
                    FiboTextSum.Text = $"{result}";
                }
            }
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            numericUpDown1.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(listFound.Items.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "TXT | *.txt";
                save.FileName = "";
                if(save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(save.FileName);
                    foreach(var line in listFound.Items)
                    {
                        writer.WriteLine(line);
                    }
                    writer.Close();
                    MessageBox.Show("Файл сохранён", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Отуствуют данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void wordLenght_ValueChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                string[] separators = new string[] { "\n\r", "\r", "\n", " " };
                string[] punctuation = new string[] { ".", ",", ":","?","!","(",")" };
                string[] tempWords = richTextBox1.Text.Split(separators,StringSplitOptions.RemoveEmptyEntries);
                
                List<string> words = new List<string>();
                words.Clear();
                string newWord = "";
                foreach(var word in tempWords)
                {
                    newWord =  Regex.Replace(word, @"([,.?!:;()])", "");
                    words.Add(newWord);
                }
                
                var foundWord = words.Where(w => w.Trim().Length == wordLenght.Value);
                listFound.Items.Clear();
                foreach (var item in foundWord)
                {
                    listFound.Items.Add(item);
                }
            }
            wordLenght.Focus();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "TXT | *.txt";
            openFile.FileName = "";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFile.FileName);
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void searchEmail_TextChanged(object sender, EventArgs e)
        {
            if (searchEmail.Text != "Поиск E-mail адресов" && searchEmail.Text != string.Empty)
            {
                Regex emails = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
                MatchCollection emailsMatches = emails.Matches(richTextBox1.Text);

                foreach (Match email in emailsMatches)
                {
                    if (email.Value.Contains(searchEmail.Text))
                    {
                        listFound.Items.Clear();
                        listFound.Items.Add(email.Value);
                    }
                }
            }
        }

        private void searchEmail_Enter(object sender, EventArgs e)
        {
            if (searchEmail.Text == "Поиск E-mail адресов") searchEmail.Text = "";
        }

        private void searchEmail_Leave(object sender, EventArgs e)
        {
            if (searchEmail.Text == string.Empty) searchEmail.Text = "Поиск E-mail адресов";
        }
    }
}
