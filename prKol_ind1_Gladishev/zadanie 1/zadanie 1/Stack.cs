using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace zadanie_1
{
    class Stack
    {
        private string inputFile;
        private string outputFile;

        public Stack(string inputFile, string outputFile)
        {
            this.inputFile = inputFile;
            this.outputFile = outputFile;
        }

        public void ReverseAndSave()
        {
            try
            {

                var numbers = File.ReadAllText(inputFile)
                                  .Split(new[] { ' ', '\n', '\r', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToList();


                Stack<int> stack = new Stack<int>(numbers);


                File.WriteAllLines(outputFile, stack.Select(n => n.ToString()));

                Console.WriteLine($"Числа из {inputFile} записаны в обратном порядке в {outputFile}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Файл {inputFile} не найден!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Файл содержит нечисловые данные!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
