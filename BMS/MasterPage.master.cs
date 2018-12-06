using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string _id = null;
        if (Session["CurrentUser_ID"] != null)
        {
            _id = Session["CurrentUser_ID"].ToString();
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
            mnuUserProfile.Visible = true;
            if (Convert.ToBoolean(UserRole.Contains("Donor"))== true) { mnuSearchDonor.Visible = true; } else { mnuSearchDonor.Visible = false; } 

            if (_id == "1")  {
                mnuUsersBloodRequests.Visible = true;
            }


        }
    }
}
