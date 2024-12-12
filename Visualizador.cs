using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class Visualizador
    {
        public static void Mostrar(string texto)
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();

            Console.WriteLine("MODO DE VISUALIZAÇÃO");
            Console.WriteLine("-----------------------");

            Substituir(texto);

            Console.WriteLine("-----------------------");
            Console.ReadKey();

            Menu.Mostrar();
        }

        public static void Substituir(string texto)
        {
            var negrito = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
        }
    }
}