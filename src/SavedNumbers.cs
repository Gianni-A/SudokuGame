using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuGame
{
    public class SavedNumbers : IEquatable<SavedNumbers> , IComparable
    {
        public int _numero;
        public int _cordx;
        public int _cordy;

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public int CordX
        {
            get { return _cordx; }
            set { _cordx = value; }
        }

        public int CordY
        {
            get { return _cordy; }
            set { _cordy = value; }
        }

        public SavedNumbers(int numero, int cordx, int cordy)
        {
            this.Numero = numero;
            this.CordX = cordx;
            this.CordY = cordy;
        }

        public bool Equals(SavedNumbers otro)
        {
            if (this.CordX == otro.CordX && this.CordY == otro.CordY && this.Numero == otro.Numero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CompareTo(object obj)
        {
            SavedNumbers e = obj as SavedNumbers;
            if (e == null)
                throw new ArgumentException("No se encontro nada");

            return _cordx.CompareTo(e._cordx);
        }
    }
}
