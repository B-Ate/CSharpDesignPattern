using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Program
    {
        //Interface Segregation (ISP) var.
        //Bu prensip bize kısaca şunu söylüyor; 
        //"Nesneler asla ihtiyacı olmayan property/metot vs içeren interface'leri implement etmeye zorlanmamalıdır!".

        interface ILog
        {
            void Log(string message);
            void OpenConnection();
            void CloseConnection();

        }

        class DBLogger : ILog
        {
            public void CloseConnection()
            {
                throw new NotImplementedException();
            }

            public void Log(string message)
            {
                throw new NotImplementedException();
            }

            public void OpenConnection()
            {
                throw new NotImplementedException();
            }
        }

        class FileLogger : ILog
        {
            /*
             FileLog işlemi yaparken Db de olduğu gibi bir Connection açıp kapama işlemi yok ve
             bu metotları FileLogger'da kullanmak istemiyoruz sadece ILog interface'inde tanımlı olan
             Log(string message) metodunu kullanmak istiyoruz.
               */

            public void CloseConnection()
            {
                throw new NotImplementedException();
            }

            public void Log(string message)
            {
                throw new NotImplementedException();
            }

            public void OpenConnection()
            {
                throw new NotImplementedException();
            }
        }

        //Interface Segregation kullanmak için; Tüm classları her methodu kullanmaya zorlamadan işlemlerimizi gerçekleştirmeliyiz.

        interface ILogger
        {
            void Log(string message);
        }

        interface DBLogger2 : ILogger
        {
            void OpenConnection();
            void CloseConnection();
        }

        interface FileLogger2 : ILogger
        {
            void CheckFileSize();
            void GenerateFileName();
        }

        class DBLog2 : DBLogger2
        {
            public void CloseConnection()
            {
                throw new NotImplementedException();
            }

            public void Log(string message)
            {
                throw new NotImplementedException();
            }

            public void OpenConnection()
            {
                throw new NotImplementedException();
            }
        }

        class FileLog2 : FileLogger2
        {
            public void CheckFileSize()
            {
                throw new NotImplementedException();
            }

            public void GenerateFileName()
            {
                throw new NotImplementedException();
            }

            public void Log(string message)
            {
                throw new NotImplementedException();
            }
        }
    }
}
