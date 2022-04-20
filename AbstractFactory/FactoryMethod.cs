using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /*
     * Aynı interface'i veya abstract sınıfı implement etmiş etmiş factory nesnelerinin üretiminden sorumlu pattern dir.
     */
    
    public interface IFootballTeam
    {
        void play();
    }

    public class Fenerbahce : IFootballTeam
    {
        public void play()
        {
            Console.WriteLine("Fenerbahce play");
        }
    }

    public class Everton : IFootballTeam
    {
        public void play()
        {
            Console.WriteLine("Everton play");
        }
    }

    public class AtleticoMadrid : IFootballTeam
    {
        public void play()
        {
            Console.WriteLine("AtleticoMadrid play");
        }
    }
}
