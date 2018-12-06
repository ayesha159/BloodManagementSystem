using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string strcon = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        string _id = null;
        if (Session["CurrentUser_ID"] != null)
        {
            _id = Session["CurrentUser_ID"].ToString().Trim();
            AJ_DataClass myDataClass = new AJ_DataClass();
            string CurrentUser = "";
            string UserRole = "";
            myDataClass.GetUserInfo(_id, ref CurrentUser, ref UserRole);
            lblUser.Text = CurrentUser;
            lblUserRole.Text = UserRole;

            mnuLogin.Visible = false;
            mnuRegister.Visible = false;
            mnuLogOut.Visible = true;
            mnuChangePWD.Visible = true;
        } else
        {
            mnuLogin.Visible = true;
            mnuRegister.Visible = true;
            mnuLogOut.Visible = false;
            mnuChangePWD.Visible = false;
        }
    }
}