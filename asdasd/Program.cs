using System;
using System.Collections.Generic;
namespace asdasd
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter to first data");
            string firstData = Console.ReadLine();
            Console.WriteLine("Enter to second data");
            string secondData = Console.ReadLine();
            Toplama(firstData, secondData);
            Cikarma(firstData, secondData);
        }
        private static void Cikarma(string a, string b)
        {
            char[] Achar = a.ToCharArray();
            char[] Bchar = b.ToCharArray();
            string ax = "";
            string bx = "";
            for (int i = 0; i < a.Length; i++)
            {
                if ((int)Achar[i] >= 48 && (int)Achar[i] <= 57)
                {
                    ax += Achar[i];
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                if ((int)Bchar[i] >= 48 && (int)Bchar[i] <= 57)
                {
                    bx += Bchar[i];
                }
            }
            if (bx =="")
                bx = "0";
            if (ax == "")
                ax = "0";
            Achar = ax.ToCharArray();
            Array.Reverse(Achar);
            ax = new string(Achar);
            Bchar = bx.ToCharArray();
            Array.Reverse(Bchar);
            bx = new string(Bchar);
            int sum = 0, kalan = 0,komsu =0;
            string top = "";
            if (ax.Length > bx.Length)
            {
                string dgs = ax;
                ax = bx;
                bx = dgs;
            }
            if (ax.Length == bx.Length)
            {
                string denemeStrB = "";
                string denemeStrA = "";
                for (int i = 0; i < bx.Length; i++)
                    {
                        int denemeIntB = (int)(bx[i] - '0');
                        int denemeIntA = (int)(ax[i] - '0');
                        denemeStrB += (char)('0' + denemeIntB);
                        denemeStrA += (char)('0' + denemeIntA);
                    }
                int AControl = Convert.ToInt32(denemeStrA);
                int BControl = Convert.ToInt32(denemeStrB);
                if (AControl>= BControl)
                {
                    int controlbase = AControl;
                    AControl = BControl;
                    BControl = controlbase;
                }
                ax = AControl.ToString();
                bx = BControl.ToString();
            }
            for (int i = 0; i < ax.Length; i++)
            {
                sum = ((int)(bx[i] - '0') - kalan) - (int)(ax[i] - '0');
                if (sum>=0) {
                        komsu = 0;
                        sum = (komsu + (int)(bx[i] - '0')) - (int)(ax[i] - '0');
                        kalan = 0;
                        top += (char)('0'+sum);
                }
                if (sum < 0)
                {
                    komsu = 10;
                    sum = (komsu + (int)(bx[i] - '0') - kalan) - (int)(ax[i] - '0');
                    kalan = 1;
                    top += (char)('0' + sum % 10);
                }
               }                
            for (int i = ax.Length; i < bx.Length; i++)
            {
                sum = (int)(bx[i] - '0') - kalan;

                top += (char)('0' + sum%10);
                kalan = sum / 10;
            }
            if (kalan > 0)
            {
                top += (char)(kalan + '0');
            }
            char[] son = top.ToCharArray();
            Array.Reverse(son);
            top = new string(son);
            Console.WriteLine("*********************************************************");
            Console.WriteLine("*******************   Çıkarma Sonuç  ******************* = " + top);
        }
        private static void Toplama(string a, string b)
        {
            char[] Achar = a.ToCharArray();
            char[] Bchar = b.ToCharArray();
            string ax ="";
            string bx = "";
            for (int i = 0; i < a.Length; i++)
            {
                if ((int)Achar[i] >= 48 && (int)Achar[i] <= 57)
                {
                    ax += Achar[i];
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                if ((int)Bchar[i] >= 48 && (int)Bchar[i] <= 57)
                {
                    bx += Bchar[i];
                }
            }
            if (bx == "")
                bx = "0";
            if (ax == "")
                ax = "0";
            if (ax.Length > bx.Length)
            {
                string dgs = ax;
                ax = bx;
                bx = dgs;
            }
            Achar = ax.ToCharArray();
            Array.Reverse(Achar);
            ax = new string(Achar);
            Bchar = bx.ToCharArray();
            Array.Reverse(Bchar);
            bx = new string(Bchar);
            int sum = 0, kalan = 0;
            string top = "";
            for (int i = 0; i < ax.Length; i++)
            {
                sum = (int)(ax[i]%48) + (int)(bx[i] %48) + kalan;
                top += (char) (sum % 10 + '0');
                kalan = sum / 10;
            }
            for (int i = ax.Length; i < bx.Length; i++)
            {
                sum = (int)(bx[i]%48)+ kalan;
                top += (char)(sum %10 + '0');
                kalan = sum / 10;
            }
            if (kalan > 0)
            {
                top += (char)(kalan + '0');
            }
            char[] son = top.ToCharArray();
            Array.Reverse(son);
            top = new string(son);
            Console.WriteLine("*********************************************************");
            Console.WriteLine("*****************   Toplama Sonuç  ****************      = "+top);
        }
    }
}
