using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursif_ve_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            // rekürsif
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
                Console.WriteLine(result);
            }
            islemler instance = new islemler();
            Console.WriteLine("---------------");
            Console.WriteLine(instance.Expo(3, 4));

            // Extension 
            string ifade = "Ali Uygun ";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine("---------------");
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine("---------------");
                Console.WriteLine(ifade.Remove());
            }
            Console.WriteLine("---------------");
            Console.WriteLine(ifade.MakeLower());
            Console.WriteLine("---------------");
            Console.WriteLine(ifade.MakeUpper());
            Console.WriteLine("---------------");
            int[] dizi = {9,3,6,2,1,5,0 };
            dizi.SortArray();
            Console.WriteLine("---------------");
            dizi.EkranaYazdır();
            Console.WriteLine("---------------");
            int sayi = 5;
           Console.WriteLine( sayi.Isevent());
            Console.WriteLine("---------------");
            Console.WriteLine(ifade.GetFirstChar());
            Console.ReadLine();

        }
    }
    public class islemler
    {
        public int Expo(int sayi,int üs)
        {
            if (üs<2)
            {
                return sayi;
            }
            return Expo(sayi, üs-1)* sayi;
        }
       
    }
    public static class Extension
    {
        public static bool CheckSpaces (this string param)
        {
            return param.Contains(" ");
        }
        public static string Remove( this string param)
        {
            string[] dizi = param.Split(' ');
            return string.Join("", dizi);
        }
        public static string MakeUpper(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLower(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdır(this int[] param)
        {
            foreach (int item in param)
                Console.WriteLine(item);
        }
        public static bool Isevent(this int param)
        {
            return param % 2 == 0;
        }
        public static string GetFirstChar (this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
