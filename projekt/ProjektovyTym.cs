using projekt.clenove;
using System;
using System.Collections.Generic;
using System.Text;

namespace projekt
{
    public class ProjektovyTym
    {
        protected internal string nazev;
        protected internal ClenTymu[] clenove;

        public ProjektovyTym(string nazev)
        {
            this.nazev = nazev;
            this.clenove = new ClenTymu[] { };
        }

        public void PridejClena(ClenTymu clen)
        {
            var result = new ClenTymu[clenove.Length + 1];

            for (int i = 0; i < clenove.Length; i++)
            {
                result[i] = clenove[i];
            }

            result[^1] = clen;
            clenove = result;
            clen.tym = this;
        }
        
        public void Programuj(string uloha)
        {
            for (int i = 0; i < clenove.Length; i++)
            {
                if (clenove[i] is Programator)
                {
                    var programator = clenove[i] as Programator;
                    programator.SpracujUlohu(uloha);
                }
            }
        }

        public ClenTymu[] GetClenove()
        {
            return clenove;
        }
    }
}
