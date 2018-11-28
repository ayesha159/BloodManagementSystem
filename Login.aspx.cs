using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        AJ_DataClass myClass = new AJ_DataClass();
        DataSet ds = new DataSet();
        string _email = txtemail.Text.Trim();
        string _pwd = txtpwd.Text.Trim();
        string qry = "select * from tblRegister where REmail='" + _email + "' and RPassword='" + _pwd + "'";
        ds = myClass.GetRecords("tblRegister", qry);

        if (ds.Tables[0].Rows.Count == 0)
        {
            lblmsg.Text = "Invalid User";
        }
        else
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Session["CurrentUser_ID"] = dr["r_id"];
                Response.Redirect("User-Profile.aspx");
            }
        }
    }

    protected void btnfrgPwd_Click(object sender, EventArgs e)
    {
     
        Response.Redirect("forgetPwd.aspx");
    }
}
