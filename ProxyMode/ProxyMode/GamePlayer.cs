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
        private IGamePlayer proxy = null;

        public GamePlayer(string _name)
        {
            this.name = _name;
        }

        public void login(string user, string password)
        {
            if (this.isProxy())
            {
                Console.WriteLine("Login successfully.");
            }
            else
            {
                Console.WriteLine("Please access it from proxy.");
            }
        }

        public void killBoss()
        {
            if (this.isProxy())
            {
                Console.WriteLine("Killed a boss.");
            }
            else
            {
                Console.WriteLine("Please access it from proxy.");
            }
        }

        public void upgrade()
        {
            if (this.isProxy())
            {
                Console.WriteLine("Upgraded.");
            }
            else
            {
                Console.WriteLine("Please access it from proxy.");
            }
        }

        public IGamePlayer getProxy()
        {
            this.proxy = new GamePlayerProxy(this);
            return this.proxy;
        }

        private bool isProxy()
        {
            return this.proxy != null;
        }
    }
}
