using System;
using System.Data;
using System.Web.Script.Services;
using System.Web.Services;
using AjaxControlToolkit;
//引入命名空间

///<summary>
///  PlayPhoto 的摘要说明
///</summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
//若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。 
[ScriptService]
public class PlayPhoto : WebService
{
    [WebMethod]
    [ScriptMethod]
    public Slide[] GetPhotos(string contextKey)
    {
        //判断参数是否为空
        if (string.IsNullOrEmpty(contextKey)) return null;
        int categoryID = -1;
        //将获取到的分类ID赋予变量
        if (!Int32.TryParse(contextKey, out categoryID)) return null;
        //获取分类包含的照片
        Album am = new Album();
        DataSet ds = am.ShowPhoto(categoryID);
        if (ds == null || ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0) return null;
        //创建图片数组
        Slide[] photos = new Slide[ds.Tables[0].Rows.Count];
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            Slide photo = new Slide();
            photo.Name = ds.Tables[0].Rows[i]["Title"].ToString();
            photo.Description = ds.Tables[0].Rows[i]["Descript"].ToString();
            photo.ImagePath = "UpSmall/" + ds.Tables[0].Rows[i]["Url"];
            photos[i] = photo;
        }
        return photos;
    }
}