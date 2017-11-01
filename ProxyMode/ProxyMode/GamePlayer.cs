using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMode
{
    public class GamePlayer : IGamePlayer
    {
        private string name = "";

        public GamePlayer(IGamePlayer _gamePlayer, string _name)
        {
            if (_gamePlayer == null)
            {
                throw new Exception("Can't create the realy player.");
            }
            else
            {
                this.name = _name;
            }
        }

        public void login(string user, string password)
        {
            Console.WriteLine("Login successfully.");
        }

        public void killBoss()
        {
            Console.WriteLine("Killed a boss.");
        }

        public void upgrade()
        {
            Console.WriteLine("Upgraded.");
        }
    }
}
