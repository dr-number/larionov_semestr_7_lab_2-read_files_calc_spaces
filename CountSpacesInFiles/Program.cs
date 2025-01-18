using System.Text;

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
                messageService.ShowMessageError($"Папка \"{directoryPath}\" не найдена!\n");
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
                long fileSize = new FileInfo(file).Length;
                messageService.ShowMessageSuccess($"Обработка файла: {file} размер файла {fileSize} байт...");

                // Способ a: Считываем файл полностью
                messageService.ShowMessage("Cчитали файл полностью асинхронно и потом посчитали пробелы.");
                await fileProcessor.ProcessFileAsync(file, new FullFileSpaceCounter());

                // Способ b: Считываем файл построчно
                messageService.ShowMessage("Cчитали файл построчно и для каждой строчки считаем пробелы.");
                await fileProcessor.ProcessFileAsync(file, new LineByLineSpaceCounter());

                Console.WriteLine();
            }
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Ларионов гр. 410з \"Асмнхронный подсчет пробелов\"!");

            Console.ResetColor();
            IMessageService messageService = new ConsoleMessageService();
            
            string directoryPath;

            while (true)
            {
                Console.ResetColor();
                Console.WriteLine("Введиье путь к директории с txt файлами: (по умолчанию будет использована текущая директория)");
                directoryPath = Console.ReadLine();

                if (directoryPath == null || directoryPath.Length == 0)
                {
                    directoryPath = Directory.GetCurrentDirectory();
                }

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
