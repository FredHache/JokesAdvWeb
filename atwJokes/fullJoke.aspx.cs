using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOL;

namespace atwJokes
{
    public partial class fullJoke : System.Web.UI.Page
    {

        private string strConn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get Joke details
            string strJokeID = Request.QueryString["jid"];
            if (!String.IsNullOrEmpty(strJokeID))
            {
                int jid = Convert.ToInt32(strJokeID);
                createJokeObject(jid);
            }
        }

        private void createJokeObject(int jokeID)
        {
            Joke jokeOBJ = Factory.JokeByIDFactory(jokeID);
            JokeTitle.InnerText += jokeOBJ.title;
            ID.InnerText += jokeOBJ.id.ToString();
            CreatedAt.InnerText += jokeOBJ.created_at.ToString();
            UID.InnerText += jokeOBJ.user_id.ToString();
            CatID.InnerText += jokeOBJ.category_id.ToString();
            Feat.InnerText += jokeOBJ.featured.ToString();
            Teaser.InnerText += jokeOBJ.teaser;
            JokeText.InnerText += jokeOBJ.joke_text;
        }
    }
}