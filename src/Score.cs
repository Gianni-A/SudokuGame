using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SudokuGame
{
    class Score
    {
        //string RutaArchivo = "D:/Respaldo de proyectos Visual studio/SudokuGame/Records.txt";
        string RutaArchivo;
        DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());
        public void RevisaPuntuacion()
        {
            RutaArchivo = dir + "/Records.txt";
            string texto;
            string nombre, puntos, fecha;
            string [] dato;
            Console.WriteLine("Reglas del juego:\nPor cada numero insertado correctamente en la tabla en un punto extra.\nSi hay un error por numero repetitivo se resta un punto.\n\nPuntuaje:\n");
            if (!File.Exists(RutaArchivo))
            {
                Console.WriteLine("No hay puntaje");
            }
            else
            {
                StreamReader leeRecords = new StreamReader(RutaArchivo);
                texto = leeRecords.ReadLine();
                while ((texto = leeRecords.ReadLine()) != null)
                {
                    dato = texto.Split("|".ToCharArray());
                    nombre = dato[0];
                    puntos = dato[1];
                    fecha = dato[2];
                    Console.WriteLine("Nombre: "+nombre);
                    Console.WriteLine("Puntuación: " + puntos);
                    Console.WriteLine("Fecha: " + fecha);
                    Console.WriteLine("------------------------");
                }
                leeRecords.Close();
            }
            Console.ReadLine();
            Console.Clear();
            Menu regresar = new Menu();
            regresar.CreaMenu(); 
        }

        public void CreaPuntos(string nombre, int puntos, string fecha)
        {
            RutaArchivo = dir + "/Records.txt";
            if (!File.Exists(RutaArchivo))
            {   
                StreamWriter archivo = new StreamWriter(RutaArchivo);
                archivo.WriteLine("");
                archivo.Write(nombre+"|");
                archivo.Write(puntos + "|");
                archivo.WriteLine(fecha + "|");
                archivo.Close();
            }
            else
            {
                StreamWriter archivo = new StreamWriter(RutaArchivo,true);
                archivo.Write(nombre + "|");
                archivo.Write(puntos + "|");
                archivo.WriteLine(fecha + "|");
                archivo.Close();
            }
        }
    }
}
