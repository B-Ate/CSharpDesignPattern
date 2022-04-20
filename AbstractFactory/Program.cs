using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        /*
         aynı abstract sınıf veya interface'den türeyen nesnelerin üretiminden sorumlu yapıdır.
         Bu pattern ile nesne yaratılma işini inheritance yoluyla client-side'dan ayırıp sub-classes'lara vermek amaçlanır.
         Geliştirmekte olduğunuz uygulamaya yeni bir feature eklerken en az dokunuş ile client'ı bu duruma hiç sokmadan yapabilmek 
         amaçlanır ve factory pattern de bu amaca yönelik olarak önerilen en önemli pattern'lerden birisidir.
         Factory pattern 2 alt kategoriye ayrılabilir;
         1.Factory Method
         2.Abstract Factory
                              */

        static void Main(string[] args)
        {
            var footballFactory = new FootballFactory();

            IFootballTeam fenerbahce = footballFactory.footballTeam(TeamType.Fenerbahce);
            fenerbahce.play();

            IFootballTeam atleticomadrid = footballFactory.footballTeam(TeamType.AtleticoMadrid);
            atleticomadrid.play();

            IFootballTeam everton = footballFactory.footballTeam(TeamType.Everton);
            everton.play();


            Console.ReadKey();
        }
    }
}
