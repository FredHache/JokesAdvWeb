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
    public partial class createNewJoke : System.Web.UI.Page
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
            }
        }

        private void getCategories()
        {
            ddlCat.DataTextField = "categoryName";
            ddlCat.DataValueField = "categoryID";
            ddlCat.DataSource = Factory.CategoryListFactory();
            ddlCat.DataBind();
        }

        private Joke AssignValues(Joke jokeOBJ)
        {
            jokeOBJ = Factory.CreateJoke();
            jokeOBJ.title = txtTitle.Text;
            jokeOBJ.teaser = txtTeaser.Text;
            jokeOBJ.joke_text = txtJokeText.Text;
            jokeOBJ.created_at = DateTime.Now;
            jokeOBJ.user_id = Convert.ToInt32(txtUser.Text);
            jokeOBJ.category_id = Convert.ToInt32(ddlCat.SelectedValue);
            jokeOBJ.featured = chkFeatured.Checked;

            return jokeOBJ;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Joke jokeOBJ = Factory.CreateJoke();
                CUD.AddJoke(AssignValues(jokeOBJ));

                alertexit1.Checked = false;
                alertexit2.Checked = true;
                SysMessage.InnerText = "Joke creation successful!";
            } catch (Exception ex)
            {
                alertexit1.Checked = true;
                alertexit2.Checked = false;
                SysMessageErr.InnerText = "Joke creation failed";
                SysDetails.InnerText = ex.Message;
            }
            
        }
    }
}