using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuGame
{
    class Menu
    {
        public void CreaMenu()
        {
            Console.CursorVisible = false;
            Titulo();
            string jugar = "*** Jugar ***";
            string records = "*** Puntuación ***";
            string salir = "*** Salir ***";
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition((Console.WindowWidth - jugar.Length) / 2, Console.CursorTop);
            Console.WriteLine(jugar);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition((Console.WindowWidth - records.Length) / 2, Console.CursorTop);
            Console.WriteLine(records);
            Console.SetCursorPosition((Console.WindowWidth - salir.Length) / 2, Console.CursorTop);
            Console.WriteLine(salir);
           
            Console.SetCursorPosition(0, 0);
            ConsoleKeyInfo cki;
            int Columna, Fila;
            do
            {
                Columna = Console.CursorLeft;
                Fila = Console.CursorTop;
                cki = Console.ReadKey(true);
                switch (cki.Key)
                {     
                    case ConsoleKey.UpArrow:
                        Fila--;
                        if (Fila < 0)
                        {
                            Fila = 0;
                            continue;
                        }
                        Console.SetCursorPosition(Columna, Fila);
                        break;
                    case ConsoleKey.DownArrow:
                        Fila++;
                        if (Fila > 2)
                        {
                            Fila = 2;
                            continue;
                        }
                        Console.SetCursorPosition(Columna, Fila);
                        break;

                    case ConsoleKey.Enter:
                        switch (Fila)
                        {
                            case 0:
                                Console.Clear();
                                Dificultad run = new Dificultad();
                                run.Opciones();
                                break;

                            case 1:
                                Console.Clear();
                                Score puntos = new Score();
                                puntos.RevisaPuntuacion();
                                break;

                            case 2:
                                Environment.Exit(-1);
                                break;

                        }
                        break;
                }
                Console.Clear();
                switch (Fila)
                {
                    case 0:
                        Titulo();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.SetCursorPosition((Console.WindowWidth - jugar.Length) / 2, Console.CursorTop);
                        Console.WriteLine(jugar);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition((Console.WindowWidth - records.Length) / 2, Console.CursorTop);
                        Console.WriteLine(records);
                        Console.SetCursorPosition((Console.WindowWidth - salir.Length) / 2, Console.CursorTop);
                        Console.WriteLine(salir);
                        Console.SetCursorPosition(0, Fila);
                        break;

                    case 1:
                        Titulo();
                        Console.SetCursorPosition((Console.WindowWidth - jugar.Length) / 2, Console.CursorTop);
                        Console.WriteLine(jugar);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.SetCursorPosition((Console.WindowWidth - records.Length) / 2, Console.CursorTop);
                        Console.WriteLine(records);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition((Console.WindowWidth - salir.Length) / 2, Console.CursorTop);
                        Console.WriteLine(salir);
                        Console.SetCursorPosition(0, Fila);
                        break;

                    case 2:
                        Titulo();
                        Console.SetCursorPosition((Console.WindowWidth - jugar.Length) / 2, Console.CursorTop);
                        Console.WriteLine(jugar);
                        Console.SetCursorPosition((Console.WindowWidth - records.Length) / 2, Console.CursorTop);
                        Console.WriteLine(records);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.SetCursorPosition((Console.WindowWidth - salir.Length) / 2, Console.CursorTop);
                        Console.WriteLine(salir);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(0, Fila);
                        break;
                }
            }
                                                 
            while (cki.Key != ConsoleKey.Escape);
            Environment.Exit(-1);
            //Console.ReadLine();
        }

        public void Titulo()
        {
            string titulo, titulo2, titulo3;
            titulo = "***************************************************\n";
            titulo2 = "*         Bienvenidos al juego del Sudoku         *\n";
            titulo3 = "***************************************************\n";
            Console.SetCursorPosition((Console.WindowWidth - titulo.Length) / 2, Console.CursorTop);
            Console.WriteLine(titulo);
            Console.SetCursorPosition((Console.WindowWidth - titulo2.Length) / 2, Console.CursorTop);
            Console.WriteLine(titulo2);
            Console.SetCursorPosition((Console.WindowWidth - titulo3.Length) / 2, Console.CursorTop);
            Console.WriteLine(titulo3);
        }
    }
}
