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
            EscreverOpcoes();

            Console.ReadKey();
        }

        public static void DesenharTela()
        {
            CabecalhoRodape();

            for (int linhas = 0; linhas <= 15; linhas++)
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

        public static void EscreverOpcoes()
        {
            Console.SetCursorPosition(12,1);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(1,2);
            Console.WriteLine("------------------------------------");

            Console.SetCursorPosition(3,3);
            Console.WriteLine("Selecione uma opção abaixo: ");

            Console.SetCursorPosition(3,5);
            Console.WriteLine("1 - Novo arquivo");

            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - Abrir arquivo");

            Console.SetCursorPosition(3,9);
            Console.WriteLine("0 - Sair");

            Console.SetCursorPosition(3,12);
            Console.Write("Opção: ");
        }
    }
}