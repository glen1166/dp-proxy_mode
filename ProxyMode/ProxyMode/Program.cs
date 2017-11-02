using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMode
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamePlayer player = new GamePlayer("Jack");
            IGamePlayer proxy = player.getProxy();
            player.login("Jack", "123");
        }
    }
}
