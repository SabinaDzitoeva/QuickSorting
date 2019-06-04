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
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static int[] arr;
        Stopwatch timer;
        SortedDictionary<long, long> point = new SortedDictionary<long, long>();

        public Form1()
        {
            InitializeComponent();
            StreamReader str = new StreamReader("pointsGraf.txt");
            for (int i = 0; i < 1000; i++)
                Graf.Series[0].Points.AddXY(i, i * Math.Log(i, 2));
            int n = int.Parse(str.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                string k = str.ReadLine();
                string[] temp = k.Split();
                int a = int.Parse(temp[0]);
                int b = int.Parse(temp[1]);
                point.Add(a, b);
            }
            foreach (var item in point)
                Graf.Series[1].Points.AddXY(item.Key, item.Value);
        }

        private void Fill_MasRandom_Click(object sender, EventArgs e)
        {
            //Очистка списка элементов исходного массива
            InputTextBox.Clear();
            Random rd = new Random();
            int n = rd.Next(4, 1000);
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                arr[i] = rd.Next(1, 1000);
                InputTextBox.Text += arr[i].ToString() + " "; 
            }
            arr[arr.Length - 1] = rd.Next(1, 1000);
            InputTextBox.Text += Convert.ToString(arr[arr.Length - 1]);
            arrayLengthLabel.Text = "Длина массива: " + n;
        }
        //Сортировка Хоара
        void sorting(ref int[] arr, int first, int last)
        {
            int mid = arr[(last + first) / 2];//Опорный элемент, относительно которого массив сортируется.
            int temp;//Переменная используется в качестве промежуточного хранения для обмена значений двух величин.
            int i = first, j = last;//Левая и правая границы данного массива.
            while (i <= j)//Пока границы не сомкнутся
            {
                while (arr[i] < mid && i <= last) i++;//Сдвигаем левую границу вправо, пока не найдем элемент, который больше
                                                      //опорного и расположен перед ним.
                while (arr[j] > mid && j >= first) j--;//Сдвигаем правую границу влево, пока не найдем элемент, который меньше
                                                       //опорного и расположен после него.
                if (i <= j)                 //Пара элементов, где один больше опорного и расположен перед ним, 
                {                           //а второй меньше и расположен после, меняются местами. 
                    temp = arr[i];          //Обмен происходит до тех пор, пока индексы не пересекутся.
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++; j--;       //Сдвигаем границы массива на одну позицию(левая-вправо, правая-влево).
                }
            }
            //Производится проверка количества элементов в левой и правой частях массива.
            //Если какая-либо часть (или обе части) содержит более двух элементов, 
            //то для этой части (или частей) запускается та же процедура сортировки с помощью рекурсивного вызова.
            if (j > first) sorting(ref arr, first, j);
            if (i < last) sorting(ref arr, i, last);
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            timer = new Stopwatch();
            string[] temp = InputTextBox.Text.Split();
            arr = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
                arr[i] = Convert.ToInt32(temp[i]);
            timer.Start();
            sorting(ref arr, 0, arr.Length - 1);
            timer.Stop();
            Graf.Series[1].Points.Clear();
            if (point.ContainsKey(arr.Length))
                point[arr.Length] = timer.Elapsed.Ticks;
            else
                point.Add(arr.Length, timer.Elapsed.Ticks);

            foreach (var item in point)
                Graf.Series[1].Points.AddXY(item.Key, item.Value);

            //отображаем результаты сортировки
            OutputTextBox.Clear();
            timeSortLabel.Visible = true;
            timeSortLabel.Text = "Время работы сортировки: " + timer.Elapsed.Ticks.ToString();
            for (int i = 0; i < arr.Length; i++)
            {
                OutputTextBox.Text += arr[i].ToString();
                if (i % 35 == 0 && i != 0)
                    OutputTextBox.Text += '\n';
                else
                    OutputTextBox.Text += " ";
            }
        }

        /*private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.FileName = "Unnamed.txt";
            SFD.Filter = "(Текстовый файл: )|*.txt";
            if (SFD.ShowDialog() == DialogResult.OK)
                File.WriteAllText(SFD.FileName, NewMasTextBox.Text);
        }*/

        private void Fill_MasFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "(Текстовый файл: )|*.txt";

            if (OFD.ShowDialog() == DialogResult.OK)
                InputTextBox.Text = File.ReadAllText(OFD.FileName);
        }
             
        private void ClearButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Clear();
            OutputTextBox.Clear();
            arrayLengthLabel.Text = "Длина массива:";
            timeSortLabel.Text = "Время работы сортировки:";
        }

        private void сохранитьСтатистикуToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                StreamWriter sr = new StreamWriter("Statistics.txt", true);
                sr.WriteLine(arr.Length.ToString() + "\t" + timer.Elapsed.Ticks.ToString() + " ticks");
                sr.Close();
                MessageBox.Show("Статистика сохранена");
        }


        private void сохранитьИтоговыйМассивToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;

                StreamWriter sr = new StreamWriter(filename, false);
                for (int i = 0; i < arr.Length; i++)
                {
                    sr.WriteLine(arr[i]);
                }
                MessageBox.Show("Файл сохранен");
                sr.Close();
            }
        }

        private void timeSortLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("pointsGraf.txt");
            bool count = true; int k = 0;
            foreach (var item in point)
            {
                k++;
                if (k == point.Count)
                    sw.Write(item.Key + " " + item.Value);
                else
                {
                    if (count)
                    {
                        sw.WriteLine(point.Count);
                        count = false;
                    }
                    else
                        sw.WriteLine(item.Key + " " + item.Value);
                }
            }
            sw.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
