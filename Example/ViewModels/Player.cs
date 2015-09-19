using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darkthread
{
    public partial class Player
    {
        public Player(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public void GenRandomData()
        {
            Random rnd = new Random();
            RegDate = DateTime.Today.AddDays(-127 - rnd.Next(1024));
            HighScore = rnd.Next(65535);
            IsVIP = rnd.Next(100) > 60;
        }
    }
}
