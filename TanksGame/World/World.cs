using Tanks.World.Entitys;

namespace Tanks.World
{
    class World
    {
        public List<Tank> players;
        public World()
        {
            players = new List<Tank>();
            players.Add(new Tank());
        }
    }
}