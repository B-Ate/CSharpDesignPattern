using System;

namespace LiskovSubstitution
{
    class Program
    {
        /*LSP prensibi Open Closed prensibinin
          özel bir türüdür desek yanlış olmaz. OCP’de de olduğu gibi LSP de de genişlemeye açık yapılar söz konusudur.
          Her ne kadar anlaşılması biraz zor olsa da LSP ilk bakışta, altında yatan ana fikri:
          alt sınıflardan oluşan nesnelerin üst sınıfın nesneleri ile yer değiştirdikleri zaman, aynı davranışı sergilemesini
          beklemektir.
          Örnek : Eğer bir ördek ise, ördek gibi ses çıkartır ama bir pile ihtiyacı vardır.
          Buda demek oluyor ki bir yerlerde yanlış abstraction gerçekleştirmişiz */

        public abstract class car
        {
            public string run()
            {
                return "araba çalıştırıldı";
            }

            public abstract string airconditioning();
        }

        public class ferrari : car
        {
            public override string airconditioning()
            {
                return "arabanın kliması çalıştırıldı.";
            }
        }

        public class murat131 : car
        {
            public override string airconditioning()
            {
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
            car ferrari = new ferrari();
            ferrari.run();
            ferrari.airconditioning(); //hata almaz

            car murat131 = new murat131();
            murat131.run();
            murat131.airconditioning(); // hata alır.


        }

        /* Çünkü her araç klimaya sahip değil. Bu yüzden murat131 liskov yasasına uymamaktadır.
         Bu durum yerine airconditioning'i interface yapabilir ve sadece kliması olan aracın
        bu özelliği kullanmasını sağlayabiliriz. Böylece tüm araçlar aynı nesnelere sahip olur
        Liskov prensibine uyabiliriz.

            public interface IAirConditionable
            {
                string OpenAirConditioning();
            }

            public abstract class Car
            {
                public string Run()
                {
                    return "Araba çalıştırıldı.";
                }
            }

            public class Ferrari : Car, IAirConditionable
            {
                public string OpenAirConditioning()
                {
                    return "Klima açıldı.";
                }
            }

            public class Murat131 : Car
            {

            }
         
         */
    }
}
