using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public static class Factory
    {
        //Create contact method
        public static Joke CreateJoke()
        {
            return new Joke();
        }

        // Category LIST
        public static List<CategoryLookupList> CategoryListFactory()
        {
            DataTable tmpTable = SQL.JokesSQL.RetrieveAllJokesCategory();
            List<CategoryLookupList> tmpCategoryTable = categoryListRepackage(tmpTable);
            return tmpCategoryTable;
        }
        private static List<CategoryLookupList> categoryListRepackage(DataTable myTable)
        {
            List<CategoryLookupList> categoryList = new List<CategoryLookupList>();
            foreach (DataRow tempRow in myTable.Rows)
            {
                CategoryLookupList tmpCategory = new CategoryLookupList();

                tmpCategory.categoryID = Convert.ToInt32(tempRow["categoryID"]);
                tmpCategory.categoryName = tempRow["categoryName"].ToString();

                categoryList.Add(tmpCategory);
            }
            return categoryList;
        }


        // JOKE LIST
        public static List<JokeLookupList> JokeByCategoryListFactory(int CategoryID)
        {
            DataTable tmpTable = SQL.JokesSQL.RetrieveJokesByCategory(CategoryID);
            List<JokeLookupList> tmpJokeTable = jokeByCategoryListRepackage(tmpTable);
            return tmpJokeTable;
        }
        private static List<JokeLookupList> jokeByCategoryListRepackage(DataTable myTable)
        {
            List<JokeLookupList> jokeList = new List<JokeLookupList>();
            foreach (DataRow tempRow in myTable.Rows)
            {
                JokeLookupList tmpJoke = new JokeLookupList();

                tmpJoke.id = Convert.ToInt32(tempRow["id"]);
                tmpJoke.title = tempRow["title"].ToString();
                tmpJoke.teaser = tempRow["teaser"].ToString();
                tmpJoke.joke_text = tempRow["joke_text"].ToString();
                tmpJoke.created_at = Convert.ToDateTime(tempRow["created_at"]);
                tmpJoke.user_id = Convert.ToInt32(tempRow["user_id"]);
                tmpJoke.category_id = Convert.ToInt32(tempRow["category_id"]);
                tmpJoke.featured = Convert.ToBoolean(tempRow["featured"]);

                jokeList.Add(tmpJoke);
            }
            return jokeList;
        }

        // JOKE BY ID
        public static Joke JokeByIDFactory(int JokeID)
        {
            DataTable tmpTable = SQL.JokesSQL.RetrieveJokesDetails(JokeID);
            Joke tmpJokeTable = jokeByIDRepackage(tmpTable.Rows[0]);
            return tmpJokeTable;
        }
        private static Joke jokeByIDRepackage(DataRow myRow)
        {
            Joke joke = new Joke();

            joke.id = Convert.ToInt32(myRow["id"]);
            joke.title = myRow["title"].ToString();
            joke.teaser = myRow["teaser"].ToString();
            joke.joke_text = myRow["joke_text"].ToString();
            joke.created_at = Convert.ToDateTime(myRow["created_at"]);
            joke.user_id = Convert.ToInt32(myRow["user_id"]);
            joke.category_id = Convert.ToInt32(myRow["category_id"]);
            joke.featured = Convert.ToBoolean(myRow["featured"]);
            
            return joke;
        }
    }
}
