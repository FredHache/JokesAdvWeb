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
            return DAL.DataAccessLayer.GetDataTable("getJokesCategories");
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


        //Update Joke
    }
}
