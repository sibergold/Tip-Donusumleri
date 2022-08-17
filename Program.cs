using System;
namespace tip_donusumleri{
class Program {
    static void Main(string[] args){
        Console.WriteLine("***** İmplicit Conversion *****");
        byte a=5;
        sbyte b=30;
        short c=10;
        int d=a+b+c;
        Console.WriteLine("d:" + d);
        long h=d;
        Console.WriteLine("h:" + h);
        float i=h;
        Console.WriteLine("i:" + i);
        string e="Zikriye";
        char f = 'k';
        object g= e + f + d;
        Console.WriteLine("g:" + g);   
        Console.WriteLine("***** Explicit Conversion ******");
        int x=4;
        byte y=(byte)x;
        Console.WriteLine("y:" + y);
        int z=100;
        byte t=(byte)z;
        Console.WriteLine("t:" + t);
        float w=18.3f;
        byte v=(byte)w;
        Console.WriteLine("v:" + v);
        Console.WriteLine("***** ToString Metodu *****");
        int xx=6;
        string yy= Convert.ToString(xx);
        Console.WriteLine("yy:" + yy);
        string zz=Convert.ToString(12.5f);
        Console.WriteLine("zz:" + zz);
        Console.WriteLine("**** System.Convert Sınıfı ****");
        string s1="18", s2="20";
        int sayi1, sayi2;
        int Toplam;
        sayi1=Convert.ToInt32(s1);
        sayi2=Convert.ToInt32(s2);
        Toplam=sayi1+sayi2;
        Console.WriteLine("Toplam:" + Toplam);
        Console.WriteLine("**** Parse Methodu****");
         ParseMethod();
        }
       public static void ParseMethod() {
        string metin1="10";
        string metin2="10.25";
        int rakam1;
        double double1;
        rakam1=Int32.Parse(metin1);
        double1=Double.Parse(metin2);
        Console.WriteLine("rakam1:" + rakam1);
        Console.WriteLine("double1:" + double1);
       }

}
}