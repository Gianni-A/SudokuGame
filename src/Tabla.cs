using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuGame
{
    class Tabla
    {
        public int Construction(int x, int y, int numero, int cordX, int cordY, List<SavedNumbers> numeros, int contNumbers, int GuardarNum, out int score)
        {
            int limitX = x * 4;
            int limitY = y * 2;
            int limitMas = x + 1;
            int limitMenos = x * 4;
            int simboloMas = 0;
            int simboloMenos = 1;
            int j = 0;
            score = 0;
            int linea = 0;
            int pX = 0;
            int pY = 0;
            int siguiente = 1;
            int tempIndex = 0;
            int indexNumbers = 0;
            int SiCapturoNum = 0;
            List<SavedNumbers> ModificaNum = new List<SavedNumbers>();

            while (j <= limitY)
            {
                for (int i = 1; i <= limitX; i++)
                {
                    //Dibuja lineas de la tabla
                    if (linea == 0)
                    {
                        if (simboloMas == 0)
                        {
                            Console.Write("+");
                            simboloMas++;
                        }
                        if (simboloMenos >= 4)
                        {
                            simboloMenos = 1;
                            Console.Write("+");
                            simboloMas++;
                        }
                        else
                        {
                            Console.Write("-");
                            simboloMenos++;
                        }
                        if (i == limitX)
                        {
                            linea = 1;
                        }
                    }
                    //Dibuja los espacios donde van los numeros
                    else
                    {
                        if (simboloMas == 0)
                        {
                            Console.Write("+");
                            simboloMas++;
                            siguiente = 2;
                        }
                        if (simboloMenos >= 4)
                        {
                            simboloMenos = 1;
                            Console.Write("+");
                            pX++;
                            simboloMas++;
                            siguiente = 1;
                            SiCapturoNum = 0;
                        }
                        else
                        {
                            //Espacio para poder poner el numero
                            if (siguiente == 3)
                            {
                                //Espacio donde se indico donde ingresar el numero
                                if (cordX == pX && cordY == pY)
                                {
                                    if (contNumbers != 0)
                                    {
                                        //Verificar si existe un numero en ese espacio
                                        if (numeros[indexNumbers].CordX != pX || numeros[indexNumbers].CordY != pY)
                                        {
                                            //Para indicar si el usuario ingreso un numero ya validado
                                            //numero != 0 : es asignado por el sistema
                                            if (GuardarNum == 0)
                                            {
                                                //Modifica number
                                                int ExistIndex = numeros.FindIndex(h => h.CordX == pX && h.CordY == pY);
                                                if (ExistIndex != -1)
                                                {
                                                    numeros[ExistIndex].Numero = numero;
                                                }
                                                else
                                                {
                                                    numeros.Add(new SavedNumbers(numero, pX, pY));
                                                    if (contNumbers != 1)
                                                    {
                                                        indexNumbers++;
                                                    }
                                                    score++;
                                                    contNumbers++;
                                                    if (contNumbers != 1)
                                                    {
                                                        indexNumbers++;
                                                    }
                                                }
                                                Console.Write(numero);
                                            }
                                            else
                                            {
                                                int FindIndex = numeros.FindIndex(h => h.CordX == pX && h.CordY == pY);
                                                score--;
                                                if (FindIndex != -1)
                                                    Console.Write(numeros[FindIndex].Numero);
                                                else
                                                    Console.Write(" ");
                                            }
                                             
                                            siguiente = 0;
                                            simboloMenos++;
                                        }
                                        else
                                        {
                                            Console.Write(numeros[indexNumbers].Numero);
                                            simboloMenos++;
                                            siguiente = 0;
                                        }
                                    }
                                    else
                                    {
                                        score++;           
                                        Console.Write(numero);
                                        numeros.Add(new SavedNumbers(numero, pX, pY));
                                        contNumbers++;
                                        if (contNumbers != 1)
                                        {
                                            indexNumbers++;
                                        }
                                        siguiente = 0;
                                        simboloMenos++;
                                    }
                                }
                                else
                                {
                                    //Checa que numeros ya estaban ingresados para volverlos a ingresar
                                    for (tempIndex = 0; tempIndex < contNumbers; tempIndex++)
                                    {
                                        if (numeros[tempIndex].CordX == pX && numeros[tempIndex].CordY == pY)
                                        {   
                                            Console.Write(numeros[tempIndex].Numero);
                                            SiCapturoNum = 1;
                                        }
                                    }
                                    if (SiCapturoNum != 1)
                                    {
                                        Console.Write(" ");
                                    }
                                    simboloMenos++;
                                }
                            }
                            else
                            {                  
                                Console.Write(" ");
                                simboloMenos++;
                            }
                        }
                        if (i == limitX)
                        {
                            linea = 0;
                            pY++;
                            pX = 0;
                        }
                        siguiente++;
                    }
                }               
                Console.Write("\n");
                simboloMas = 0;
                simboloMenos = 1;
                j++;
            }
            return contNumbers;

        }

        public int IngresaNumeros(List<SavedNumbers> numeros, int pX, int pY, int numero ,int conteo)
        {
            int ExistNumero = numeros.FindIndex(h => h.CordX == pX && h.CordY == pY);
            if (ExistNumero == -1)
            {
                numeros.Add(new SavedNumbers(numero, pX, pY));
                conteo++;
                //Console.WriteLine("Numero: " + numero + " | CordX: " + pX + " | CordY: " + pY);
            }
            return conteo;

        }
    }
}
