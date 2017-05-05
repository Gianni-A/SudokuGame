using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuGame
{
    class Dificultad
    {
        public void Opciones()
        {
            //Console.Write("Elije la dificultad del juego: ");
            Menu back = new Menu();
            ConsoleKeyInfo cki;
            int Fila,Columna;
            Titulo();
            string facil = "+++ Facil +++";
            string medio = "+++ Medio +++";
            string dificil = "+++ Dificil +++";
            string MDificil = "+++ Muy dificil +++";
            string Regresa = "+++ Regresar +++";
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition((Console.WindowWidth - facil.Length) / 2, Console.CursorTop);
            Console.WriteLine(facil);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition((Console.WindowWidth - medio.Length) / 2, Console.CursorTop);
            Console.WriteLine(medio);
            Console.SetCursorPosition((Console.WindowWidth - dificil.Length) / 2, Console.CursorTop);
            Console.WriteLine(dificil);
            Console.SetCursorPosition((Console.WindowWidth - MDificil.Length) / 2, Console.CursorTop);
            Console.WriteLine(MDificil);
            Console.SetCursorPosition((Console.WindowWidth - Regresa.Length) / 2, Console.CursorTop);
            Console.WriteLine(Regresa);
            Console.SetCursorPosition(0, 0);
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
                        if (Fila > 4)
                        {
                            Fila = 4;
                            continue;
                        }
                        Console.SetCursorPosition(Columna, Fila);
                        break;

                    case ConsoleKey.Enter:
                        RellenaTabla entra = new RellenaTabla();
                        switch (Fila)
                        {
                            case 0:
                                entra.Rellenar(45);
                                break;

                            case 1:
                                entra.Rellenar(40);
                                break;

                            case 2:
                                entra.Rellenar(30);
                                break;

                            case 3:
                                entra.Rellenar(20);
                                break;

                            case 4:
                                Console.Clear();
                                back.CreaMenu();
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
                        Console.SetCursorPosition((Console.WindowWidth - facil.Length) / 2, Console.CursorTop);
                        Console.WriteLine(facil);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition((Console.WindowWidth - medio.Length) / 2, Console.CursorTop);
                        Console.WriteLine(medio);
                        Console.SetCursorPosition((Console.WindowWidth - dificil.Length) / 2, Console.CursorTop);
                        Console.WriteLine(dificil);
                        Console.SetCursorPosition((Console.WindowWidth - MDificil.Length) / 2, Console.CursorTop);
                        Console.WriteLine(MDificil);
                        Console.SetCursorPosition((Console.WindowWidth - Regresa.Length) / 2, Console.CursorTop);
                        Console.WriteLine(Regresa);
                        Console.SetCursorPosition(0, Fila);
                        break;

                    case 1:
                        Titulo();
                        Console.SetCursorPosition((Console.WindowWidth - facil.Length) / 2, Console.CursorTop);
                        Console.WriteLine(facil);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.SetCursorPosition((Console.WindowWidth - medio.Length) / 2, Console.CursorTop);
                        Console.WriteLine(medio);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition((Console.WindowWidth - dificil.Length) / 2, Console.CursorTop);
                        Console.WriteLine(dificil);
                        Console.SetCursorPosition((Console.WindowWidth - MDificil.Length) / 2, Console.CursorTop);
                        Console.WriteLine(MDificil);
                        Console.SetCursorPosition((Console.WindowWidth - Regresa.Length) / 2, Console.CursorTop);
                        Console.WriteLine(Regresa);
                        Console.SetCursorPosition(0, Fila);
                        break;

                    case 2:
                        Titulo();
                        Console.SetCursorPosition((Console.WindowWidth - facil.Length) / 2, Console.CursorTop);
                        Console.WriteLine(facil);
                        Console.SetCursorPosition((Console.WindowWidth - medio.Length) / 2, Console.CursorTop);
                        Console.WriteLine(medio);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.SetCursorPosition((Console.WindowWidth - dificil.Length) / 2, Console.CursorTop);
                        Console.WriteLine(dificil);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition((Console.WindowWidth - MDificil.Length) / 2, Console.CursorTop);
                        Console.WriteLine(MDificil);
                        Console.SetCursorPosition((Console.WindowWidth - Regresa.Length) / 2, Console.CursorTop);
                        Console.WriteLine(Regresa);
                        Console.SetCursorPosition(0, Fila);
                        break;

                    case 3:
                        Titulo();
                        Console.SetCursorPosition((Console.WindowWidth - facil.Length) / 2, Console.CursorTop);
                        Console.WriteLine(facil);
                        Console.SetCursorPosition((Console.WindowWidth - medio.Length) / 2, Console.CursorTop);
                        Console.WriteLine(medio);
                        Console.SetCursorPosition((Console.WindowWidth - dificil.Length) / 2, Console.CursorTop);
                        Console.WriteLine(dificil);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.SetCursorPosition((Console.WindowWidth - MDificil.Length) / 2, Console.CursorTop);
                        Console.WriteLine(MDificil);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition((Console.WindowWidth - Regresa.Length) / 2, Console.CursorTop);
                        Console.WriteLine(Regresa);
                        Console.SetCursorPosition(0, Fila);
                        break;

                    case 4:
                        Titulo();
                        Console.SetCursorPosition((Console.WindowWidth - facil.Length) / 2, Console.CursorTop);
                        Console.WriteLine(facil);
                        Console.SetCursorPosition((Console.WindowWidth - medio.Length) / 2, Console.CursorTop);
                        Console.WriteLine(medio);
                        Console.SetCursorPosition((Console.WindowWidth - dificil.Length) / 2, Console.CursorTop);
                        Console.WriteLine(dificil);
                        Console.SetCursorPosition((Console.WindowWidth - MDificil.Length) / 2, Console.CursorTop);
                        Console.WriteLine(MDificil);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.SetCursorPosition((Console.WindowWidth - Regresa.Length) / 2, Console.CursorTop);
                        Console.WriteLine(Regresa);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(0, Fila);
                        break;
                }

            }
            while (cki.Key != ConsoleKey.Escape);
            Console.Clear();
            back.CreaMenu();
            Console.ReadLine();
        }

        public void Titulo()
        {
            string titulo, titulo2, titulo3;
            titulo = "***************************************************\n";
            titulo2 = "*            Seleccione la dificultad             *\n";
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
