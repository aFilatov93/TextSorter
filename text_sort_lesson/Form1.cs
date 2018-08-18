using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace text_sort_lesson
{
    public partial class IndexerForm : Form
    {
        List<string> fromFile = new List<string>();

        public IndexerForm()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            // отображение пути к файлу в текст боксе
            textPath.Text = openFileDialog1.FileName;        
        }

        private void buttonIndex_Click(object sender, EventArgs e)
        {
            // добавление строк из файла в список 
            fromFile.AddRange(File.ReadAllLines(textPath.Text));
            // вызов метода пронумерования строк
            Indexer(fromFile);
        }

        /// <summary>
        /// Пронумеровывает строки в указанном списке
        /// </summary>
        /// <param name="fromFile"></param>
        private void Indexer(List<string> unindexed)
        {
            // если указан путь к файлу
            if (!(textPath.Text == ""))
            {
                // сортировка по возрастанию, если включен чек-бокс
                if (checkSorting.Checked)
                {
                    unindexed = (unindexed.OrderBy(i => i)).ToList<string>();
                }
                // сортировка по убыванию, если включен чек-бокс
                if (checkSortingDesc.Checked)
                {
                    unindexed = (unindexed.OrderByDescending(i => i)).ToList<string>();
                }
                // нумерация строк
                for (int i = 0; i < unindexed.Count; i++)
                {
                    unindexed[i] = string.Format("{0}. {1}", i + 1, unindexed[i]);
                }
                File.WriteAllLines(textPath.Text, unindexed.ToArray());
                // очистка списка
                fromFile.Clear();
                // оповещение о готовности
                MessageBox.Show("Completed!", "");
            }
            // если не указан путь к файлу
            else
            {
                MessageBox.Show("File not attached!", "Error");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        // если включен другой чек-бокс, отключить его
        private void checkSorting_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSorting.Checked) checkSortingDesc.Checked = false;
        }

        // если включен другой чек-бокс, отключит его
        private void checkSortingDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSortingDesc.Checked) checkSorting.Checked = false;
        }
    }
}
