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

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            Lines.Linhas();

            Column.Coluna();

            Lines.Linhas();
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            System.Console.WriteLine("Editor Html");
            Console.SetCursorPosition(3, 3);
            System.Console.WriteLine("=============");
            Console.SetCursorPosition(3, 4);
            System.Console.WriteLine("Selecione uma opcao abaixo: ");
            Console.SetCursorPosition(3, 6);
            System.Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            System.Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            System.Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            System.Console.Write("Opcao: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: System.Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }

}