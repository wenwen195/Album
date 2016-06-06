using System;
using System.Web.UI;

public partial class Photo_slide : Page
{
    public int categoryID = -1;
    public string categoryName = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["CategoryID"] != null)
        {
            categoryID = Int32.Parse(Request.Params["CategoryID"]);
            if (Request.Params["CategoryName"] != null)
            {
                categoryName = Request.Params["CategoryName"];
                hlk_cname.Text = categoryName;
                hlk_cname.NavigateUrl = "~/Photo_list.aspx?CategoryID=" + categoryID.ToString() + "&CategoryName=" +
                                        categoryName;
            }
        }
        if (categoryID > 0)
        {
            ssePhoto.AutoPlay = true;
            ssePhoto.UseContextKey = true;
            ssePhoto.ContextKey = categoryID.ToString();
            return;
        }
    }
}