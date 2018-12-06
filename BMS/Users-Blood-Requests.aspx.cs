using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Users_Blood_Requests : System.Web.UI.Page
{
    string _userId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CurrentUser_ID"] != null) { _userId = Session["CurrentUser_ID"].ToString(); }

        if (Session["CurrentUser_ID"] == null) Response.Redirect("Login.aspx");
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

        GetRecords();


    }

    private void GetRecords()
    {

        AJ_DataClass ajdbClass = new AJ_DataClass();
        DataSet ds = new DataSet();


        ds.Clear();
        string qry = "SELECT        tblRequestForBlood.tAcceptor_id, tblRequestForBlood.t_id, tblRegister.r_id, tblRegister.RName, tblBloodGroups.BlName, tblRequestForBlood.tRequestDate,  " +
                         " tblRequestForBlood.tAcceptedbyDonor, tblRequestForBlood.tRejected, tblRequestForBlood.tRejectionReason, tblRequestForBlood.tMeeting, tblRegister_1.RName AS AcptName,  " +
                         " tblCities.ctName AS acptCityName " +
" FROM            tblRequestForBlood INNER JOIN " +
                         " tblRegister ON tblRequestForBlood.tDonor_id = tblRegister.r_id INNER JOIN " +
                         " tblBloodGroups ON tblRegister.rBl_id = tblBloodGroups.Bl_id INNER JOIN " +
                         " tblRegister AS tblRegister_1 ON tblRequestForBlood.tAcceptor_id = tblRegister_1.r_id INNER JOIN " +
                         " tblCities ON tblRegister_1.Rct_id = tblCities.ct_id ";

        if (chkRejected.Checked==false)
        {
            qry = qry + " where tRejected = 'false' ";
        } else
            qry = qry + " where tRejected = 'true' ";

        if (chkCities.Checked == true)
        {
            qry = qry + " and tblRegister_1.Rct_id='" + cboCities.SelectedValue + "' ";
        }

        if (chkBlood.Checked == true)
        {
            qry = qry + " and tBloodGroup_id='" + cboBGroup.SelectedValue + "' ";
        }



        ds = ajdbClass.GetRecords("tblRequestForBlood", qry);
        lbltrec.Text = "Records found: " + ds.Tables[0].Rows.Count.ToString();
        string _litVal = "";




        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            string _acptr_id = dr["tAcceptor_id"].ToString().Trim();
            string _dnrid = dr["r_id"].ToString().Trim();
            DateTime _dt = Convert.ToDateTime(dr["tRequestDate"]);

            _litVal = _litVal + "<tr>" +
                " <td style = 'text-align: center;' >" + dr["acptCityName"].ToString().Trim() + "</td> " +
                " <td style = 'text-align: center;' >(" + _acptr_id + ")" +  dr["AcptName"].ToString().Trim() + "</td> " +

                     " <td style = 'text-align: center;' >" + dr["blName"].ToString().Trim() + "</td> " +


                     " <td style = 'text-align: center;' >(" + _dnrid + ")" + dr["rName"].ToString().Trim() + "</td> " +


                      " <td style = 'text-align: center;' >" + _dt.ToShortDateString() + "</td> " +

                      " <td style = 'text-align: center;' ><a href = 'User-Blood-Request-Action.aspx?actid=" + dr["t_id"].ToString().Trim() + "'> Action/Detail</a></td> " +





                        " </tr>";
        }
        string _heaed = "<table style='border:thin solid gray; width:100%;background-color:white' cellpadding = '1' cellspacing = '1' >" +

             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>City</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Acceptor</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>B.Needed</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Donor</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>R.Date</td>" +
             
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Action</td>" +
             






             "</tr>";



        litDnr.Text = _heaed + _litVal + "</table> ";
    }


    protected void btnsearch_Click(object sender, EventArgs e)
    {
        GetRecords();
    }
}