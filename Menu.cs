using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DesenharTela();
        }

        public static void DesenharTela()
        {
            CabecalhoRodape();

            for (int linhas = 0; linhas <= 10; linhas++)
            {
                Console.Write("|");
                for (int espaco = 0; espaco <= 35; espaco++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            CabecalhoRodape();
        }

        public static void CabecalhoRodape()
        {
            Console.Write("+");
            for (int cabecalho = 0; cabecalho <= 35; cabecalho++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }
    }
}