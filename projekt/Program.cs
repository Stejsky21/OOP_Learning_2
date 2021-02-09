using System;
using System.Collections.Generic;
using System.Text;

namespace projekt
{
    class Program
    {
        public static void Main()
        {


            ClenTymu clen1 = new ClenTymu("Filo");
            ClenTymu clen2 = new ClenTymu("Zuzka");
            ClenTymu clen3 = new ClenTymu("Petr");

            ProjektovyTym tym1 = new ProjektovyTym("DotaTeam");
            ProjektovyTym Alpha = new ProjektovyTym("AlphaTeam");

            ClenTymu Tester1 = new ClenTymu("bohus", Alpha);
            ClenTymu Tester2 = new ClenTymu("Mohus", Alpha);

            ClenTymu Programator1 = new ClenTymu("Lukas", Alpha);
            ClenTymu Programator2 = new ClenTymu("Tomas", Alpha);

            ClenTymu Manazer1 = new ClenTymu("Filip", Alpha);



            tym1.PridejClena(clen1);
            tym1.PridejClena(clen2);
            tym1.PridejClena(clen3);

            Console.WriteLine(clen1.ToString());
            Console.WriteLine(clen2.ToString());
            Console.WriteLine(Programator1);
        }
    }
}
