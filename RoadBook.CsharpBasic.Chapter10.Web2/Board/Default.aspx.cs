using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using RoadBook.CsharpBasic.Chapter10.Model;
using RoadBook.CsharpBasic.Chapter10.Manager;

namespace RoadBook.CsharpBasic.Chapter10.Web2.Board
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseInfo dbInfo = new DatabaseInfo();
            dbInfo.Name = "RoadbookDB";
            dbInfo.Ip = "127.0.0.1";
            dbInfo.Port = 1433;
            dbInfo UserId = "sa";
            dbInfo.UserPassword = "asdf1212";

            MsSqlManager ms = new MsSqlManager();
            ms.Open(dbInfo);

            DataTable dt = ms.Select("SELECT IDX, TITLE, SUMMARY, CREATE_DT," +
                "CREATE_USER_NM,TAGS,LIKE_CNT,CATEGORY_IDX FROM TB_CONTENTS");
            GridView1.DataSource = dtt;
            Grideview1.DataBind();
        }
    }
}