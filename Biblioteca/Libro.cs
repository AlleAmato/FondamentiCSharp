using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Libro : IGetInfo
    {
        //Campi
        public string Titolo { get; set; }

        private string _autore;

        public string Autore
        {
            get { return _autore; }
            set { _autore = value; }
        }


        private float? _prezzo;

        public float? Prezzo
        {
            get { return _prezzo; }
            set 
            {
                if (value <= 0)
                    _prezzo = null;
                else
                    _prezzo = value; 
            }
        }


        private DateTime dataCreazione;

        public Libro()
        {
            Titolo = "";
            _autore = "";
            _prezzo = null;
            dataCreazione = DateTime.Now;
        }

        public Libro(string titolo, string autore) : this()
        {
            this.Titolo = titolo;
            this._autore = autore;
        }

        public Libro(string titolo, string autore, float? prezzo) : this(titolo, autore)
        {
            this._prezzo = prezzo;
        }

        public virtual string getInfo(bool conPrezzo)
        {
            if (conPrezzo && _prezzo!=null)
                return $"{Titolo} - {_autore} - {_prezzo}€";
            else
                return $"{Titolo} - {_autore}";
        }

        public virtual string getInfo()
        {
            return getInfo(true);
        }
    }
}
