using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    class CUD
    {
        // ADD JOKE
        public static bool AddJoke(Joke joke)
        {
            bool returned = SQL.JokesSQL.addJoke(joke);
            return returned;
        }
        // UPDATE JOKE
        public static bool UpdateJoke(Joke joke)
        {
            bool returned = SQL.JokesSQL.Updatejoke(joke);
            return returned;
        }
    }
}
