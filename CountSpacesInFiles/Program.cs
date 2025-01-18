using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSpacesInFiles
{
    class Program
    {
        private const String INFO_ABOUT_VARIANT_A = "Cчитали файл полностью асинхронно и потом посчитали пробелы.";
        private const String INFO_ABOUT_VARIANT_B = "Cчитали файл построчно и для каждой строчки считаем пробелы.";
        static async Task Main(string[] args)
        {
            string directoryPath = @"D:\semestr_7_technology_programming_texts";

            if (Directory.Exists(directoryPath))
            {
                var txtFiles = Directory.GetFiles(directoryPath, "*.txt");

                foreach (var file in txtFiles)
                {
                    Console.WriteLine($"Обработка файла: {file}...");

                    // Способ a: Считываем файл полностью асинхронно
                    var startTime = DateTime.Now;
                    int totalSpacesAsync = await CountSpacesInFileAsync(file);
                    var endTime = DateTime.Now;
                    var elapsedTimeAsync = endTime - startTime;
                    Console.WriteLine($"\nСпособ a.\n{INFO_ABOUT_VARIANT_A}\nФайл полностью асинхронно прочитан. Время: {elapsedTimeAsync.TotalMilliseconds} ms, Количество пробелов: {totalSpacesAsync}");

                    // Способ b: Считываем файл построчно асинхронно
                    startTime = DateTime.Now;
                    int totalSpacesLineByLine = await CountSpacesLineByLineAsync(file);
                    endTime = DateTime.Now;
                    var elapsedTimeLineByLine = endTime - startTime;
                    Console.WriteLine($"\nСпособ б.\n{INFO_ABOUT_VARIANT_B}\nФайл полностью асинхронно прочитан. Время: {elapsedTimeLineByLine.TotalMilliseconds} ms, Количество пробелов: {totalSpacesLineByLine}");

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Папка не найдена");
            }
        }

        // Способ a: Считываем файл полностью и считаем пробелы
        private static async Task<int> CountSpacesInFileAsync(string filePath)
        {
            using (var reader = new StreamReader(filePath, Encoding.UTF8))
            {
                var content = await reader.ReadToEndAsync();
                return content.Count(c => c == ' ');
            }
        }

        // Способ b: Считываем файл построчно и считаем пробелы в каждой строке
        private static async Task<int> CountSpacesLineByLineAsync(string filePath)
        {
            int totalSpaces = 0;
            using (var reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    totalSpaces += line.Count(c => c == ' ');
                }
            }
            return totalSpaces;
        }
    }
}
