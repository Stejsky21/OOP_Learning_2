using System;
using System.Collections.Generic;
using System.Text;

namespace projekt
{
    class ProjektovyTym
    {
        protected internal string nazev;
        protected internal ClenTymu[] clenove;

        public ProjektovyTym(string nazev)
        {
            this.nazev = nazev;
            this.clenove = new ClenTymu[0];
        }

        public void PridejClena(ClenTymu clen)
        {
            var result = new ClenTymu[clenove.Length + 1];

            for (int i = 0; i < clenove.Length; i++)
            {
                result[i] = clenove[i];
            }

            result[result.Length - 1] = clen;
             
            clenove = result;

            clen.tym = this;
        } 

    }
}
