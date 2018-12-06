using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class User_Profile : System.Web.UI.Page
{

    string _UserID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CurrentUser_ID"] != null)
        {
            _UserID = Session["CurrentUser_ID"].ToString();
        } else
        { Response.Redirect("login.aspx"); }

        AJ_DataClass ajdbClass = new AJ_DataClass();
        DataSet ds = new DataSet();

        if (!IsPostBack)
        {
            



            ds = ajdbClass.GetRecords("tblCities", "select * from tblCities");
            cboCities.DataSource = ds.Tables[0];
            cboCities.DataValueField = "ct_id";
            cboCities.DataTextField = "ctName";
            cboCities.DataBind();

            ds = ajdbClass.GetRecords("tblBloodGroups", "select * from tblBloodGroups");
            cboBGroup.DataSource = ds.Tables[0];
            cboBGroup.DataValueField = "Bl_id";
            cboBGroup.DataTextField = "BlName";
            cboBGroup.DataBind();


            ds.Clear();
            ds = ajdbClass.GetRecords("tblRegister", "select * from tblRegister where r_id='" + _UserID + "'");
            string _isAcceptor = "false";
            string _isDonor = "false";

            foreach (DataRow dr in ds.Tables[0].Rows) { 


          txtName.Text = dr["rname"].ToString().Trim();
          cboBGroup.SelectedValue = dr["rbl_id"].ToString().Trim();
           lblEmail.Text = dr["remail"].ToString().Trim();
            cboCities.SelectedValue = dr["rct_id"].ToString().Trim();
            cboGender.SelectedValue = dr["rgender"].ToString().Trim();
            txtcontact.Text = dr["rcontact"].ToString().Trim();
            txtaddr.Text = dr["raddress"].ToString().Trim();
            _isAcceptor =  dr["risAcceptor"].ToString().Trim();
            _isDonor =  dr["risdonor"].ToString().Trim();
                if (_isAcceptor == "True")  chkAcceptor.Checked = true;
                if (_isDonor == "True") chkDonor.Checked = true;

        }




    }
    }





    protected void btnUpdate_Click(object sender, EventArgs e)

    {

        string _isAcceptor = "false";
        string _isDonor = "false";
        if (chkAcceptor.Checked == true) _isAcceptor = "True";
        if (chkDonor.Checked == true) _isDonor = "True";

        AJ_DataClass ajdbClass = new AJ_DataClass();
        string updateQry = "update tblRegister set rName = '" + txtName.Text.Replace("'", "''").Trim() + "'," +
        "rcontact='" + txtcontact.Text.Trim().Replace("'", "''") + "'," +
        "raddress='" + txtaddr.Text.Trim().Replace("'", "''") + "'," +
        "rbl_id='" + cboBGroup.SelectedValue +"'," +
        "rct_id='" + cboCities.SelectedValue +"'," +
        "rgender='" + cboGender.SelectedValue +"'," +
        "risAcceptor='" + _isAcceptor +"'," +
        "risDonor='" +_isDonor +"' " +
        "  where r_id='" + _UserID+ "'";
        lblmsg.Text = ajdbClass.UpdateDatabase(updateQry);



    }
}