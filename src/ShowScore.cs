using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuGame
{
    class ShowScore
    {
        public void Mostrar(int puntuacion)
        {
            string show, show2, show3;
            show = " ***************************************************\n";
            show2 = "*           La puntuación del juego              *\n";
            show3 = "***************************************************\n\n\n";
            Console.SetCursorPosition((Console.WindowWidth - show.Length) / 2, Console.CursorTop);
            Console.WriteLine(show);
            Console.SetCursorPosition((Console.WindowWidth - show2.Length) / 2, Console.CursorTop);
            Console.WriteLine(show2);
            Console.SetCursorPosition((Console.WindowWidth - show3.Length) / 2, Console.CursorTop);
            Console.WriteLine(show3);
            Console.Write("Tu record fue de: "+ puntuacion+" puntos");
            Console.ReadLine();
            Console.Clear();
            Menu backMenu = new Menu();
            backMenu.CreaMenu();
        }
    }
}
