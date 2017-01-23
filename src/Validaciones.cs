using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SudokuGame
{
    class Validaciones
    {
         public bool ValidaRepetido(List<SavedNumbers> numeros, int solX, int solY, int limitX, int limitY, int NewNumero)
        {
            int entroCondicion = 0;

            //Console.WriteLine("\nGuardado: " + numeros[0].Numero + " " + numeros[0].CordX + " " + numeros[0].CordY);
            
            for (int i = 0; i<=limitX; i++)
            {    
                if (numeros.Contains(new SavedNumbers(NewNumero,i,solY)))
                {
                    entroCondicion = 1;
                    break;
                }  
            }

            if (entroCondicion != 1)
            {
                for (int x = 0; x <= limitY; x++)
                {
                    if (numeros.Contains(new SavedNumbers(NewNumero, solX, x)))
                    {
                        entroCondicion = 1;
                        break;
                    }
                }
            }

            if (entroCondicion == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
               
        }

        public bool ValidaCaracteres(string cordX, string cordY, string numero)
        {
            bool cumpleCond;
            Regex regex = new Regex("[0-9]");
            int sizenum = numero.Length;

            if (regex.IsMatch(cordX) && regex.IsMatch(cordY) && regex.IsMatch(numero) && sizenum < 2)
                cumpleCond = true;
            else
                cumpleCond = false;

            return cumpleCond;
            
        }

        public bool ValidaCadenas(int cordX, int cordY, int numero)
        {
            bool falseCond = true;
            if ((cordX > 8 || cordX < 0) || (cordY > 8 || cordY < 0))
            {
                Console.WriteLine("Las coordenadas X o Y son incorrectos");
                falseCond = false;
            }

            if (numero > 9 || numero < 1)
            {
                Console.WriteLine("No es posible ingresar numeros mayores a 9 o menores a 1");
                falseCond = false;
            }

            return falseCond;


        }
        //[Regilla,Y,X]
        public bool ValidaRegillas(int sX, int sY, int sNum, List<SavedNumbers> numeros)
        {                                       //X           //Y
            int[,,] Regillas = new int[,,] { { { 0, 1, 2 }, { 0, 1, 2 } },//1
                                             { { 3, 4, 5 }, { 0, 1, 2 } },//2
                                             { { 6, 7, 8 }, { 0, 1, 2 } },//3
                                             { { 0, 1, 2 }, { 3, 4, 5 } },//4
                                             { { 3, 4, 5 }, { 3, 4, 5 } },//5
                                             { { 6, 7, 8 }, { 3, 4, 5 } },//6
                                             { { 0, 1, 2 }, { 6, 7, 8 } },//7
                                             { { 3, 4, 5 }, { 6, 7, 8 } },//8
                                             { { 6, 7, 8 }, { 6, 7, 8 } },//9
                                            };
            int getRegilla = 0;
            int test = 0;
            bool termino1 = false;
            bool termino2 = false;
            bool numRepetido = false;
            //Obtenemos la regilla que desea ingresar
            while (getRegilla <= 8)
            {
                for (int j = 0; j <= 1; j++)
                {
                    termino1 = false;
                    termino2 = false;
                    for (int i = 0; i <= 2; i++)
                    {
                        test = Regillas[getRegilla, j, i];
                         if (Regillas[getRegilla, 0, i] == sX)
                        {
                            termino1 = true;
                        }
                         if(Regillas[getRegilla, 1, i] == sY)
                        {
                            termino2 = true;
                        } 
                    }
                    if (termino1 && termino2)
                        break;
                    
                }
                if (termino1 && termino2)
                    break;

                getRegilla++;
            }             

            //De la regilla obtenida, veremos si hay un numero igual a esa regilla
            for(int a=0; a<=2; a++)
            {
                 for(int b=0; b<=2; b++)
                {
                    if (numeros.Contains(new SavedNumbers(sNum, Regillas[getRegilla,0,b], Regillas[getRegilla, 1, a])))
                    {
                        numRepetido = true;
                    }
                }
            }
            return numRepetido;  
        }      
        
    }
}
