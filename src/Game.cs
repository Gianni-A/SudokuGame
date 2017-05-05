using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuGame
{
    class Game
    {
        public void RunGame(List<SavedNumbers> numeros, int continuacion)
        {
            //List<SavedNumbers> numeros = new List<SavedNumbers>();
            Validaciones valida = new Validaciones();
            ConsoleKeyInfo cki;
            int conteo = 0;
            int puntos = 0;
            int score = 0;
            bool terminoJuego = true; 
            conteo = continuacion;
            string nombre = "";
            int cordX = 0;
            int cordY = 0;
            int num = 0;
            string ScordX = "";
            string ScordY = "";
            string Snum = "";
            int CondRepetido = 1;
            Tabla tabla = new Tabla();
            while(nombre == "")
            {
                Console.Write("Ingresar el nombre: ");
                nombre = Console.ReadLine();
                if (nombre == "")
                    Console.WriteLine("Debe ingresar un nombre");
            }
            Console.Clear();

                             
            while (conteo < 46)
            {
                ScordX = "";
                ScordY = "";
                Snum = "";

                conteo = tabla.Construction(9, 9, num, cordX, cordY, numeros, conteo, CondRepetido, out puntos);

                if (conteo > 45)
                {
                    terminoJuego = false;
                    break;
                }

                while (ScordX == "")
                {
                    Console.Write("Ingrese la coordenada X: ");
                    ScordX = Console.ReadLine();
                        
                }
                while (ScordY == "")
                {
                    Console.Write("Ingrese la coordenada Y: ");
                    ScordY = Console.ReadLine();
                }
                while (Snum == "")
                {
                    Console.Write("Ingrese el numero: ");
                    Snum = Console.ReadLine();
                }

                if (valida.ValidaCaracteres(ScordX, ScordY, Snum) == false)
                {
                    Console.Write("Los caracteres ingresados son incorrectos");
                    Console.ReadLine();
                    CondRepetido = 1;
                    //score--;
                    Console.Clear();
                    continue;
                }
                try
                {
                    cordX = int.Parse(ScordX);
                    cordY = int.Parse(ScordY);
                    num = int.Parse(Snum);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ha ingresado caracteres raros");
                    Console.ReadLine();
                    //score--;
                    Console.Clear();
                    continue;
                }

                CondRepetido = 0;

                if (!valida.ValidaCadenas(cordX, cordY, num))
                {
                    Console.ReadLine();
                    CondRepetido = 1;
                    score--;
                    Console.Clear();
                    continue;
                }


                if (conteo > 0)
                {
                    if (valida.ValidaRepetido(numeros, cordX, cordY, 9, 9, num) == true || valida.ValidaRegillas(cordX, cordY, num, numeros) == true)
                    {
                        CondRepetido = 1;
                        score--;
                    }
                    else
                        CondRepetido = 0;
                }
                else
                    CondRepetido = 0;

                //(Tamaño x,Tamaño y, Numero, CordX, CordY)

                //score += puntos;
                
                if (CondRepetido == 1)
                {
                    Console.Write("No es posible ingresar el numero " + Snum + " en las coordenadas: X:" + cordX + " Y:" + cordY);
                    Console.ReadLine();
                }
                else
                {
                    score++;
                }
                Console.Clear();
            }
              
            if(terminoJuego == false)
            {
                Score anotarPuntos = new Score();
                DateTime fecha = DateTime.Now;
                anotarPuntos.CreaPuntos(nombre, score, fecha.ToString());
            }
            string final, final2, final3;
            final = "***************************************************\n";
            final2 = "*                Fin del juego                   *\n";
            final3 = "***************************************************\n";
            Console.SetCursorPosition((Console.WindowWidth - final.Length) / 2, Console.CursorTop);
            Console.WriteLine(final);
            Console.SetCursorPosition((Console.WindowWidth - final2.Length) / 2, Console.CursorTop);
            Console.WriteLine(final2);
            Console.SetCursorPosition((Console.WindowWidth - final3.Length) / 2, Console.CursorTop);
            Console.WriteLine(final3);
            Console.ReadLine();
            Console.Clear();
            ShowScore goScore = new ShowScore();
            goScore.Mostrar(score);
        }
    }
}
