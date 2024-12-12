using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Mostrar()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();

            Console.WriteLine("MODO DE EDIÇÃO");
            Console.WriteLine("----------------");

            Comecar();
        }

        public static void Comecar()
        {
            var arquivo = new StringBuilder();

            do {
                arquivo.Append(Console.ReadLine());
                arquivo.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine(" Deseja salvar o arquivo?");
        }
    }
}