using projekt.clenove;
using System;
using System.Collections.Generic;
using System.Text;

namespace projekt
{
    class Program
    {
        public static void Main()
        {

            // abstract class cannot be instantiated
            //ClenTymu clen1 = new ClenTymu("Filo");
            //ClenTymu clen2 = new ClenTymu("Zuzka");
            //ClenTymu clen3 = new ClenTymu("Petr");
            //tym1.PridejClena(clen1);
            //tym1.PridejClena(clen2);
            //tym1.PridejClena(clen3);

            //Console.WriteLine(clen1.ToString());
            //Console.WriteLine(clen2.ToString());

            ProjektovyTym TeamAlpha = new ProjektovyTym("AlphaTeam");


            ClenTymu Tester1 = new Tester("bohus");
            ClenTymu Tester2 = new Tester("Mohus");
            ClenTymu Programator1 = new Programator("Lukas");
            ClenTymu Programator2 = new Programator("Tomas");
            ClenTymu Manazer1 = new Manazer("Filip");



            TeamAlpha.PridejClena(Tester1);
            TeamAlpha.PridejClena(Tester2);
            TeamAlpha.PridejClena(Programator1);
            TeamAlpha.PridejClena(Programator2);
            TeamAlpha.PridejClena(Manazer1);

            ClenTymu[] clenove = TeamAlpha.GetClenove();

                for (int i = 0; i < clenove.Length; i++)
                {
                    Console.WriteLine(clenove[i].ToString());
                }

            TeamAlpha.Programuj("test");
            
            

        }
    }
}
