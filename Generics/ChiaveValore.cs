using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class ChiaveValore<T>
    {
        private string _chiave;

        public string Chiave
        {
            get { return _chiave; }
        }

        private T _valore;

        public T Valore
        {
            get { return _valore; }
        }

        public ChiaveValore(string chiave, T valore)
        {
            _chiave = chiave;
            _valore = valore;
        }
    }
}
