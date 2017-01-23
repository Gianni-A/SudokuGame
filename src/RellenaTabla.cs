using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuGame
{
    class RellenaTabla
    {
        public void Rellenar(int dificultad)
        {
            List<SavedNumbers> numeros = new List<SavedNumbers>();
            Random rnd = new Random();
            int cordX = rnd.Next(0,9);
            int cordY = rnd.Next(0, 9);
            int num = rnd.Next(1, 10);
            int conteo = 0;
            int CondRepetido;
            int puntos = 0;              
            Validaciones valida = new Validaciones();
            Tabla tabla = new Tabla();
            
            while (conteo < dificultad)
            {
                if (conteo > 0)
                {
                    if (valida.ValidaRepetido(numeros, cordX, cordY, 9, 9, num) == true || valida.ValidaRegillas(cordX, cordY, num, numeros) == true)
                        CondRepetido = 1;
                    else
                        CondRepetido = 0;
                }                   
                else
                    CondRepetido = 0;

                //conteo = tabla.Construction(9, 9, num, cordX, cordY, numeros, conteo, CondRepetido, out puntos);
                if (CondRepetido == 0)
                {
                    conteo = tabla.IngresaNumeros(numeros, cordX, cordY, num, conteo);
                    Console.WriteLine(conteo);
                }
                    
                //conteo = tabla.IngresaNumeros(numeros, 7, 7, 7, conteo);
                cordX = rnd.Next(0, 8);
                cordY = rnd.Next(0, 8);
                num = rnd.Next(1, 9);
                
            }
            
            Console.Clear();
            Game run = new Game();
            run.RunGame(numeros, conteo);  
            
        }
    }
}
