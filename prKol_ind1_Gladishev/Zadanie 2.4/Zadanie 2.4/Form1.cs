using System;
using System.Windows.Forms;

namespace ArrayApp
{
    public partial class Form1 : Form
    {
        private OneDimensionalArray mainArray;
        private OneDimensionalArray secondArray;

        public Form1()
        {
            InitializeComponent();
            mainArray = null;
            secondArray = null;

        }

        private void UpdateInfo()
        {
            string info = "Массив не создан";
            if (mainArray != null)
                info = $"Массив: размер = {mainArray.Length}";
            if (secondArray != null)
                info += $"  |  2-й массив: размер = {secondArray.Length}";
            lblArrayInfo.Text = info;
        }

        private void btnPrintAll_Click_1(object sender, EventArgs e)
        {
            if (mainArray == null)
            {
                MessageBox.Show("Сначала создайте массив!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblStatus.Text = $"Вывод массива (размер: {mainArray.Length})";
            txtOutput.Text = mainArray.PrintDetailed() + "\r\n" + mainArray.GetStatistics();
        }
        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSize.Text, out int size) || size <= 0)
            {
                MessageBox.Show("Введите положительный размер!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            mainArray = new OneDimensionalArray(size);
            UpdateInfo();
            lblStatus.Text = $"Создан массив размером {size}";
            txtOutput.Text = mainArray.PrintArray();
        }

        private void btnFillRandom_Click_1(object sender, EventArgs e)
        {
            if (mainArray == null)
            {
                MessageBox.Show("Сначала создайте массив!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            mainArray.FillRandom(-100, 100);
            UpdateInfo();
            lblStatus.Text = "Массив заполнен случайными числами [-100, 100]";
            txtOutput.Text = mainArray.PrintDetailed();
        }

            private void btnGetElement_Click_1(object sender, EventArgs e)
        {
            if (mainArray == null)
            {
                MessageBox.Show("Сначала создайте массив!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIndex.Text, out int index))
            {
                MessageBox.Show("Введите индекс!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mainArray.TryGetElement(index, out int value))
            {
                txtValue.Text = value.ToString();
                lblStatus.Text = $"Элемент [{index}] = {value}";
                txtOutput.Text = mainArray.GetElementString(index);
            }
            else
            {
                MessageBox.Show($"Индекс {index} вне границ [0, {mainArray.Length - 1}]!",
                    "Ошибка выхода за границы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = $"Ошибка: выход за границы (индекс {index})";
            }
        }

        private void btnSetElement_Click_1(object sender, EventArgs e)
        {
            if (mainArray == null)
            {
                MessageBox.Show("Сначала создайте массив!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIndex.Text, out int index))
            {
                MessageBox.Show("Введите индекс!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtValue.Text, out int value))
            {
                MessageBox.Show("Введите значение!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mainArray.TrySetElement(index, value))
            {
                lblStatus.Text = $"Установлено: [{index}] = {value}";
                txtOutput.Text = $"Установлено: [{index}] = {value}\r\n" + mainArray.PrintArray();
            }
            else
            {
                MessageBox.Show($"Индекс {index} вне границ [0, {mainArray.Length - 1}]!",
                    "Ошибка выхода за границы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = $"Ошибка: выход за границы (индекс {index})";
            }
        }

        private void btnMultiply_Click_1(object sender, EventArgs e)
        {
            if (mainArray == null)
            {
                MessageBox.Show("Сначала создайте массив!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMultiplier.Text, out int multiplier))
            {
                MessageBox.Show("Введите множитель!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string before = mainArray.PrintArray();
            mainArray.MultiplyByNumber(multiplier);
            string after = mainArray.PrintArray();

            lblStatus.Text = $"Массив умножен на {multiplier}";
            txtOutput.Text = $"До:     {before}\r\nПосле:  {after}";
        }

        private void btnCreateSecond_Click_1(object sender, EventArgs e)
        {
            if (mainArray == null)
            {
                MessageBox.Show("Сначала создайте основной массив!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            secondArray = new OneDimensionalArray(mainArray.Length);
            secondArray.FillRandom(-50, 50);
            UpdateInfo();
            lblStatus.Text = "Создан второй массив";
            txtOutput.Text = $"1-й массив: {mainArray.PrintArray()}\r\n2-й массив: {secondArray.PrintArray()}";
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (mainArray == null || secondArray == null)
            {
                MessageBox.Show("Создайте оба массива!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                OneDimensionalArray result = mainArray + secondArray;
                lblStatus.Text = "Сложение выполнено";
                txtOutput.Text = $"1-й:  {mainArray.PrintArray()}\r\n2-й:  {secondArray.PrintArray()}\r\nСумма: {result.PrintArray()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubtract_Click_1(object sender, EventArgs e)
        {
            if (mainArray == null || secondArray == null)
            {
                MessageBox.Show("Создайте оба массива!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                OneDimensionalArray result = mainArray - secondArray;
                lblStatus.Text = "Вычитание выполнено";
                txtOutput.Text = $"1-й:      {mainArray.PrintArray()}\r\n2-й:      {secondArray.PrintArray()}\r\nРазность: {result.PrintArray()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintElement_Click_1(object sender, EventArgs e)
        {
            if (mainArray == null)
            {
                MessageBox.Show("Сначала создайте массив!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIndex.Text, out int index))
            {
                MessageBox.Show("Введите индекс!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblStatus.Text = $"Вывод элемента [{index}]";
            txtOutput.Text = mainArray.PrintDetailed() + "\r\n" + mainArray.GetElementString(index);
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            mainArray = null;
            secondArray = null;
            txtOutput.Clear();
            txtSize.Clear();
            txtIndex.Clear();
            txtValue.Clear();
            txtMultiplier.Clear();
            UpdateInfo();
            lblStatus.Text = "Готов к работе";
        }
    }
}
