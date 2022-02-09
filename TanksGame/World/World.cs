using Tanks.World.Entitys;

namespace Tanks.World
{
    class World
    {
        public List<Player> players;
        public World()
        {
            players = new List<Player>();
            players.Add(new Player());
        }
    }
}