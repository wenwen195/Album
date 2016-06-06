using System;
using System.Web.UI;

public partial class Default2 : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void imgBtn_sure_Click(object sender, ImageClickEventArgs e)
    {
        //声明类实例
        Album am = new Album();
        //执行插入数据的操作
        int result = am.AddCategory(tbName.Text.Trim(), ddlStatus.SelectedValue);
        if (result == 0)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "",
                                                "alert('已有此分类，请重新填写！');location.href='Category.aspx';", true);
        }
        else
        {
            if (result > 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "",
                                                    "alert('创建成功^_^快快上传照片吧！');location.href='Photo_load.aspx';", true);
            }
            else
            {
                return;
            }
        }
    }

    protected void imgBtn_reset_Click(object sender, ImageClickEventArgs e)
    {
        tbName.Text = string.Empty;
    }
}