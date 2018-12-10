using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Donor_Acceptor_Appointment : System.Web.UI.Page
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
            if (Request.QueryString["id"] != null) { hftid.Value = Request.QueryString["id"].ToString(); } else { Response.Redirect("SearchDonor.aspx"); }

            ds = ajdbClass.GetRecords("tblCities", "select * from tblCities");
            cboacities.DataSource = ds.Tables[0];
            cboacities.DataValueField = "ct_id";
            cboacities.DataTextField = "ctName";
            cboacities.DataBind();


            ds.Clear();
            ds = ajdbClass.GetRecords("tblRequestForBlood", "select * from tblRequestForBlood where t_id='" + hftid.Value + "'");

            string _acceptorid = "";
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
               _acceptorid =  dr["tAcceptor_id"].ToString().Trim();
            }



            ds.Clear();
            ds = ajdbClass.GetRecords("tblRegister", "select * from tblRegister where r_id='" + _acceptorid + "'");


            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                lblaname.Text = dr["rname"].ToString().Trim();
                lblaemail.Text = dr["remail"].ToString().Trim();
                cboacities.SelectedValue = dr["rct_id"].ToString().Trim();
                cboagender.SelectedValue = dr["rgender"].ToString().Trim();
                lblacon.Text = dr["rcontact"].ToString().Trim();
                lblaAddr.Text = dr["raddress"].ToString().Trim();

            }




        }
    }

    

    protected void btnSetAppointment_Click(object sender, EventArgs e)
    {
        DateTime temp;
        if (DateTime.TryParse(txtdate.Text, out temp))
        {
            lblmsg.Text = "";
        }
        else
        {
            lblmsg.Text = "Invalid Date";
            txtdate.Focus();
            return;
        }

        AJ_DataClass ajdbClass = new AJ_DataClass();
        string updateQry = "update tblRequestForBlood set tAcceptedbyDonor='true',tMeetingPlace='" + txtPlace.Text.Trim().Replace("'", "''").Trim() +"',tMeetingAddress='" + txtmsg.InnerText +"',tMeetingDate='"+txtdate.Text.Trim().Replace("'", "''").Trim() + "' where t_id='" +hftid.Value + "'";
        lblmsg.Text = ajdbClass.UpdateDatabase(updateQry);
        if (lblmsg.Text.Trim() == "Update Record(s) Succfully") { btnSetAppointment.Enabled = false; }
        
        
        
    }
}