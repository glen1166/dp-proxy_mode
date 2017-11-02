using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMode
{
    public interface IGamePlayer
    {
        void login(String user, String password);

        void killBoss();

        void upgrade();

        IGamePlayer getProxy();
    }
}
