using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace zadanie_7._2
{
    public class EmployeeProcessor
    {
        private Queue<string[]> lowSalaryQueue = new Queue<string[]>();
        private Queue<string[]> otherQueue = new Queue<string[]>();

        public void Process(string inputFile, string outputFile, RichTextBox resultBox)
        {
            lowSalaryQueue.Clear();
            otherQueue.Clear();

            var employees = File.ReadAllLines(inputFile, Encoding.UTF8)
                 .Where(line => !string.IsNullOrWhiteSpace(line))
                 .Select(line => line.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries))
                 .Where(parts => parts.Length >= 6 && decimal.TryParse(parts[5], out _))
                 .Select(parts => new
                 {
                     Parts = parts,
                     Salary = decimal.Parse(parts[5])
                 })
                 .ToList();
            var lowSalaryList = employees.Where(e => e.Salary < 10000).Select(e => e.Parts).ToList();
            var otherList = employees.Where(e => e.Salary >= 10000).Select(e => e.Parts).ToList();
            lowSalaryList.ForEach(item => lowSalaryQueue.Enqueue(item));
            otherList.ForEach(item => otherQueue.Enqueue(item));
            resultBox.Clear();
            PrintToRichTextBox(resultBox, "Сотрудники с зарплатой менее 10000:", lowSalaryQueue);
            PrintToRichTextBox(resultBox, "Остальные сотрудники:", otherQueue);

            using (StreamWriter writer = new StreamWriter(outputFile, false, Encoding.UTF8))
            {
                PrintToFile(writer, "Сотрудники с зарплатой менее 10000:", lowSalaryQueue);
                PrintToFile(writer, "Остальные сотрудники:", otherQueue);
            }
        }

        private void PrintToRichTextBox(RichTextBox box, string title, Queue<string[]> queue)
        {
            box.AppendText("\n");
            box.AppendText(title + "\n");
            box.AppendText("\n");

            foreach (var parts in queue.GetAll())
            {
                box.AppendText($"{parts[0]} {parts[1]} {parts[2]}, {parts[3]}, {parts[4]} лет, зарплата: {parts[5]} руб.\n");
            }
            box.AppendText("\n");
        }

        private void PrintToFile(StreamWriter writer, string title, Queue<string[]> queue)
        {
            writer.WriteLine();
            writer.WriteLine(title);
            writer.WriteLine();

            foreach (var parts in queue.GetAll())
            {
                writer.WriteLine($"{parts[0]} {parts[1]} {parts[2]}, {parts[3]}, {parts[4]} лет, зарплата: {parts[5]} руб.");
            }
            writer.WriteLine();
        }
    }
}
