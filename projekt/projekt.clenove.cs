using System;
using System.Collections.Generic;
using System.Text;

namespace projekt.clenove
{
    public class Tester : ClenTymu
    {
        public Tester(string jmeno) : base(jmeno)
        {
        }

        public Tester(string jmeno, ProjektovyTym tym) : base(jmeno, tym)
        {
        }


        public override void SpracujUlohu(string uloha)
        {
            Console.WriteLine("Tester " + jmeno + ": " + uloha);
        }
    }

    public class Programator : ClenTymu
    {
        public Programator(string jmeno) : base(jmeno)
        {
        }

        public Programator(string jmeno, ProjektovyTym tym) : base(jmeno, tym)
        {

        }

        public override void SpracujUlohu(string uloha)
        {
            Console.WriteLine("Programator " + jmeno + ": " + uloha);
        }
    }
    public class Manazer : ClenTymu
    {
        public Manazer(string jmeno) : base(jmeno)
        {
        }

        public Manazer(string jmeno, ProjektovyTym tym) : base(jmeno, tym)
        {

        }

        public override void SpracujUlohu(string uloha)
        {
            Console.WriteLine("Manazer " + jmeno + ": " + uloha);
        }
    }

}
