using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class Program
    {
        /*
         Bu prensip bizlere OOP yaparken şu 2 kurala uymamız gerektiğini söylüyor;
            Üst seviye (High-Level) sınıflar alt seviye (Low-Level) sınıflara bağlı olmamalıdır,
            aralarındaki ilişki abstraction veya interface kullanarak sağlanmalıdır,
            Abstraction detaylara bağlı olmamalıdır, aksine detaylar abstraction'lara bağlı olmalıdır.
             */
        public class FileLogger
        {
            public string Message { get; set; }
            public void Log()
            {
                //File Log
            }
        }

        public class DBLogger
        {
            public string Message { get; set; }
            public void Log()
            {
                //Database Log
            }
        }

        public class LogManager
        {
            private FileLogger _file;
            private DBLogger _db;

            public LogManager()
            {
                _file = new FileLogger();
                _db = new DBLogger();
            }

            public void Log()
            {
                _file.Log();
                _db.Log();
            }
        }

        /*
         * Yukarıda görüldüğü gibi LogManager üst seviye class'ımız ve tam da Dependency Inversion prensibine ters olarak FileLogger 
         * ve DBLogger class'larına yani alt seviye class'lara bağlı. DIP bize bu gibi alt-üst seviye sınıf ilişkilerini abstraction 
         * veya interface'ler kullanarak kurmamızı söylüyor ancak durum şuan bunun tam tersi ve yarın bir gün yöneticiniz geldi dedi ki
         * "bundan sonra uygulama Log'ları EventLog'a da yazdırılacak". Bunun için gidip aynen File-DB Logger class'larında olduğu gibi
         * EventLogger adında bir class tanımlayıp LogManager() içerisinde aynı işlemleri yapmak heralde istediğimiz bir çözüm değildir
         * ki bu LogManger class'ına extra bir nesneye daha bağlı hale getirir. Hedefimiz LogManager class'ını olabildiğince nesne
         * bağımsız hale getirmek.
         */

        interface ILogger
        {
            void Log();
        }

        class FileLogger2 : ILogger
        {
            public void Log()
            {
                throw new NotImplementedException();
            }
        }

        class DBLogger2 : ILogger
        {
            public void Log()
            {
                throw new NotImplementedException();
            }
        }

        class LogManager2
        {
            private ILogger _logger;

            public LogManager2(ILogger logger)
            {
                _logger = logger;
            }

            public void WriteToLog()
            {
                _logger.Log();
            }
        }

        static void Main(string[] args)
        {
            var dbLogger = new DBLogger2();
            dbLogger.Log();

            var fileLogger = new FileLogger2();
            fileLogger.Log();
        }
    }
}
