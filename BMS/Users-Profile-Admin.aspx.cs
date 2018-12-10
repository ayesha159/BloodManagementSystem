using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Users_Profile_Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["CurrentUser_ID"] == null) Response.Redirect("Login.aspx");
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
        }

        string qry = "select * from tblRegister where RisDonor='true' or RisAcceptor='true'";
        qry = "SELECT        tblRegister.r_id, tblRegister.RName, tblBloodGroups.BlName, tblRegister.RisAcceptor, tblRegister.RisDonor, tblRegister.REmail, tblCities.ctName, tblRegister.RGender, " +
                         " tblRegister.RContact, tblRegister.RAddress, tblRegister.RUserName, tblRegister.RPassword, tblRegister.RDBFree, tblRegister.rdBPrice, tblRegister.RBlock,  " +
                         " tblRegister.RBlockedDated, tblRegister.RDate " +
                         " FROM tblBloodGroups INNER JOIN " +
                         " tblRegister ON tblBloodGroups.Bl_id = tblRegister.rBl_id INNER JOIN " +
                         " tblCities ON tblRegister.Rct_id = tblCities.ct_id " +
                         " where RisDonor = 'true' or RisAcceptor='true' ";
                ds = ajdbClass.GetRecords("tblRegister", qry);
                string _litVal = "";
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    _litVal = _litVal + "<tr>" +
                    " <td style = 'text-align: center;' >" + dr["r_id"].ToString().Trim() + "</td> " +
                    " <td style = 'text-align: center;' >" + dr["rName"].ToString().Trim() + "</td> " +
                    " <td style = 'text-align: center;' >" + dr["blName"].ToString().Trim() + "</td> " +
                    " <td style = 'text-align: center;' >" + dr["ctName"].ToString().Trim() + "</td> " +
                    " <td style = 'text-align: center;' ><a href = 'Blood-Request-Form.aspx?id=" + dr["r_id"].ToString().Trim() + "'> Request </a></td> " +
                    " </tr>";
                }

             string _heaed = "<table style='border:thin solid gray; width:100%;background-color:white' cellpadding = '1' cellspacing = '1' >" +

             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Dnr-ID</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Name</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Blood Group</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>City</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>&nbsp;Send&nbsp;</td>" +
             "</tr>";

        litDnr.Text = _heaed + _litVal + "</table> ";
    }

    private void GetRecords()
    {

        AJ_DataClass ajdbClass = new AJ_DataClass();
        DataSet ds = new DataSet();


        ds.Clear();
        string qry = "select * from tblRegister where RisDonor='true'";
        qry = "SELECT        tblRegister.r_id, tblRegister.RName, tblBloodGroups.BlName, tblRegister.RisAcceptor, tblRegister.RisDonor, tblRegister.REmail, tblCities.ctName, tblRegister.RGender, " +
                         " tblRegister.RContact, tblRegister.RAddress, tblRegister.RUserName, tblRegister.RPassword, tblRegister.RDBFree, tblRegister.rdBPrice, tblRegister.RBlock,  " +
                         " tblRegister.RBlockedDated, tblRegister.RDate " +
                         " FROM  tblBloodGroups INNER JOIN " +
                         "  tblRegister ON tblBloodGroups.Bl_id = tblRegister.rBl_id INNER JOIN " +
                         " tblCities ON tblRegister.Rct_id = tblCities.ct_id " +
                         " where RisDonor = 'true' ";

        if (chkBlood.Checked == true)
        {
            qry = qry + " and bl_id='" + cboBGroup.SelectedValue + "' ";
        }

        if (chkCities.Checked == true)
        {
            qry = qry + " and ct_id = '" + cboCities.SelectedValue + "'";
        }

        ds = ajdbClass.GetRecords("tblRegister", qry);

        string _litVal = "";

        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            _litVal = _litVal + "<tr>" +
                    " <td style = 'text-align: center;' >" + dr["r_id"].ToString().Trim() + "</td> " +
                    " <td style = 'text-align: center;' >" + dr["rName"].ToString().Trim() + "</td> " +
                    " <td style = 'text-align: center;' >" + dr["blName"].ToString().Trim() + "</td> " +
                    " <td style = 'text-align: center;' >" + dr["ctName"].ToString().Trim() + "</td> " +
                    " <td style = 'text-align: center;' >f = 'Blood-Request-Form.aspx?id=" + dr["r_id"].ToString().Trim() + "'> Request </a></td> " +
                    " </tr>";
        }
        string _heaed = "<table style='border:thin solid gray; width:100%;background-color:white' cellpadding = '1' cellspacing = '1' >" +

             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Dnr-ID</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Name</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Blood Group</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>City</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>&nbsp;Send&nbsp;</td>" +
         "</tr>";

        litDnr.Text = _heaed + _litVal + "</table> ";
    }

    protected void btnsearch_Click(object sender, EventArgs e)
    {
        GetRecords();
    }
}