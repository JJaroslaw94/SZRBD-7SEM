using System;
using System.Collections.Generic;
using System.Text;

namespace Dane
{
    class Ksiazka
    {
        private String Autor;

        private String Tytul;

        private int Strony;

        Ksiazka (String Autor, String Tytul, int Strony)
        {
            setAutor(Autor);
            setStrony(Strony);
            setTytul(Tytul);
        }

        public String getAutor()
        {
            return Autor;
        }
        public String getTytul()
        {
            return Tytul;
        }
        public int getStrony()
        {
            return Strony;
        }

        public void setAutor(String Autor)
        {
            this.Autor = Autor;
        }
        public void setTytul(String Tytul)
        {
            this.Tytul = Tytul;
        }
        public void setStrony( int Strony)
        {
            this.Strony = Strony;
        }
    }
}
