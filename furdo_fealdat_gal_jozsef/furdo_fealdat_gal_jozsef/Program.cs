using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace furdo_fealdat_gal_jozsef
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Adatsor> adatok = new List<Adatsor>();
            string[] f = File.ReadAllLines("furdoadat.txt");
            
            for (int i = 0; i < f.Length; i++)
            {
                adatok.Add(new Adatsor (f[i]));
            }

            //2.feladat-----------------

            /*for (int i = 0; i < f.Length; i++)
            {
                if (s == adatok[i].)
                {
                    Console.WriteLine(teszt[i].valasz + " (a versenyző válasza)");
                    valaki = i;
                }

            }
            */
            int elso_ora = 0;
            int elso_perc = 0;
            int elso_mp = 0;

            int utolso_ora = 0;
            int utolso_perc = 0;
            int utolso_mp = 0;

            /*
            for (int i = 0; i < f.Length; i++)
            {
                if (adatok[i].bekilepes == false && adatok[i].reszlegazonosito == 0 )
                {
                    

                    utolso_ora = adatok[i].ora;
                    utolso_perc = adatok[i].perc;
                    utolso_mp = adatok[i].masodperc;
                }
                

                
            }
            elso_ora = adatok[0].ora;
            elso_perc = adatok[0].perc;
            elso_mp = adatok[0].masodperc;





            Console.WriteLine("2.feladat");
            Console.WriteLine($"Az első vendég  {elso_ora}:{elso_perc}:{elso_mp}-kor lépett ki az öltözőből.");
            Console.WriteLine($"Az utolsó vendég  {utolso_ora}:{utolso_perc}:{utolso_mp}-kor lépett ki az öltözőből.\n");

            
            */

            

            

            Console.WriteLine("3.feladat");
            Console.WriteLine($"A fürdőben ??? vendég járt csak egy részlegen\n");





            /*int legtobb_be_ora = 0;
            int legtobb_be_perc = 0;
            int legtobb_be_mp = 0;

            int legtobb_ki_ora = 0;
            int legtobb_ki_perc= 0;
            int legtobb_ki_mp = 0;

            */



            Console.WriteLine("4.feladat");
            Console.WriteLine("A legtöbb időt eltöltő vendég:");
            Console.WriteLine($" ???. vendég ??? \n");

            Console.WriteLine("5.feladat");
            Console.WriteLine("6-9 óra között vendég ???");
            Console.WriteLine("9-16 óra között vendég ???");
            Console.WriteLine("16-20 óra között vendég ???\n");

            Console.WriteLine("7.feladat");
            Console.WriteLine("Uszoda: ?? ");
            Console.WriteLine("Szaunák: ??");
            Console.WriteLine("Gyógyvizes medencék: ??");
            Console.WriteLine("Strand: ??");


            Console.WriteLine($"{adatok[1].ido}");


            Console.ReadKey();
        }
    }
}
