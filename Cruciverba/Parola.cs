using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Cruciverba
{
    internal class Parola
    {
        private int id;
        private string parola;
        private int colore;
        private List<Parola> sinonimi;
        private List<Parola> contrari;
        private List<Parola> anagrammi;
    }

    public Parola(int id, string parola)
        {
            this.id = id;
            this.parola = parola;
            colore = 0;
            sinonimi = new List<Parola>();
            contrari = new List<Parola>();
            anagrammi = new List<Parola>();
        }

        public bool addSinonimo(Parola p, Parola p1)
        {
            if (p.sinonimi.Contains(p1))
                return false;
            p.sinonimi.Add(p1);
            return true;
        }

        public bool addContrario(Parola p, Parola p1)
        {
            if (p.contrari.Contains(p1))
                return false;
            p.contrari.Add(p1);
            return true;
        }

        public bool addAnagramma(Parola p, Parola p1)
        {

            char[] c = p.parola.ToLower().ToArray();
            char[] c1 = p.parola.ToLower().ToArray();
            Array.Sort(c);
            Array.Sort(c1);
            string s = new string(c);
            string s1 = new string(c1);
            if (s == s1 && !p.anagrammi.Contains(p1))
            {
                p.anagrammi.Add(p1);
                return true;
            }
            return false;
        }

        public void setColore(bool scoperto, bool elaborato) {
            if (scoperto)
            {
                if (elaborato)
                    colore = 2;
                else
                    colore = 1;
            }
            else
            {
                if (elaborato)
                    colore = 2;
                else
                    colore = 0;
            }
        }
    }
}
