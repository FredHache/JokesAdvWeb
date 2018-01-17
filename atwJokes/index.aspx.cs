using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOL;

namespace atwJokes
{
    public partial class index : System.Web.UI.Page
    {
        private string strConn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getCategories();
            }
        }



        #region METHODS
        private void getCategories()
        {
            ddlCategories.DataTextField = "categoryName";
            ddlCategories.DataValueField = "categoryID";
            ddlCategories.DataSource = Factory.CategoryListFactory();
            ddlCategories.DataBind();
        }
        #endregion

        protected void ddlCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCategories.SelectedIndex > 0)
            {
                int CatId = Convert.ToInt32(ddlCategories.SelectedValue);
                List<JokeLookupList> jokesByCat = Factory.JokeByCategoryListFactory(CatId);
                rptJokesByCat.DataSource = jokesByCat;
                rptJokesByCat.DataBind();
            }
        }
    }
}