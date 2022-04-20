using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public enum TeamType
    {
        Fenerbahce,
        Everton,
        AtleticoMadrid
    }

    public interface IFootballFactory
    {
        IFootballTeam footballTeam(TeamType teamType);
    }

    class FootballFactory : IFootballFactory
    {
        public IFootballTeam footballTeam(TeamType teamType)
        {
            IFootballTeam footballTeam = null;

            switch (teamType)
            {
                case TeamType.Fenerbahce: footballTeam = new Fenerbahce();break;
                case TeamType.Everton: footballTeam = new Everton(); break;
                case TeamType.AtleticoMadrid: footballTeam = new AtleticoMadrid(); break;
            }

            return footballTeam;
        }
    }
}
