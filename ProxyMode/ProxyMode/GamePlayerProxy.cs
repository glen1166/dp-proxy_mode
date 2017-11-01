using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMode
{
    public class GamePlayerProxy : IGamePlayer
    {
        private IGamePlayer gamePlayer = null;

        public GamePlayerProxy(string name)
        {
            try
            {
                gamePlayer = new GamePlayer(this, name);
            }
            catch (Exception ex) {
                
            }
        }

        public void login(string user, string password)
        {
            this.gamePlayer.login(user, password);
        }

        public void killBoss()
        {
            this.gamePlayer.killBoss();
        }

        public void upgrade()
        {
            this.gamePlayer.upgrade();
        }
    }
}
