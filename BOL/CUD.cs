using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BOL
{
    public static class CUD
    {
        // ADD JOKE
        public static bool AddJoke(Joke joke)
        {
            bool returned = SQL.JokesSQL.CreateJoke(joke);
            return returned;
        }
        // UPDATE JOKE
        public static bool UpdateJoke(Joke joke)
        {
            bool returned = SQL.JokesSQL.UpdateJoke(joke);
            return returned;
        }
    }
}