using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Generics
{
    internal class Dizionario<T>
    {
        private List<ChiaveValore<T>> _dati;

        public Dizionario()
        {
            _dati = new List<ChiaveValore<T>>();
        }

        //Add
        public void Add(ChiaveValore<T> v)
        {
            _dati.Add(v);
        }

        public void Add(string chiave, T valore)
        {
            //_dati.Add(new ChiaveValore<T>(chiave, valore));
            Add(new ChiaveValore<T>(chiave, valore));
        }

        //Find
        public ChiaveValore<T> Find(string chiave)
        {
            foreach (ChiaveValore<T> item in _dati)
            {
                if (item.Chiave == chiave) return item;
            }

            return null;
        }
    }
}
