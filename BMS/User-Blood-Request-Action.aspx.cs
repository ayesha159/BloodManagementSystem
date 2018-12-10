using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Blood_Request_Action : System.Web.UI.Page
{ 
    string _UserID;
    string _dnrID;
    protected void Page_Load(object sender, EventArgs e)
{
    if (Session["CurrentUser_ID"] != null)
    {
        _UserID = Session["CurrentUser_ID"].ToString();
    }
    else
    { Response.Redirect("login.aspx"); }




    AJ_DataClass ajdbClass = new AJ_DataClass();
    DataSet ds = new DataSet();

    if (!IsPostBack)
    {
        if (Request.QueryString["id"] != null) { hfdnrid.Value = Request.QueryString["id"].ToString(); } else { Response.Redirect("SearchDonor.aspx"); }



        ds = ajdbClass.GetRecords("tblCities", "select * from tblCities");
        cbodcities.DataSource = ds.Tables[0];
        cbodcities.DataValueField = "ct_id";
        cbodcities.DataTextField = "ctName";
        cbodcities.DataBind();

        ds = ajdbClass.GetRecords("tblBloodGroups", "select * from tblBloodGroups");
        cbodBGroup.DataSource = ds.Tables[0];
        cbodBGroup.DataValueField = "Bl_id";
        cbodBGroup.DataTextField = "BlName";
        cbodBGroup.DataBind();


        ds = ajdbClass.GetRecords("tblCities", "select * from tblCities");
        cboacities.DataSource = ds.Tables[0];
        cboacities.DataValueField = "ct_id";
        cboacities.DataTextField = "ctName";
        cboacities.DataBind();

        ds = ajdbClass.GetRecords("tblBloodGroups", "select * from tblBloodGroups");
        cboaBGroup.DataSource = ds.Tables[0];
        cboaBGroup.DataValueField = "Bl_id";
        cboaBGroup.DataTextField = "BlName";
        cboaBGroup.DataBind();




        ds.Clear();
        ds = ajdbClass.GetRecords("tblRegister", "select * from tblRegister where r_id='" + hfdnrid.Value + "'");

        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            lbldname.Text = dr["rname"].ToString().Trim();
            cbodBGroup.SelectedValue = dr["rbl_id"].ToString().Trim();
            lbldemail.Text = dr["remail"].ToString().Trim();
            cbodcities.SelectedValue = dr["rct_id"].ToString().Trim();
            cbodgender.SelectedValue = dr["rgender"].ToString().Trim();
            lbldcon.Text = dr["rcontact"].ToString().Trim();
            lbldAddr.Text = dr["raddress"].ToString().Trim();



        }

        ds.Clear();
        ds = ajdbClass.GetRecords("tblRegister", "select * from tblRegister where r_id='" + _UserID + "'");


        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            lblaname.Text = dr["rname"].ToString().Trim();
            cboaBGroup.SelectedValue = dr["rbl_id"].ToString().Trim();
            lblaemail.Text = dr["remail"].ToString().Trim();
            cboacities.SelectedValue = dr["rct_id"].ToString().Trim();
            cboagender.SelectedValue = dr["rgender"].ToString().Trim();
            lblacon.Text = dr["rcontact"].ToString().Trim();
            lblaAddr.Text = dr["raddress"].ToString().Trim();

        }




    }
}

protected void btnRegister_Click(object sender, EventArgs e)
{
    AJ_DataClass ajdbClass = new AJ_DataClass();

    // check if request is already has been sent to donor by this user
    string qryCheck = "select * from tblRequestForBlood where tAcceptor_id ='" + _UserID + "' and tDonor_id='" + hfdnrid.Value + "' and tRejected ='false'";
    int trec = ajdbClass.TRec(qryCheck);
    if (trec != 0) { lblmsg.Text = "You already have sent a request for this donor."; return; } else lblmsg.Text = "";

    string _DataFields = "tAcceptor_id,tDonor_id,tBloodGroup_id,tRequestDate ";
    string _Values = "'" + _UserID + "','" + hfdnrid.Value + "','" + cbodBGroup.SelectedValue + "','" + DateTime.Now.ToShortDateString() + "'";
    string Result = ajdbClass.InsertIntoDatabase("tblRequestForBlood", _DataFields, _Values);
    lblmsg.Text = Result + " Your request has been sent ";
}
}