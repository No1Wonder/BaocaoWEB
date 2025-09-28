using System;
using FinanceLibrary;

public partial class api : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FinanceManager fm = new FinanceManager();

        fm.AddChi("gao", Convert.ToInt32(Request.Form["gao"]));
        fm.AddChi("my", Convert.ToInt32(Request.Form["my"]));
        fm.AddChi("gas", Convert.ToInt32(Request.Form["gas"]));

        fm.AddThu("com", Convert.ToInt32(Request.Form["com"]));
        fm.AddThu("trachanh", Convert.ToInt32(Request.Form["tra"]));
        fm.AddThu("mysuat", Convert.ToInt32(Request.Form["mysuat"]));

        Response.ContentType = "application/json";
        Response.Write("{\"chi\":" + fm.TinhTongChi() +
                       ",\"thu\":" + fm.TinhTongThu() +
                       ",\"loi\":" + fm.TinhLoiNhuan() + "}");
        Response.End();
    }
}
