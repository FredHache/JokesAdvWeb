using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace SQL
{
    public static class JokesSQL
    {

        //Display All Jokes Category
        public static DataTable RetrieveAllJokesCategory()
        {
            return DAL.DataAccessLayer.GetDataTable("getJokeCategories");
        }

        //Select Jokes from Category
        public static DataTable RetrieveJokesByCategory(int catId)
        {
            List<Parms> parms = new List<Parms>();
            parms.Add(new Parms("@categoryId", catId, ParameterDirection.Input, SqlDbType.Int));
            return DAL.DataAccessLayer.GetDataTable("getJokesByCategory", parms);
        }

        //Select Jokes Details
        public static DataTable RetrieveJokesDetails(int jokeID)
        {
            List<Parms> parms = new List<Parms>();
            parms.Add(new Parms("@id", jokeID, ParameterDirection.Input, SqlDbType.Int));
            return DAL.DataAccessLayer.GetDataTable("getJokeDetails", parms);
        }

        //Create New Joke
        public static Boolean CreateJoke(IJokes jokes)
        {
            List<Parms> parms = new List<Parms>();
            parms.Add(new Parms("@id", jokes.id, ParameterDirection.Output, SqlDbType.Int));
            parms.Add(new Parms("@title", jokes.title, ParameterDirection.Input, SqlDbType.NVarChar, 50));
            parms.Add(new Parms("@teaser", jokes.teaser, ParameterDirection.Input, SqlDbType.NVarChar, 150));
            parms.Add(new Parms("@joke_text", jokes.joke_text, ParameterDirection.Input, SqlDbType.NText));
            parms.Add(new Parms("@created_at", jokes.created_at, ParameterDirection.Input, SqlDbType.Date));
            parms.Add(new Parms("@user_id", jokes.user_id, ParameterDirection.Input, SqlDbType.Int));
            parms.Add(new Parms("@category_id", jokes.category_id, ParameterDirection.Input, SqlDbType.Int));
            parms.Add(new Parms("@featured", jokes.featured, ParameterDirection.Input, SqlDbType.Bit));

            DAL.DataAccessLayer.SendData("createJoke", parms);
            jokes.category_id = Convert.ToInt32(parms[0].value);

            return true;
        }

        //Update Joke
        public static Boolean UpdateJoke (IJokes jokes)
        {
            List<Parms> parms = new List<Parms>();
            parms.Add(new Parms("@id", jokes.id, ParameterDirection.Input, SqlDbType.Int));
            parms.Add(new Parms("@title", jokes.title, ParameterDirection.Input, SqlDbType.NVarChar, 50));
            parms.Add(new Parms("@teaser", jokes.teaser, ParameterDirection.Input, SqlDbType.NVarChar, 150));
            parms.Add(new Parms("@joke_text", jokes.joke_text, ParameterDirection.Input, SqlDbType.NText));
            parms.Add(new Parms("@created_at", jokes.created_at, ParameterDirection.Input, SqlDbType.Date));
            parms.Add(new Parms("@user_id", jokes.user_id, ParameterDirection.Input, SqlDbType.Int));
            parms.Add(new Parms("@category_id", jokes.category_id, ParameterDirection.Input, SqlDbType.Int));
            parms.Add(new Parms("@featured", jokes.featured, ParameterDirection.Input, SqlDbType.Bit));

            DAL.DataAccessLayer.SendData("updateJoke", parms);
            return true;
        }
    }
}
