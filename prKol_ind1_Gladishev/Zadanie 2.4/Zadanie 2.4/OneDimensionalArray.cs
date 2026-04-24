using System;
using System.Collections;
using System.Linq;

namespace ArrayApp
{
    public class OneDimensionalArray
    {
        private ArrayList array;

        public OneDimensionalArray()
        {
            array = new ArrayList();
        }

        public OneDimensionalArray(int size)
        {
            if (size <= 0)
                throw new ArgumentException("Размер массива должен быть положительным.");

            array = new ArrayList(size);
            for (int i = 0; i < size; i++)
                array.Add(0);
        }

        public OneDimensionalArray(ArrayList source)
        {
            array = new ArrayList();
            foreach (int item in source)
                array.Add(item);
        }

        public int Length
        {
            get { return array.Count; }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Count)
                    throw new IndexOutOfRangeException(
                        $"Индекс {index} вне границ массива [0, {array.Count - 1}]");
                return (int)array[index];
            }
            set
            {
                if (index < 0 || index >= array.Count)
                    throw new IndexOutOfRangeException(
                        $"Индекс {index} вне границ массива [0, {array.Count - 1}]");
                array[index] = value;
            }
        }

        public bool TryGetElement(int index, out int value)
        {
            if (index < 0 || index >= array.Count)
            {
                value = 0;
                return false;
            }
            value = (int)array[index];
            return true;
        }

        public bool TrySetElement(int index, int value)
        {
            if (index < 0 || index >= array.Count)
                return false;
            array[index] = value;
            return true;
        }

        public void FillRandom(int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Count; i++)
                array[i] = rnd.Next(min, max + 1);
        }

        public void MultiplyByNumber(int number)
        {
            for (int i = 0; i < array.Count; i++)
                array[i] = (int)array[i] * number;
        }

        public static OneDimensionalArray operator +(OneDimensionalArray a, OneDimensionalArray b)
        {
            if (a.Length != b.Length)
                throw new ArgumentException(
                    $"Размеры массивов не совпадают: {a.Length} и {b.Length}");

            OneDimensionalArray result = new OneDimensionalArray(a.Length);
            for (int i = 0; i < a.Length; i++)
                result.array[i] = a.array[i] != null && b.array[i] != null
                    ? (int)a.array[i] + (int)b.array[i] : 0;

            return result;
        }

        public static OneDimensionalArray operator -(OneDimensionalArray a, OneDimensionalArray b)
        {
            if (a.Length != b.Length)
                throw new ArgumentException(
                    $"Размеры массивов не совпадают: {a.Length} и {b.Length}");

            OneDimensionalArray result = new OneDimensionalArray(a.Length);
            for (int i = 0; i < a.Length; i++)
                result.array[i] = a.array[i] != null && b.array[i] != null
                    ? (int)a.array[i] - (int)b.array[i] : 0;

            return result;
        }

        public string GetElementString(int index)
        {
            if (index < 0 || index >= array.Count)
                return $"Ошибка: индекс {index} вне границ [0, {array.Count - 1}]";
            return $"Элемент [{index}] = {array[index]}";
        }

        public string PrintArray()
        {
            if (array.Count == 0)
                return "Массив пуст.";

            var casted = array.Cast<int>();
            return "[ " + string.Join(", ", casted) + " ]";
        }

        public string PrintDetailed()
        {
            if (array.Count == 0)
                return "Массив пуст.";

            var casted = array.Cast<int>();
            string result = "";
            result += new string('-', 30) + "\r\n";
            result += $"Индекс    Значение\r\n";
            result += new string('-', 30) + "\r\n";

            for (int i = 0; i < array.Count; i++)
                result += $"  [{i}]       {array[i]}\r\n";

            result += new string('-', 30) + "\r\n";
            result += $"Массив: [ {string.Join(", ", casted)} ]\r\n";

            return result;
        }

        public string GetStatistics()
        {
            if (array.Count == 0)
                return "Статистика недоступна (массив пуст).";

            var casted = array.Cast<int>();

            int max = casted.Max();
            int min = casted.Min();
            double avg = casted.Average();
            int sum = casted.Sum();
            int count = array.Count;

            var positive = casted.Where(x => x > 0);
            var negative = casted.Where(x => x < 0);
            var zeros = casted.Where(x => x == 0);

            string stats = "";
            stats += "=== СТАТИСТИКА (LINQ) ===\r\n";
            stats += $"Количество:     {count}\r\n";
            stats += $"Минимум:        {min}\r\n";
            stats += $"Максимум:       {max}\r\n";
            stats += $"Сумма:          {sum}\r\n";
            stats += $"Среднее:        {avg:F2}\r\n";
            stats += $"Положительных:  {positive.Count()}\r\n";
            stats += $"Отрицательных:  {negative.Count()}\r\n";
            stats += $"Нулей:          {zeros.Count()}\r\n";

            if (positive.Any())
                stats += $"Положительные:  [ {string.Join(", ", positive)} ]\r\n";
            if (negative.Any())
                stats += $"Отрицательные:  [ {string.Join(", ", negative)} ]\r\n";

            return stats;
        }

        public ArrayList GetArrayList()
        {
            return array;
        }
    }
}
