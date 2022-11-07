using System;
using System.Collections.Generic;

namespace titkositobeadando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irjon be a szöveget");
            string szoveg = Console.ReadLine();
            //Console.WriteLine("Mennyivel tolja el");
            //int eltolas = int.Parse(Console.ReadLine());
            //Console.WriteLine(Cesarkodolo(szoveg,eltolas)); 

            Csoportoshelyettesites a1 = new Csoportoshelyettesites(szoveg.ToUpper());
            ;
            List<string> lista = a1.Kodolszoveg();
            Console.WriteLine(a1.ToString());
            Console.ReadLine();
        }
        static string Cesarkodolo(string szoveg,int kod)
        {
            char[] karakterek = new char[szoveg.Length];
            for (int i = 0; i < szoveg.Length; i++)
            {
                karakterek[i] = szoveg[i];
            }
            string uzenet = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                uzenet += (char)((int)karakterek[i] + kod);
            }
            return uzenet;
            
            
        }


        static string Csoportoshelyettesites(string szoveg)
        {
            string[,] tablazat = new string[,]
            {
                { " ","AA","AB","AC","BA","BB","BC","CA","CB","CC"},
                { "A","-","W","U","S","Z,","U","P","K","M"},
                { "B","F","G","B","D","Q","R","N","L","J"},
                { "C","I","E","C","A","H","X","Y","T","V"}

            };

              return "";

        }

       
            





        



    }
    class Csoportoshelyettesites
    {



        private char[] szovegtomb;

        private List<string> eredmeny;

        public Csoportoshelyettesites(string szoveg)
        {
            szovegtomb = szoveg.ToCharArray();
            eredmeny = new List<string>();
        }

        public List<string> Kodolszoveg()
        {
            
            for (int i = 0; i < szovegtomb.Length; i++)
            {
                switch (szovegtomb[i])
                {
                    case 'A':
                    eredmeny.Add("CBA ");    
                    break;

                    case 'B':
                    eredmeny.Add("BAC ");
                    break;

                    case 'C':
                        eredmeny.Add("CAC ");
                        break;
                    case 'D':
                        eredmeny.Add("BBA ");
                        break;
                    case 'E':
                        eredmeny.Add("CAB ");
                        break;
                    case 'F':
                        eredmeny.Add("BAA ");
                        break;
                    case 'G':
                        eredmeny.Add("BAB ");
                        break;
                    case 'H':
                        eredmeny.Add("CBB ");
                        break;
                    case 'I':
                        eredmeny.Add("CAA ");
                        break;
                    case 'J':
                        eredmeny.Add("BCC ");
                        break;
                    case 'K':
                        eredmeny.Add("ACB ");
                        break;
                    case 'L':
                        eredmeny.Add("BCB ");
                        break;
                    case 'M':
                        eredmeny.Add("ACC ");
                        break;
                    case 'N':
                        eredmeny.Add("BCA ");
                        break;
                    case 'O':
                        eredmeny.Add("ABC ");
                        break;
                    case 'P':
                        eredmeny.Add("ACA ");
                        break;
                    case 'Q':
                        eredmeny.Add("BBB ");
                        break;
                    case 'R':
                        eredmeny.Add("BBC ");
                        break;
                    case 'S':
                        eredmeny.Add("ABA ");
                        break;
                    case 'T':
                        eredmeny.Add("CCB ");
                        break;
                    case 'U':
                        eredmeny.Add("AAC ");
                        break;
                    case 'V':
                        eredmeny.Add("CCC ");
                        break;
                    case 'W':
                        eredmeny.Add("AAB ");
                        break;
                    case 'X':
                        eredmeny.Add("CBC ");
                        break;
                    case 'Y':
                        eredmeny.Add("CCA ");
                        break;
                    case 'Z':
                        eredmeny.Add("ABB ");
                        break;
                    case '_':
                        eredmeny.Add("AAA ");
                        break;
                }
            }
            return eredmeny;

        }
        public override string ToString()
        {
            string osszefuzes = "";
            for (int i = 0; i < eredmeny.Count; i++)
            {
                osszefuzes += $"{eredmeny[i]}";
            }
            return osszefuzes;
              
        }
    }
}
