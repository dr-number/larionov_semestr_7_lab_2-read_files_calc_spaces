using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSpacesInFiles
{
    // Абстракция для вывода сообщений
    public interface IMessageService
    {
        void ShowMessage(string message);
        void ShowMessageError(string message);
        void ShowMessageSuccess(string message);
    }

    public class ConsoleMessageService : IMessageService
    {
        public void ShowMessage(string message)
        {
            Console.ResetColor();
            Console.WriteLine(message);
        }

        public void ShowMessageError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void ShowMessageSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }

    // Интерфейс для подсчета пробелов
    public interface ISpaceCounter
    {
        Task<int> CountSpacesAsync(string filePath);
    }

    // Считывание всего файла и подсчет пробелов
    public class FullFileSpaceCounter : ISpaceCounter
    {
        public async Task<int> CountSpacesAsync(string filePath)
        {
            using (var reader = new StreamReader(filePath, Encoding.UTF8))
            {
                var content = await reader.ReadToEndAsync();
                return content.Count(c => c == ' ');
            }
        }
    }

    // Считывание файла построчно и подсчет пробелов
    public class LineByLineSpaceCounter : ISpaceCounter
    {
        public async Task<int> CountSpacesAsync(string filePath)
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

    // Класс для работы с файлами и подсчета пробелов
    public class FileProcessor
    {
        private readonly IMessageService _messageService;

        public FileProcessor(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task ProcessFileAsync(string filePath, ISpaceCounter spaceCounter)
        {
            long fileSize = new FileInfo(filePath).Length;
            _messageService.ShowMessageSuccess($"Обработка файла: {filePath} размер файла {fileSize} байт...");

            var startTime = DateTime.Now;
            int totalSpaces = await spaceCounter.CountSpacesAsync(filePath);
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;

            _messageService.ShowMessage($"Время: {elapsedTime.TotalMilliseconds} ms, Количество пробелов: {totalSpaces}");
        }
    }

    class Program
    {
        public static bool isQuestion(string textQuestion)
        {
            Console.WriteLine("\n" + textQuestion);
            return Console.ReadLine()?.ToLower() != "n";
        }

        public static async Task ProcessFilesInDirectoryAsync(string directoryPath, IMessageService messageService)
        {
            var fileProcessor = new FileProcessor(messageService);

            if (!Directory.Exists(directoryPath))
            {
                messageService.ShowMessageError("Папка не найдена!\n");
                return;
            }

            var txtFiles = Directory.GetFiles(directoryPath, "*.txt");
            if (txtFiles == null || txtFiles.Length == 0)
            {
                messageService.ShowMessageError($"В папке \"{directoryPath}\" нет txt файлов!\n");
                return;
            }

            foreach (var file in txtFiles)
            {
                // Способ a: Считываем файл полностью
                await fileProcessor.ProcessFileAsync(file, new FullFileSpaceCounter());

                // Способ b: Считываем файл построчно
                await fileProcessor.ProcessFileAsync(file, new LineByLineSpaceCounter());

                Console.WriteLine();
            }
        }

        static async Task Main(string[] args)
        {
            Console.ResetColor();
            Console.WriteLine("Ларионов гр. 410з Игра \"Асмнхронный подсчет пробелов\"!");

            while (true)
            {
                string directoryPath = @"D:\semestr_7_technology_programming_texts_empty";
                IMessageService messageService = new ConsoleMessageService();

                await ProcessFilesInDirectoryAsync(directoryPath, messageService);

                Console.ResetColor();
                if (!isQuestion("Повторить процедуру [y/n]?"))
                {
                    break;
                }
            }
        }
    }
}
