using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace converterTudaSuda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cursor cursor = new Cursor();
            cursor.offset = 3;
            Console.WriteLine("Введите путь до файла");
            OpenedFile openedFile = new OpenedFile();
            openedFile.path = Console.ReadLine();
            Console.Clear();
            openedFile.text = Editor.Edit(openedFile.path);
            Converters.Convert(openedFile.path);
        }
    }
}



