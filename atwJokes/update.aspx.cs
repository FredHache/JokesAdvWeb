using BOL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace atwJokes
{
    public partial class update : System.Web.UI.Page
    {
        private string strConn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                alertexit1.Checked = true;
                alertexit2.Checked = true;
            }

            if (!IsPostBack)
            {
                getCategories();

                //Get Joke details
                string strJokeID = Request.QueryString["jid"];
                if (!String.IsNullOrEmpty(strJokeID))
                {
                    int jid = Convert.ToInt32(strJokeID);
                    createJokeObject(jid);
                }
            }
        }

        private void createJokeObject(int jokeID)
        {
            Joke jokeOBJ = Factory.JokeByIDFactory(jokeID);
            txtJokeTitle.Text = jokeOBJ.title;
            ddlCat.SelectedValue = jokeOBJ.category_id.ToString();
            txtTeaser.Text = jokeOBJ.teaser;
            txtJoke.Text = jokeOBJ.joke_text;
            chkFeatured.Checked = jokeOBJ.featured;
            
            hdnID.Value = jokeOBJ.id.ToString();
            hdnCreatedAt.Value = jokeOBJ.created_at.ToString();
            hdnUID.Value = jokeOBJ.user_id.ToString();
        }

        private Joke SetValue(Joke x)
        {
            int CatId = Convert.ToInt32(ddlCat.SelectedValue);

            x.id = Convert.ToInt32(hdnID.Value);
            x.title = txtJokeTitle.Text;
            x.category_id = CatId;
            x.teaser = txtTeaser.Text;
            x.joke_text = txtJoke.Text;
            x.featured = chkFeatured.Checked;
            x.created_at = Convert.ToDateTime(hdnCreatedAt.Value);
            x.user_id = Convert.ToInt32(hdnUID.Value);

            return x;
        }

        private void getCategories()
        {
            ddlCat.DataTextField = "categoryName";
            ddlCat.DataValueField = "categoryID";
            ddlCat.DataSource = Factory.CategoryListFactory();
            ddlCat.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Joke newJoke = Factory.CreateJoke();
                CUD.UpdateJoke(SetValue(newJoke));

                alertexit1.Checked = false;
                alertexit2.Checked = true;
                SysMessage.InnerText = "Joke update successful!";
            } catch (Exception ex)
            {
                alertexit1.Checked = true;
                alertexit2.Checked = false;
                SysMessageErr.InnerText = "Joke update failed";
                SysDetails.InnerText = ex.Message;
            }
        }
    }
}