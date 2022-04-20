using System;

namespace SingleResponsibility
{
    //Single Responsibility prensibindeki asıl amaç:
    //bir class veya function’a sadece ve sadece tek bir sorumluluğu yerine getirmesine dayanmaktadır.
    //Bu şekildeki kullanımlarda hem kodumuzun 
    //kontrolü daha kolaylaşıyor hem de tekrar kullanılabilirliği (Reusability) artıyor.
    class Program
    {
        static void Main(string[] args)
        {
            new User();
            User.GetName();
            Company company = new Company();
            Console.ReadKey();
        }
    }

    public class User
    {
        public User()
        {
            Console.WriteLine("Soyadı Getir");
        }

        public static void GetName()
        {
            Console.WriteLine("İsmi Getir");
        }

        void GetSurname()
        {
            Console.WriteLine("Soyadı Getir");
        }
    }

    public class Company
    {
        public Company()
        {
            CompanyDetail();
        }

        void CompanyDetail()
        {
            Console.WriteLine("Şirket Detayı Şöyledir");
        }
    }
}
