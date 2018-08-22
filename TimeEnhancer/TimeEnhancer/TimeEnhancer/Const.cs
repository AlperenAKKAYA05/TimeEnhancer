using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TimeEnhancer
{
    class Const
    {
        public static string GAME_LIST_URL = "https://raw.githubusercontent.com/Crpsem/TimeEnhancer/master/gameList.xml";
        public static string GAME_LIST_LOCAL = Path.Combine(Application.StartupPath, "GameList.xml");
        public static string GAME_PROCESS = Path.Combine(Application.StartupPath, "TimeEnhancer.Game.exe");
    }
}
