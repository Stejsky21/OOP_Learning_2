using System;
using System.Collections.Generic;
using System.Text;

namespace projekt
{
    public abstract class ClenTymu
    {
        protected internal string jmeno;
        protected internal ProjektovyTym tym;

        public ClenTymu(string jmeno) : this(jmeno, null)
        {
        }
        public ClenTymu(string jmeno, ProjektovyTym tym)
        {
            this.jmeno = jmeno;
            this.tym = tym;
        }

        public override string ToString() 
        {
            if(tym == null)
            {
                return jmeno;
            }
            else
            {
                return jmeno + " : " + tym.nazev;
            }

        }

        public abstract void SpracujUlohu(string uloha);
             
    }
}