using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Coda<T>
    {
        private List<T> _dati;

        public int Count 
        { 
            get
            {
                return _dati.Count;
            }
        }

        public Coda()
        {
            _dati = new List<T>();  
        }

        public void Entra(T elemento)
        {
            _dati.Add(elemento);
        }

        public T Esci()
        {
            if (Count == 0) throw new Exception("Nessuno in coda!"); 

            T elementoRimosso = _dati[0];
            _dati.RemoveAt(0);
            return elementoRimosso;
        }
    }
}
