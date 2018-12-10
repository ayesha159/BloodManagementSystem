using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class My_Blood_Requested : System.Web.UI.Page
{
    string _userId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CurrentUser_ID"] != null) { _userId = Session["CurrentUser_ID"].ToString(); }

        if (Session["CurrentUser_ID"] == null) Response.Redirect("Login.aspx");
        AJ_DataClass ajdbClass = new AJ_DataClass();
        DataSet ds = new DataSet();

        GetRecords();


    }

    private void GetRecords()
    {

        AJ_DataClass ajdbClass = new AJ_DataClass();
        DataSet ds = new DataSet();


        ds.Clear();
        string qry = "SELECT        tblRequestForBlood.t_id, tblRequestForBlood.tAcceptor_id, tblRegister.RName, tblBloodGroups.BlName, tblRegister.REmail, tblRegister.RGender, tblRegister.RContact,  " +
"                          tblRegister.RAddress, tblCities.ctName, tblRequestForBlood.tDonor_id, tblRequestForBlood.tRequestDate, tblRequestForBlood.tRejected,tAcceptedbyDonor " +
" FROM            tblRequestForBlood INNER JOIN " +
  "                        tblRegister ON tblRequestForBlood.tAcceptor_id = tblRegister.r_id INNER JOIN " +
    "                      tblBloodGroups ON tblRequestForBlood.tBloodGroup_id = tblBloodGroups.Bl_id INNER JOIN " +
      "                    tblCities ON tblRegister.Rct_id = tblCities.ct_id " + 
     " where tDonor_id = '" + _userId + "' and tRejected='false'  ";
        ds = ajdbClass.GetRecords("tblRequestForBlood", qry);
        string _litVal = "";




        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            DateTime _dt = Convert.ToDateTime(dr["tRequestDate"]);
            _litVal = _litVal + "<tr>" +
                    "<td style = 'text-align: center;' >" + dr["tAcceptor_id"].ToString().Trim() + "</td> " +

                    " <td style = 'text-align: center;' >" + dr["rName"].ToString().Trim() + "</td> " +

                     " <td style = 'text-align: center;' >" + dr["blName"].ToString().Trim() + "</td> " +


                      " <td style = 'text-align: center;' >" + _dt.ToShortDateString() + "</td> ";
            string _Accepted = dr["tAcceptedbyDonor"].ToString().Trim();
            if (_Accepted == "True") { _litVal = _litVal + " <td style = 'text-align: center;' >Accepted </td> "; } 
            else { _litVal = _litVal + " <td style = 'text-align: center;' ><a href = 'Donor-Acceptor-Appointment.aspx?id=" + dr["t_id"].ToString().Trim() + "'> Proceed </a></td> "; }
            _litVal = _litVal +" </tr>";
        }
        string _heaed = "<table style='border:thin solid gray; width:100%;background-color:white' cellpadding = '1' cellspacing = '1' >" +

             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Acptr-ID</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Name</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Blood</td>" +
             
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Dated</td>" +
             "<td style = 'color: #C0C0C0; background-color: darkcyan' class='text-center'>Request</td>" +
             
             "</tr>";

        litDnr.Text = _heaed + _litVal + "</table> ";
    }


    protected void btnsearch_Click(object sender, EventArgs e)
    {
        GetRecords();
    }
}