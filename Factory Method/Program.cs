using System;

namespace Factory_Method
{
    /*
      Factory Metod tasarım deseni, birbirleriyle ilişkili nesneleri oluşturmamızda bize oldukça alternatif
      bir metod sunmaktadır. Asıl amaç, oluşturmak istediğimiz sınıfın kendisinden bir örnek istemek yerine
      Factory Metod patterni sayesinde tek bir instance üzerinden gerekli nesnenin üretilmesini sağlamaktır.
         */

    abstract class Oyun
    {
        public abstract void Platform();
    }

    class Atari : Oyun
    {
        public override void Platform()
        {
            Console.WriteLine("Bu oyun ATARİ platformunda çalışmaktadır.");
        }
    }

    class PC : Oyun
    {
        public override void Platform()
        {
            Console.WriteLine("Bu oyun PC platformunda çalışmaktadır.");
        }
    }

    class PS : Oyun
    {
        public override void Platform()
        {
            Console.WriteLine("Bu oyun PS platformunda çalışmaktadır.");
        }
    }

    enum Oyunlar
    {
        Atari,
        PC,
        PS
    }

    class Creater
    {
        public Oyun FactoryMethod(Oyunlar OyunTipi)
        {
            Oyun oyun = null;
            switch (OyunTipi)
            {
                case Oyunlar.Atari:
                    oyun = new Atari();
                    break;
                case Oyunlar.PC:
                    oyun = new PC();
                    break;
                case Oyunlar.PS:
                    oyun = new PS();
                    break;
            }
            return oyun;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Creater creater = new Creater();
            Oyun atariOyunu = creater.FactoryMethod(Oyunlar.Atari);
            Oyun pcOyunu = creater.FactoryMethod(Oyunlar.PC);
            Oyun psOyunu = creater.FactoryMethod(Oyunlar.PS);

            atariOyunu.Platform();
            pcOyunu.Platform();
            psOyunu.Platform();

            Console.Read();
        }
    }
}
