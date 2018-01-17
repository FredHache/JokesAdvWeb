using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    class Factory
    {

        // Category LIST
        public static List<CategoryLookupList> CategoryListFactory()
        {
            DataTable tmpTable = ;// ADD SQL STATEMENT THINGY
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
            DataTable tmpTable = ;// ADD SQL STATEMENT THINGY
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
        public static JokeLookupList JokeByIDFactory(int JokeID)
        {
            DataTable tmpTable = ;// ADD SQL STATEMENT THINGY
            JokeLookupList tmpJokeTable = jokeByIDRepackage(tmpTable);
            return tmpJokeTable;
        }
        private static JokeLookupList jokeByIDRepackage(DataTable myTable)
        {
            JokeLookupList joke = new JokeLookupList();

            joke.id = Convert.ToInt32(myTable.Rows[0]["id"]);
            joke.title = myTable.Rows[0]["title"].ToString();
            joke.teaser = myTable.Rows[0]["teaser"].ToString();
            joke.joke_text = myTable.Rows[0]["joke_text"].ToString();
            joke.created_at = Convert.ToDateTime(myTable.Rows[0]["created_at"]);
            joke.user_id = Convert.ToInt32(myTable.Rows[0]["user_id"]);
            joke.category_id = Convert.ToInt32(myTable.Rows[0]["category_id"]);
            joke.featured = Convert.ToBoolean(myTable.Rows[0]["featured"]);
            
            return joke;
        }
    }
}
